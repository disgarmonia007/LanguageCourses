using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using LanguageCourses.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Repository
{
    public class GroupRepository : IRepository<Group>
    {
        private LanguagesContext db;

        public GroupRepository(LanguagesContext context)
        {
            this.db = context;
        }
        public void Create(Group group)
        {
            db.Groups.Add(group);
        }

        public void Delete(int id)
        {
            Group group = db.Groups.Find(id);
            if (group != null)
                db.Groups.Remove(group);
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
        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public IEnumerable<Group> GetList()
        {
            return db.Groups;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Group group)
        {
            db.Entry(group).State = EntityState.Modified;
        }
    }
}