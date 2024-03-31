using RouteC41G02.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC41G02.BLL.interfaces
{
   public interface IDepartmentRepository
    {
       IEnumerable <Department> GetAll();

        Department GetById (int id);
        
       int Add(Department entity);

        int Update(Department entity);

        int Delete(Department entity);


    }
}
