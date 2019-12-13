using System;
using OnionApp.Domain.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnionApp.Infrastructure.Data;

namespace LanguageCourses.Controllers
{
    public class UnitOfWork : IDisposable
    {
        private LanguagesContext db = new LanguagesContext();
        private GroupRepository groupRepository;
        private LanguageLVLRepository languageLVLRepository;
        private LanguagesRepository languagesRepository;
        private TeacherRepository teacherRepository;
        private UserRepository userRepository;
    
        public GroupRepository Groups
        {
            get
            {
                if (groupRepository == null)
                {
                    groupRepository = new GroupRepository(db);
                    return groupRepository;
                }
                else
                    return groupRepository;
            }
        }
        public LanguageLVLRepository LanguageLVLs
        {
            get
            {
                if (languageLVLRepository == null)
                {
                    languageLVLRepository = new LanguageLVLRepository(db);
                    return languageLVLRepository;
                }
                else
                    return languageLVLRepository;
            }
        }
        public LanguagesRepository Languages
        {
            get
            {
                if (languagesRepository == null)
                {
                    languagesRepository = new LanguagesRepository(db);
                    return languagesRepository;
                }
                else
                    return languagesRepository;
            }
        }
        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                    return userRepository;
                }
                else
                    return userRepository;
            }
        }
        public TeacherRepository Teacher
        {
            get
            {
                if (teacherRepository == null)
                {
                    teacherRepository = new TeacherRepository(db);
                    return teacherRepository;
                }
                else
                    return teacherRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
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
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
