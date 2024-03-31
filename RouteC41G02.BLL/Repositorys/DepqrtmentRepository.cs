using Microsoft.EntityFrameworkCore;
using RouteC41G02.BLL.interfaces;
using RouteC41G02.DAL.Data;
using RouteC41G02.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC41G02.BLL.Repositorys
{
    internal class DeprtmentRepository /*: IDepartmentRepository*/
    {
        private readonly ApplictionDbContext _dbContext;

        public DeprtmentRepository(ApplictionDbContext dbContext)//ask clr for create object
                                                                  //
        {
            _dbContext = dbContext;
        }

        public int Add(Department entity)
        {

            _dbContext.Departments.Add(entity);

            return _dbContext.SaveChanges();
        }

        public int Delete(Department entity)

        {
            _dbContext.Departments.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        
          => _dbContext.Departments.AsNoTracking().ToList();




        public Department GetById(int id)
        {
            // return _dbContext.Departments.Find(id);
            return _dbContext.Find<Department>(id); //EF core 3.1 new fature
                
            //var department =_dbContext.Departments.Where(D=>D.Id == id).FirstOrDefault();
            //return department;
        }


        public int Update(Department entity)
        {
           _dbContext.Departments.Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
