using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.DAL.Models;

namespace Company.GO2.BLL.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetALL();

        Employee? Get(int id);

        int Add(Employee model);

        int Update(Employee model);

        int Delete(Employee model);

    }
}
