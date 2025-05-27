using System;
using System.ComponentModel.DataAnnotations;

namespace AgendamentoMedico.Modelos
{
    public class Agendamento
    {
        public int Id { get; set; }
        
        [Required]
        public int PacienteId { get; set; }
        
        [Required]
        public int MedicoId { get; set; }
        
        [Required]
        public DateTime DataHoraAgendamento { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Agendado"; // Agendado, Confirmado, Concluído, Cancelado
        
        [StringLength(500)]
        public string Observacoes { get; set; }
        
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        
        // Propriedades de navegação
        public virtual Paciente Paciente { get; set; }
        public virtual Medico Medico { get; set; }
    }
}