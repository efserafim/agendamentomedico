using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamentoMedico.Modelos
{
    public class Medico
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string NomeCompleto { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Especialidade { get; set; }
        
        [Required]
        [StringLength(20)]
        public string CRM { get; set; }
        
        [StringLength(20)]
        public string Telefone { get; set; }
        
        [StringLength(100)]
        public string Email { get; set; }
        
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        
        // Propriedade de navegação
        public virtual ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}