using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();

        DbSet<T> _objects;

        public GenericRepository()
        {
            _objects = c.Set<T>();  //_objects isimli fiels ım dışarıdan gönderdiğim T değeri neyse o olacak
                
        }


        public void Delete(T p)
        {
            _objects.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _objects.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _objects.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _objects.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
