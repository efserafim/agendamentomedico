using MedicalScheduler.Data;
using MedicalScheduler.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalScheduler.Services
{
    public class AppointmentService
    {
        private readonly ClinicContext _context;

        public AppointmentService(ClinicContext context)
        {
            _context = context;
        }

        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            return _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .Where(a => a.AppointmentDate.Date == date.Date)
                .OrderBy(a => a.AppointmentDate)
                .ToList();
        }

        public List<Appointment> GetAppointmentsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .Where(a => a.AppointmentDate.Date >= startDate.Date && a.AppointmentDate.Date <= endDate.Date)
                .OrderBy(a => a.AppointmentDate)
                .ToList();
        }

        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .Where(a => a.PatientId == patientId)
                .OrderBy(a => a.AppointmentDate)
                .ToList();
        }

        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .Where(a => a.DoctorId == doctorId)
                .OrderBy(a => a.AppointmentDate)
                .ToList();
        }

        public bool IsTimeSlotAvailable(int doctorId, DateTime appointmentDate, int? excludeAppointmentId = null)
        {
            var query = _context.Appointments
                .Where(a => a.DoctorId == doctorId && a.AppointmentDate == appointmentDate);

            if (excludeAppointmentId.HasValue)
            {
                query = query.Where(a => a.Id != excludeAppointmentId.Value);
            }

            return !query.Any();
        }

        public List<Appointment> GetTodaysAppointments()
        {
            var today = DateTime.Today;
            return GetAppointmentsByDate(today);
        }

        public List<Appointment> GetUpcomingAppointments(int days = 7)
        {
            var startDate = DateTime.Today;
            var endDate = DateTime.Today.AddDays(days);
            return GetAppointmentsByDateRange(startDate, endDate);
        }

        public int GetAppointmentCountByStatus(string status)
        {
            return _context.Appointments.Count(a => a.Status == status);
        }

        public void UpdateAppointmentStatus(int appointmentId, string newStatus)
        {
            var appointment = _context.Appointments.Find(appointmentId);
            if (appointment != null)
            {
                appointment.Status = newStatus;
                _context.SaveChanges();
            }
        }
    }
}
