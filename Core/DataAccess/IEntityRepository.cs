using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanı diğer katmanları referans almaz

namespace Core.DataAccess
{
    //generic constraint
    //classs : referans tip 
    //IEntity : IEntity olabilir veya IEntitiy implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); Expression kullandığımız için buna ihtiyaç kalmıyor
    }
}
