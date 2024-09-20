using LinkDev.IKEA.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.BLL.Services
{
    public interface IDepartmentService
    {



        IEnumerable<Department> GetAllDepartments();
        DepartmentDtoReturnDto? GetDepartmentById(int id);




        int CreateDepartment(CreateDepartment department);
        int UpdateDepartment(UpdateDepartment department);

        bool DeleteDepartment(int id );
    }
}
