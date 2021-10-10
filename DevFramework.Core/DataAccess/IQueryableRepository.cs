using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.DataAccess
{
    interface IQueryableRepository<T> where T: class, IEntity, new()
    {
        IQueryableRepository<T> Table { get; }
    }
}
