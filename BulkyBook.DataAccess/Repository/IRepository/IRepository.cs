using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category -- all the functions 

        T GetFirstOrDefault(Expression<Func<T,bool>> filter,string? includeProperties = null,bool tracked = true); 
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties = null); 
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity); 

        //No update entity is created due to Update can be for any Model which has different attributes like images which can't be kept common

    }
}
   