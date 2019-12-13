using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;

namespace OnionApp.Domain.Interfaces
{
    public interface ILanguageRepository : IDisposable
    {
        IEnumerable<Languages> GetLanguages();
        Languages GetLanguage(int id);
        void Create(Languages item);
        void Update(Languages item);
        void Delete(int id);
        void Save();
    }
}