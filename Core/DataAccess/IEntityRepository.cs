using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace DataAccess.Abstract
{
    //generic constraint-kısıtlama
    //class: referans tip
    //IEntity: IEntity olabilir ya da onu implemente eden olabilir.
    //new: new'lenebilir olmalı



    //Tekrarlayan metotlar oldukları için genel bir yapı oluşturduk
    //Generic Repository Design Pattern


    public interface IEntityRepository<T> where T:class, IEntity,new()
    {  

        List<T> GetAll(Expression<Func<T,bool>>filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        
    }
}
