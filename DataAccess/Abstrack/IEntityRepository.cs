using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstrack;

namespace DataAccess.Abstrack
{
    // generic constraint
    // class = referans tip olabilir
    // IEntity: IEntity olabilir veya ientity iplemente eden bir entity olabilir
    // new() : newlene bilir olmali

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
