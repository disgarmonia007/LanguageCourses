using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using LanguageCourses.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Repository
{
    public class AdminRepository : IRepository<Admin>
    {
        private LanguagesContext db;

        public AdminRepository(LanguagesContext context)
        {
            this.db = context;
        }
        public void Create(Admin admin)
        {
            db.Admins.Add(admin);
        }

        public void Delete(int id)
        {
            Admin admin = db.Admins.Find(id);
            if (admin != null)
                db.Admins.Remove(admin);
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
        public Admin Get(int id)
        {
            return db.Admins.Find(id);
        }

        public IEnumerable<Admin> GetList()
        {
            return db.Admins;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Admin admin)
        {
            db.Entry(admin).State = EntityState.Modified;
        }
    }
}