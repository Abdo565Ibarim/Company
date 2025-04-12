using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.BLL.Interfaces;
using Company.GO2.DAL.Data.Contexts;
using Company.GO2.DAL.Models;

namespace Company.GO2.BLL.Repositories
{
    public class GenericRepsitory<T> : IGenericRepositoryc<T> where T : BaseEntity 
    {
        private readonly CompanyDbContext _context;

        public GenericRepsitory(CompanyDbContext context )
        {
            _context = context;
        }
        public IEnumerable<T> GetALL()
        {
            return _context.Set<T>().ToList();
        }
        public T? Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public int Add(T model)
        {
            _context.Set<T>().Add(model);
            return _context.SaveChanges();
        }
        public int Update(T model)
        {
            _context.Set<T>().Update(model);
            return _context.SaveChanges();
        }
      
        public int Delete(T model)
        {
            _context.Set<T>().Remove(model);
            return _context.SaveChanges();
        }

        

       
    }
}
