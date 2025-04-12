using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.DAL.Models;

namespace Company.GO2.BLL.Interfaces
{
    public interface IGenericRepositoryc<T> where T : BaseEntity
    {

        IEnumerable<T> GetALL();

        T? Get(int id);

        int Add(T model);

        int Update(T model);

        int Delete(T model);
    }
}
