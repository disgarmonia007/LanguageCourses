﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using LanguageCourses.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Repository
{
    public class UserRepository : IRepository<User>
    {
        private LanguagesContext db;

        public UserRepository(LanguagesContext context)
        {
            this.db = context;
        }
        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
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
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetList()
        {
            return db.Users;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }
    }
}