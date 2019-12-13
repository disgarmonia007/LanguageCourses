using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface IGroupRepository : IDisposable
    {
        IEnumerable<Group> GetGroups();
        Group GetGroup(int id);
        void Create(Group item);
        void Update(Group item);
        void Delete(int id);
        void Save();
    }
}