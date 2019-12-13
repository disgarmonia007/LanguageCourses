﻿using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Data
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetList();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
