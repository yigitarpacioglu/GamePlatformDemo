using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using GamePlatformDemo.Entities.Abstract;

namespace GamePlatformDemo.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : IEntity, new()

        // Burada T'nin bir IEntity olduğunu ve yenilenebilir bir yapıda referans bir tip olduğu kısıtlamasını getiriyoruz.
        // Olası yanlış eklemelere karşı defensive programming.

    {
        T GetById(int id);
        void GetAll();
        void Add(T entity);
        void Update(int id,T entity);
        void Delete(int id);
    }
}
