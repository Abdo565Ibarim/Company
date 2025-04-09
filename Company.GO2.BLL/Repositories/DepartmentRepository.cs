using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.BLL.Interfaces;
using Company.GO2.DAL.Data.Contexts;
using Company.GO2.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Company.GO2.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly  CompanyDbContext _context;

        public DepartmentRepository(CompanyDbContext context)
        {
            _context = context;     
        }

        public IEnumerable<Depratment> GetALL()
        {

            return _context.Depratments.ToList();
        }

        public Depratment? Get(int id)
        {

            return _context.Depratments.Find(id);
        }
        public int Add(Depratment model)
        {

            _context.Depratments.Add(model);
            return _context.SaveChanges();
        }

        public int Update(Depratment model)
        {

            _context.Depratments.Update(model);
            return _context.SaveChanges();
        }

        public int Delete(Depratment model)
        {

            _context.Depratments.Remove(model);
            return _context.SaveChanges();
        }

       

        

        
    }
}
