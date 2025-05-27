using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MedicalScheduler.Data;
using MedicalScheduler.Models;

namespace MedicalScheduler.Forms
{
    public partial class PatientForm : Form
    {
        private ClinicContext _context;

        public PatientForm(ClinicContext context)
        {
            InitializeComponent();
            _context = context;
            LoadPatients();
            SetupColors();
        }

        private void SetupColors()
        {
            this.BackColor = Color.FromArgb(240, 248, 245);
            
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void LoadPatients()
        {
            try
            {
                var patients = _context.Patients.OrderBy(p => p.FullName).ToList();
                dataGridViewPatients.DataSource = patients.Select(p => new
                {
                    Id = p.Id,
                    Nome = p.FullName,
                    Telefone = p.Phone,
                    Email = p.Email,
                    DataNascimento = p.DateOfBirth.ToString("dd/MM/yyyy")
                }).ToList();

                dataGridViewPatients.BackgroundColor = Color.White;
                dataGridViewPatients.GridColor = Color.FromArgb(200, 230, 201);
                dataGridViewPatients.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132);
                dataGridViewPatients.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
                dataGridViewPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewPatients.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pacientes: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    var patient = new Patient
                    {
                        FullName = txtName.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        DateOfBirth = dtpDateOfBirth.Value
                    };

                    _context.Patients.Add(patient);
                    _context.SaveChanges();
                    LoadPatients();
                    ClearForm();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0 && ValidateInput())
            {
                try
                {
                    var selectedRow = dataGridViewPatients.SelectedRows[0];
                    var patientId = (int)selectedRow.Cells["Id"].Value;
                    
                    var patient = _context.Patients.Find(patientId);
                    if (patient != null)
                    {
                        patient.FullName = txtName.Text.Trim();
                        patient.Phone = txtPhone.Text.Trim();
                        patient.Email = txtEmail.Text.Trim();
                        patient.DateOfBirth = dtpDateOfBirth.Value;

                        _context.SaveChanges();
                        LoadPatients();
                        ClearForm();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este paciente?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var selectedRow = dataGridViewPatients.SelectedRows[0];
                        var patientId = (int)selectedRow.Cells["Id"].Value;
                        
                        var patient = _context.Patients.Find(patientId);
                        if (patient != null)
                        {
                            _context.Patients.Remove(patient);
                            _context.SaveChanges();
                            LoadPatients();
                            ClearForm();
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

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPatients.SelectedRows[0];
                var patientId = (int)selectedRow.Cells["Id"].Value;
                
                var patient = _context.Patients.Find(patientId);
                if (patient != null)
                {
                    txtName.Text = patient.FullName;
                    txtPhone.Text = patient.Phone;
                    txtEmail.Text = patient.Email;
                    dtpDateOfBirth.Value = patient.DateOfBirth;
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nome é obrigatório.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Telefone é obrigatório.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
