using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // generic constraint(gneric kısıt)
    // class : => referans tip olabilir.
    // IEntity : => IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new : => new'lenebilir olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Expression => belirleyeceğimiz filtrelere göre işlemler yapabilmezi sağlar. Ayrı ayrı metot kullanıma gerek kalmaz.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Expression yapısını kullandıktan sonra, bu bölümdeki koda ihtiyacımız kalmadı. 
        //Ürünleri kategoriye göre listele
        //List<T> GetAllByCategory(int categoryId);
    }
}
