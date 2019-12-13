using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Data
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private LanguagesContext db;

        public TeacherRepository(LanguagesContext context)
        {
            this.db = context;
        }
        public void Create(Teacher teacher)
        {
            db.Teachers.Add(teacher);
        }

        public void Delete(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            if (teacher != null)
                db.Teachers.Remove(teacher);
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public IEnumerable<Teacher> GetList()
        {
            return db.Teachers;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Teacher teacher)
        {
            db.Entry(teacher).State = EntityState.Modified;
        }
    }
}