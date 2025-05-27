using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AgendamentoMedico.Dados;
using AgendamentoMedico.Modelos;

namespace AgendamentoMedico.Formularios
{
    public partial class FormularioMedico : Form
    {
        private ContextoClinica _contexto;

        public FormularioMedico(ContextoClinica contexto)
        {
            InitializeComponent();
            _contexto = contexto;
            CarregarMedicos();
            ConfigurarCores();
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

        private void CarregarMedicos()
        {
            try
            {
                var medicos = _contexto.Medicos.OrderBy(d => d.NomeCompleto).ToList();
                dataGridViewMedicos.DataSource = medicos.Select(d => new
                {
                    Id = d.Id,
                    Nome = d.NomeCompleto,
                    Especialidade = d.Especialidade,
                    CRM = d.CRM,
                    Telefone = d.Telefone,
                    Email = d.Email
                }).ToList();

                dataGridViewMedicos.BackgroundColor = Color.White;
                dataGridViewMedicos.GridColor = Color.FromArgb(200, 230, 201);
                dataGridViewMedicos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132);
                dataGridViewMedicos.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewMedicos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
                dataGridViewMedicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewMedicos.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar médicos: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                try
                {
                    var medico = new Medico
                    {
                        NomeCompleto = txtNome.Text.Trim(),
                        Especialidade = txtEspecialidade.Text.Trim(),
                        CRM = txtCRM.Text.Trim(),
                        Telefone = txtTelefone.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };

                    _contexto.Medicos.Add(medico);
                    _contexto.SaveChanges();
                    CarregarMedicos();
                    LimparFormulario();
                    MessageBox.Show("Médico adicionado com sucesso!", "Sucesso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar médico: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicos.SelectedRows.Count > 0 && ValidarEntrada())
            {
                try
                {
                    var linhaSelecionada = dataGridViewMedicos.SelectedRows[0];
                    var medicoId = (int)linhaSelecionada.Cells["Id"].Value;
                    
                    var medico = _contexto.Medicos.Find(medicoId);
                    if (medico != null)
                    {
                        medico.NomeCompleto = txtNome.Text.Trim();
                        medico.Especialidade = txtEspecialidade.Text.Trim();
                        medico.CRM = txtCRM.Text.Trim();
                        medico.Telefone = txtTelefone.Text.Trim();
                        medico.Email = txtEmail.Text.Trim();

                        _contexto.SaveChanges();
                        CarregarMedicos();
                        LimparFormulario();
                        MessageBox.Show("Médico atualizado com sucesso!", "Sucesso", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar médico: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico para atualizar.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicos.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja excluir este médico?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        var linhaSelecionada = dataGridViewMedicos.SelectedRows[0];
                        var medicoId = (int)linhaSelecionada.Cells["Id"].Value;
                        
                        var medico = _contexto.Medicos.Find(medicoId);
                        if (medico != null)
                        {
                            _contexto.Medicos.Remove(medico);
                            _contexto.SaveChanges();
                            CarregarMedicos();
                            LimparFormulario();
                            MessageBox.Show("Médico excluído com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir médico: {ex.Message}", "Erro", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico para excluir.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewMedicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMedicos.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dataGridViewMedicos.SelectedRows[0];
                var medicoId = (int)linhaSelecionada.Cells["Id"].Value;
                
                var medico = _contexto.Medicos.Find(medicoId);
                if (medico != null)
                {
                    txtNome.Text = medico.NomeCompleto;
                    txtEspecialidade.Text = medico.Especialidade;
                    txtCRM.Text = medico.CRM;
                    txtTelefone.Text = medico.Telefone;
                    txtEmail.Text = medico.Email;
                }
            }
        }

        private bool ValidarEntrada()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEspecialidade.Text))
            {
                MessageBox.Show("Especialidade é obrigatória.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspecialidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCRM.Text))
            {
                MessageBox.Show("CRM é obrigatório.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCRM.Focus();
                return false;
            }

            return true;
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEspecialidade.Clear();
            txtCRM.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
    }
}