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
    public class EmployeeRepository : GenericRepsitory<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CompanyDbContext context) : base(context) //Ask CLR Create Odject From CompanyDbContext
        {
            
        }

    }
}
