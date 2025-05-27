using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AgendamentoMedico.Dados;
using AgendamentoMedico.Formularios;
using AgendamentoMedico.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoMedico
{
    public partial class FormularioPrincipal : Form
    {
        private ContextoClinica _contexto;

        public FormularioPrincipal()
        {
            InitializeComponent();
            _contexto = new ContextoClinica();
            CarregarAgendamentos();
            ConfigurarCores();
        }

        private void ConfigurarCores()
        {
            // Esquema de cores verde
            this.BackColor = Color.FromArgb(240, 248, 245); // Fundo verde claro
            
            // Cores dos painéis
            painelTopo.BackColor = Color.FromArgb(46, 125, 50); // Verde escuro
            painelLateral.BackColor = Color.FromArgb(200, 230, 201); // Verde claro
            
            // Cores dos botões
            foreach (Control controle in this.Controls)
            {
                if (controle is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80); // Verde médio
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
            
            foreach (Control controle in painelLateral.Controls)
            {
                if (controle is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void CarregarAgendamentos()
        {
            try
            {
                var agendamentos = _contexto.Agendamentos
                    .Include(a => a.Paciente)
                    .Include(a => a.Medico)
                    .OrderBy(a => a.DataHoraAgendamento)
                    .ToList();

                dataGridViewAgendamentos.DataSource = agendamentos.Select(a => new
                {
                    Id = a.Id,
                    Paciente = a.Paciente.NomeCompleto,
                    Medico = a.Medico.NomeCompleto,
                    Data = a.DataHoraAgendamento.ToString("dd/MM/yyyy"),
                    Horario = a.DataHoraAgendamento.ToString("HH:mm"),
                    Status = a.Status,
                    Observacoes = a.Observacoes
                }).ToList();

                // Personalizar aparência da grade
                dataGridViewAgendamentos.BackgroundColor = Color.White;
                dataGridViewAgendamentos.GridColor = Color.FromArgb(200, 230, 201);
                dataGridViewAgendamentos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132);
                dataGridViewAgendamentos.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewAgendamentos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
                dataGridViewAgendamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewAgendamentos.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar agendamentos: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoAgendamento_Click(object sender, EventArgs e)
        {
            var formularioAgendamento = new FormularioAgendamento(_contexto);
            if (formularioAgendamento.ShowDialog() == DialogResult.OK)
            {
                CarregarAgendamentos();
            }
        }

        private void btnGerenciarPacientes_Click(object sender, EventArgs e)
        {
            var formularioPaciente = new FormularioPaciente(_contexto);
            formularioPaciente.ShowDialog();
        }

        private void btnGerenciarMedicos_Click(object sender, EventArgs e)
        {
            var formularioMedico = new FormularioMedico(_contexto);
            formularioMedico.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarAgendamentos();
        }

        private void btnEditarAgendamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgendamentos.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dataGridViewAgendamentos.SelectedRows[0];
                var agendamentoId = (int)linhaSelecionada.Cells["Id"].Value;
                
                var formularioAgendamento = new FormularioAgendamento(_contexto, agendamentoId);
                if (formularioAgendamento.ShowDialog() == DialogResult.OK)
                {
                    CarregarAgendamentos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para editar.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirAgendamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgendamentos.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja excluir este agendamento?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        var linhaSelecionada = dataGridViewAgendamentos.SelectedRows[0];
                        var agendamentoId = (int)linhaSelecionada.Cells["Id"].Value;
                        
                        var agendamento = _contexto.Agendamentos.Find(agendamentoId);
                        if (agendamento != null)
                        {
                            _contexto.Agendamentos.Remove(agendamento);
                            _contexto.SaveChanges();
                            CarregarAgendamentos();
                            MessageBox.Show("Agendamento excluído com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir agendamento: {ex.Message}", "Erro", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para excluir.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _contexto?.Dispose();
            base.OnFormClosed(e);
        }
    }
}