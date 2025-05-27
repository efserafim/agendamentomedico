using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalScheduler.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Specialty { get; set; }
        
        [Required]
        [StringLength(20)]
        public string LicenseNumber { get; set; }
        
        [StringLength(20)]
        public string Phone { get; set; }
        
        [StringLength(100)]
        public string Email { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        // Navigation property
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
