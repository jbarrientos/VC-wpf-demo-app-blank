using Domain.Models;
using System;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IAppointmentService
    {
        void AddAppointment(string description, DateTime examTimeStart, DateTime examTimeEnd, string location);
        void RemoveAppointment(string summary);
        void ChangeAppointment(string description,
                              DateTime examTimeStart,
                              DateTime examTimeEnd,
                              string location,
                              string changedPropertry);
        ICollection<Exam> GetAppointments();
    }
}