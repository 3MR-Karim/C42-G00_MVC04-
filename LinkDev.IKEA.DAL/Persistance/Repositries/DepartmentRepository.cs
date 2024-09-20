using LinkDev.IKEA.DAL.Models.Department;
using LinkDev.IKEA.DAL.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Persistance.Repositries
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;    


        public DepartmentRepository(ApplicationDbContext dbContext) // Ask Clr for object from applicationDbContext implicitly
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Department> GetAll(bool withAsNoTracking = true)
        {
           if (!withAsNoTracking) {
                return _dbContext.Department.AsNoTracking.ToList();
                

        }
        public Department? GetById(int id)
        {

                return _dbContext.Departments.Find(id);
            //var department = _dbContext.Department.FirstOrDefault(D => D.Id == id);
            //    if (department is null) { 
                
            //    department= _dbContext.Department.FirstOrDefault(D=>D.Id== id); 
            //    }
                //return department;
            }
        public int Add(Department entity)
        {
                return _dbContext.SaveChanges();
        }

        public int Update(Department entity)
        {
                _dbContext.Departments.Update(entity);  
            return _dbContext.SaveChanges()
        }

        public int Delete(int id)
        {
                _dbContext.Departments.Remove(entity);
                return _dbContext.SaveChanges()
           
        }

     

       

    
    }
}
