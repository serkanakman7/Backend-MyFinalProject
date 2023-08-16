using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // class : referans tip olduğunu belirtir
    // Entity : IEntity yada ondan implement alan bir yapı olduğunu belirtir
    // new : newlenebilir bir yapı olduğunu belirtir ve abstract ve interface yapıları new lenemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
