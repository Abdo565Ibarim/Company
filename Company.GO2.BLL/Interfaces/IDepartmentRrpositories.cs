using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.DAL.Models;

namespace Company.GO2.BLL.Interfaces
{
    public interface IDepartmentRepository


    {
        IEnumerable<Depratment> GetALL();

        Depratment? Get(int id);    

        int Add(Depratment model);

        int Update(Depratment model);

        int Delete(Depratment model);
    }
}
