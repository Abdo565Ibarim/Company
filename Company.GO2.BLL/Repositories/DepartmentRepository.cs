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
    public class DepartmentRepository : GenericRepsitory<Depratment> , IDepartmentRepository
    {
        public DepartmentRepository(CompanyDbContext context) : base(context)
        {

        }






    }
}
