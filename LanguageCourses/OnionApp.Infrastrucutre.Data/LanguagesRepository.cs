using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Data
{
    public class LanguagesRepository : IRepository<Languages>
    {
        private LanguagesContext db;

        public LanguagesRepository(LanguagesContext context)
        {
            this.db = context;
        }
        public void Create(Languages languages)
        {
            db.Languages.Add(languages);
        }

        public void Delete(int id)
        {
            Languages languages = db.Languages.Find(id);
            if (languages != null)
                db.Languages.Remove(languages);
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
        public Languages Get(int id)
        {
            return db.Languages.Find(id);
        }

        public IEnumerable<Languages> GetList()
        {
            return db.Languages;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Languages languages)
        {
            db.Entry(languages).State = EntityState.Modified;
        }
    }
}