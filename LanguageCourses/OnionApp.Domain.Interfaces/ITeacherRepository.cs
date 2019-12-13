using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface ITeacherRepository : IDisposable
    {
        IEnumerable<Teacher> GetTeachers();
        Teacher GetTeacher(int id);
        void Create(Teacher item);
        void Update(Teacher item);
        void Delete(int id);
        void Save();
    }
}