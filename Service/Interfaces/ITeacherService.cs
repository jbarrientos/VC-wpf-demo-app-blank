﻿using Domain.Models.Interfaces;

namespace Service.Interfaces
{
    public interface ITeacherService
    {
        void AddTeacher(string name, string email, string rank);
        void ValidateModelDataAnnotations(ITeacher teacher);
    }
}