using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new() 
    {
        List<T> GetList(Expression<Func<T, bool>> filter=null);
        T Get(T Entity);
        T Update(T Entity);
        void Delete(T Entity);
    }
}
