using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AgendamentoMedico.Dados;
using AgendamentoMedico.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoMedico.Formularios
{
    public partial class FormularioAgendamento : Form
    {
        private ContextoClinica _contexto;
        private int? _agendamentoId;

        public FormularioAgendamento(ContextoClinica contexto, int? agendamentoId = null)
        {
            InitializeComponent();
            _contexto = contexto;
            _agendamentoId = agendamentoId;
            CarregarComboBoxes();
            ConfigurarCores();
            
            if (_agendamentoId.HasValue)
            {
                CarregarAgendamento();
                this.Text = "Editar Agendamento";
            }
            else
            {
                this.Text = "Novo Agendamento";
            }
        }

        private void ConfigurarCores()
        {
            this.BackColor = Color.FromArgb(240, 248, 245);
            
            foreach (Control controle in this.Controls)
            {
                if (controle is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
                else if (controle is GroupBox groupBox)
                {
                    foreach (Control controleGrupo in groupBox.Controls)
                    {
                        if (controleGrupo is Button btnGrupo)
                        {
                            btnGrupo.BackColor = Color.FromArgb(76, 175, 80);
                            btnGrupo.ForeColor = Color.White;
                            btnGrupo.FlatStyle = FlatStyle.Flat;
                            btnGrupo.FlatAppearance.BorderSize = 0;
                        }
                    }
                }
            }
        }

        private void CarregarComboBoxes()
        {
            try
            {
                // Carregar pacientes
                var pacientes = _contexto.Pacientes.OrderBy(p => p.NomeCompleto).ToList();
                cmbPaciente.DataSource = pacientes;
                cmbPaciente.DisplayMember = "NomeCompleto";
                cmbPaciente.ValueMember = "Id";

                // Carregar médicos
                var medicos = _contexto.Medicos.OrderBy(d => d.NomeCompleto).ToList();
                cmbMedico.DataSource = medicos;
                cmbMedico.DisplayMember = "NomeCompleto";
                cmbMedico.ValueMember = "Id";

                // Carregar opções de status
                cmbStatus.Items.AddRange(new string[] { "Agendado", "Confirmado", "Concluído", "Cancelado" });
                cmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarAgendamento()
        {
            if (_agendamentoId.HasValue)
            {
                try
                {
                    var agendamento = _contexto.Agendamentos
                        .Include(a => a.Paciente)
                        .Include(a => a.Medico)
                        .FirstOrDefault(a => a.Id == _agendamentoId.Value);

                    if (agendamento != null)
                    {
                        cmbPaciente.SelectedValue = agendamento.PacienteId;
                        cmbMedico.SelectedValue = agendamento.MedicoId;
                        dtpData.Value = agendamento.DataHoraAgendamento.Date;
                        dtpHorario.Value = agendamento.DataHoraAgendamento;
                        cmbStatus.SelectedItem = agendamento.Status;
                        txtObservacoes.Text = agendamento.Observacoes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar agendamento: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                try
                {
                    var dataHoraAgendamento = dtpData.Value.Date.Add(dtpHorario.Value.TimeOfDay);

                    if (_agendamentoId.HasValue)
                    {
                        // Atualizar agendamento existente
                        var agendamento = _contexto.Agendamentos.Find(_agendamentoId.Value);
                        if (agendamento != null)
                        {
                            agendamento.PacienteId = (int)cmbPaciente.SelectedValue;
                            agendamento.MedicoId = (int)cmbMedico.SelectedValue;
                            agendamento.DataHoraAgendamento = dataHoraAgendamento;
                            agendamento.Status = cmbStatus.SelectedItem.ToString();
                            agendamento.Observacoes = txtObservacoes.Text.Trim();

                            _contexto.SaveChanges();
                            MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Criar novo agendamento
                        var agendamento = new Agendamento
                        {
                            PacienteId = (int)cmbPaciente.SelectedValue,
                            MedicoId = (int)cmbMedico.SelectedValue,
                            DataHoraAgendamento = dataHoraAgendamento,
                            Status = cmbStatus.SelectedItem.ToString(),
                            Observacoes = txtObservacoes.Text.Trim()
                        };

                        _contexto.Agendamentos.Add(agendamento);
                        _contexto.SaveChanges();
                        MessageBox.Show("Agendamento criado com sucesso!", "Sucesso", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar agendamento: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidarEntrada()
        {
            if (cmbPaciente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um paciente.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaciente.Focus();
                return false;
            }

            if (cmbMedico.SelectedValue == null)
            {
                MessageBox.Show("Selecione um médico.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMedico.Focus();
                return false;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            var dataHoraAgendamento = dtpData.Value.Date.Add(dtpHorario.Value.TimeOfDay);
            if (dataHoraAgendamento <= DateTime.Now)
            {
                MessageBox.Show("A data e hora do agendamento deve ser futura.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpData.Focus();
                return false;
            }

            return true;
        }
    }
}