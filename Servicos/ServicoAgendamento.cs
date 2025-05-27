using AgendamentoMedico.Dados;
using AgendamentoMedico.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendamentoMedico.Servicos
{
    public class ServicoAgendamento
    {
        private readonly ContextoClinica _contexto;

        public ServicoAgendamento(ContextoClinica contexto)
        {
            _contexto = contexto;
        }

        public List<Agendamento> ObterAgendamentosPorData(DateTime data)
        {
            return _contexto.Agendamentos
                .Include(a => a.Paciente)
                .Include(a => a.Medico)
                .Where(a => a.DataHoraAgendamento.Date == data.Date)
                .OrderBy(a => a.DataHoraAgendamento)
                .ToList();
        }

        public List<Agendamento> ObterAgendamentosPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            return _contexto.Agendamentos
                .Include(a => a.Paciente)
                .Include(a => a.Medico)
                .Where(a => a.DataHoraAgendamento.Date >= dataInicio.Date && a.DataHoraAgendamento.Date <= dataFim.Date)
                .OrderBy(a => a.DataHoraAgendamento)
                .ToList();
        }

        public List<Agendamento> ObterAgendamentosPorPaciente(int pacienteId)
        {
            return _contexto.Agendamentos
                .Include(a => a.Paciente)
                .Include(a => a.Medico)
                .Where(a => a.PacienteId == pacienteId)
                .OrderBy(a => a.DataHoraAgendamento)
                .ToList();
        }

        public List<Agendamento> ObterAgendamentosPorMedico(int medicoId)
        {
            return _contexto.Agendamentos
                .Include(a => a.Paciente)
                .Include(a => a.Medico)
                .Where(a => a.MedicoId == medicoId)
                .OrderBy(a => a.DataHoraAgendamento)
                .ToList();
        }

        public bool HorarioDisponivel(int medicoId, DateTime dataHoraAgendamento, int? excluirAgendamentoId = null)
        {
            var consulta = _contexto.Agendamentos
                .Where(a => a.MedicoId == medicoId && a.DataHoraAgendamento == dataHoraAgendamento);

            if (excluirAgendamentoId.HasValue)
            {
                consulta = consulta.Where(a => a.Id != excluirAgendamentoId.Value);
            }

            return !consulta.Any();
        }

        public List<Agendamento> ObterAgendamentosHoje()
        {
            var hoje = DateTime.Today;
            return ObterAgendamentosPorData(hoje);
        }

        public List<Agendamento> ObterProximosAgendamentos(int dias = 7)
        {
            var dataInicio = DateTime.Today;
            var dataFim = DateTime.Today.AddDays(dias);
            return ObterAgendamentosPorPeriodo(dataInicio, dataFim);
        }

        public int ContarAgendamentosPorStatus(string status)
        {
            return _contexto.Agendamentos.Count(a => a.Status == status);
        }

        public void AtualizarStatusAgendamento(int agendamentoId, string novoStatus)
        {
            var agendamento = _contexto.Agendamentos.Find(agendamentoId);
            if (agendamento != null)
            {
                agendamento.Status = novoStatus;
                _contexto.SaveChanges();
            }
        }
    }
}