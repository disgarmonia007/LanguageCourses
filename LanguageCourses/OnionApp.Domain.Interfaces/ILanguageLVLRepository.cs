using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface ILanguageLVLRepository : IDisposable
    {
        IEnumerable<LanguageLVL> GetLanguageLVLs();
        LanguageLVL GetLanguageLVL(int id);
        void Create(LanguageLVL item);
        void Update(LanguageLVL item);
        void Delete(int id);
        void Save();
    }
}