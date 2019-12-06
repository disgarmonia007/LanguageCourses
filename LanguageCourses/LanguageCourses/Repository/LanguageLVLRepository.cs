using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using LanguageCourses.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Repository
{
    public class LanguageLVLRepository : IRepository<LanguageLVL>
    {
        private LanguagesContext db;

        public LanguageLVLRepository(LanguagesContext context)
        {
            this.db = context;
        }
        public void Create(LanguageLVL lvl)
        {
            db.LanguageLVLs.Add(lvl);
        }

        public void Delete(int id)
        {
            LanguageLVL lvl = db.LanguageLVLs.Find(id);
            if (lvl != null)
                db.LanguageLVLs.Remove(lvl);
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
        public LanguageLVL Get(int id)
        {
            return db.LanguageLVLs.Find(id);
        }

        public IEnumerable<LanguageLVL> GetList()
        {
            return db.LanguageLVLs;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(LanguageLVL lvl)
        {
            db.Entry(lvl).State = EntityState.Modified;
        }
    }
}