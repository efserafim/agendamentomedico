using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamentoMedico.Modelos
{
    public class Paciente
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string NomeCompleto { get; set; }
        
        [StringLength(20)]
        public string Telefone { get; set; }
        
        [StringLength(100)]
        public string Email { get; set; }
        
        public DateTime DataNascimento { get; set; }
        
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        
        // Propriedade de navegação
        public virtual ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}