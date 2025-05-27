using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalScheduler.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        
        [Required]
        public int PatientId { get; set; }
        
        [Required]
        public int DoctorId { get; set; }
        
        [Required]
        public DateTime AppointmentDate { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Agendado"; // Agendado, Confirmado, Concluído, Cancelado
        
        [StringLength(500)]
        public string Notes { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        // Navigation properties
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
