using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AgendamentoMedico.Dados;
using AgendamentoMedico.Modelos;

namespace AgendamentoMedico.Formularios
{
    public partial class FormularioPaciente : Form
    {
        private ContextoClinica _contexto;

        public FormularioPaciente(ContextoClinica contexto)
        {
            InitializeComponent();
            _contexto = contexto;
            CarregarPacientes();
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

        private void CarregarPacientes()
        {
            try
            {
                var pacientes = _contexto.Pacientes.OrderBy(p => p.NomeCompleto).ToList();
                dataGridViewPacientes.DataSource = pacientes.Select(p => new
                {
                    Id = p.Id,
                    Nome = p.NomeCompleto,
                    Telefone = p.Telefone,
                    Email = p.Email,
                    DataNascimento = p.DataNascimento.ToString("dd/MM/yyyy")
                }).ToList();

                dataGridViewPacientes.BackgroundColor = Color.White;
                dataGridViewPacientes.GridColor = Color.FromArgb(200, 230, 201);
                dataGridViewPacientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132);
                dataGridViewPacientes.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
                dataGridViewPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewPacientes.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pacientes: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                try
                {
                    var paciente = new Paciente
                    {
                        NomeCompleto = txtNome.Text.Trim(),
                        Telefone = txtTelefone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        DataNascimento = dtpDataNascimento.Value
                    };

                    _contexto.Pacientes.Add(paciente);
                    _contexto.SaveChanges();
                    CarregarPacientes();
                    LimparFormulario();
                    MessageBox.Show("Paciente adicionado com sucesso!", "Sucesso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar paciente: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.SelectedRows.Count > 0 && ValidarEntrada())
            {
                try
                {
                    var linhaSelecionada = dataGridViewPacientes.SelectedRows[0];
                    var pacienteId = (int)linhaSelecionada.Cells["Id"].Value;
                    
                    var paciente = _contexto.Pacientes.Find(pacienteId);
                    if (paciente != null)
                    {
                        paciente.NomeCompleto = txtNome.Text.Trim();
                        paciente.Telefone = txtTelefone.Text.Trim();
                        paciente.Email = txtEmail.Text.Trim();
                        paciente.DataNascimento = dtpDataNascimento.Value;

                        _contexto.SaveChanges();
                        CarregarPacientes();
                        LimparFormulario();
                        MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar paciente: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um paciente para atualizar.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja excluir este paciente?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        var linhaSelecionada = dataGridViewPacientes.SelectedRows[0];
                        var pacienteId = (int)linhaSelecionada.Cells["Id"].Value;
                        
                        var paciente = _contexto.Pacientes.Find(pacienteId);
                        if (paciente != null)
                        {
                            _contexto.Pacientes.Remove(paciente);
                            _contexto.SaveChanges();
                            CarregarPacientes();
                            LimparFormulario();
                            MessageBox.Show("Paciente excluído com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir paciente: {ex.Message}", "Erro", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um paciente para excluir.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dataGridViewPacientes.SelectedRows[0];
                var pacienteId = (int)linhaSelecionada.Cells["Id"].Value;
                
                var paciente = _contexto.Pacientes.Find(pacienteId);
                if (paciente != null)
                {
                    txtNome.Text = paciente.NomeCompleto;
                    txtTelefone.Text = paciente.Telefone;
                    txtEmail.Text = paciente.Email;
                    dtpDataNascimento.Value = paciente.DataNascimento;
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

            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Telefone é obrigatório.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return false;
            }

            return true;
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            dtpDataNascimento.Value = DateTime.Now;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
    }
}