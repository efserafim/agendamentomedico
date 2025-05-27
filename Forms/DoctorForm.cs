using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MedicalScheduler.Data;
using MedicalScheduler.Models;

namespace MedicalScheduler.Forms
{
    public partial class DoctorForm : Form
    {
        private ClinicContext _context;

        public DoctorForm(ClinicContext context)
        {
            InitializeComponent();
            _context = context;
            LoadDoctors();
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
                else if (control is GroupBox groupBox)
                {
                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is Button groupBtn)
                        {
                            groupBtn.BackColor = Color.FromArgb(76, 175, 80);
                            groupBtn.ForeColor = Color.White;
                            groupBtn.FlatStyle = FlatStyle.Flat;
                            groupBtn.FlatAppearance.BorderSize = 0;
                        }
                    }
                }
            }
        }

        private void LoadDoctors()
        {
            try
            {
                var doctors = _context.Doctors.OrderBy(d => d.FullName).ToList();
                dataGridViewDoctors.DataSource = doctors.Select(d => new
                {
                    Id = d.Id,
                    Nome = d.FullName,
                    Especialidade = d.Specialty,
                    CRM = d.LicenseNumber,
                    Telefone = d.Phone,
                    Email = d.Email
                }).ToList();

                dataGridViewDoctors.BackgroundColor = Color.White;
                dataGridViewDoctors.GridColor = Color.FromArgb(200, 230, 201);
                dataGridViewDoctors.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132);
                dataGridViewDoctors.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewDoctors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
                dataGridViewDoctors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewDoctors.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar médicos: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    var doctor = new Doctor
                    {
                        FullName = txtName.Text.Trim(),
                        Specialty = txtSpecialty.Text.Trim(),
                        LicenseNumber = txtLicenseNumber.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };

                    _context.Doctors.Add(doctor);
                    _context.SaveChanges();
                    LoadDoctors();
                    ClearForm();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0 && ValidateInput())
            {
                try
                {
                    var selectedRow = dataGridViewDoctors.SelectedRows[0];
                    var doctorId = (int)selectedRow.Cells["Id"].Value;
                    
                    var doctor = _context.Doctors.Find(doctorId);
                    if (doctor != null)
                    {
                        doctor.FullName = txtName.Text.Trim();
                        doctor.Specialty = txtSpecialty.Text.Trim();
                        doctor.LicenseNumber = txtLicenseNumber.Text.Trim();
                        doctor.Phone = txtPhone.Text.Trim();
                        doctor.Email = txtEmail.Text.Trim();

                        _context.SaveChanges();
                        LoadDoctors();
                        ClearForm();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este médico?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var selectedRow = dataGridViewDoctors.SelectedRows[0];
                        var doctorId = (int)selectedRow.Cells["Id"].Value;
                        
                        var doctor = _context.Doctors.Find(doctorId);
                        if (doctor != null)
                        {
                            _context.Doctors.Remove(doctor);
                            _context.SaveChanges();
                            LoadDoctors();
                            ClearForm();
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

        private void dataGridViewDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewDoctors.SelectedRows[0];
                var doctorId = (int)selectedRow.Cells["Id"].Value;
                
                var doctor = _context.Doctors.Find(doctorId);
                if (doctor != null)
                {
                    txtName.Text = doctor.FullName;
                    txtSpecialty.Text = doctor.Specialty;
                    txtLicenseNumber.Text = doctor.LicenseNumber;
                    txtPhone.Text = doctor.Phone;
                    txtEmail.Text = doctor.Email;
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

            if (string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("Especialidade é obrigatória.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecialty.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                MessageBox.Show("CRM é obrigatório.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseNumber.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtSpecialty.Clear();
            txtLicenseNumber.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
