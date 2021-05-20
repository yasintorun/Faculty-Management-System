using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DataAccess.Abstract;
using University.Entities.Concrete;

namespace University.DataAccess.Concrete
{
    public class DepartmentDal : EntityRepositoryBase<Department, UniversityContext>, IDepartmentDal
    {
        public void DeleteBySql(string departmentCode)
        {
            using (DbContext context = new UniversityContext())
            {
                context.Database.ExecuteSqlCommand($"Delete Departments where DepartmentCode = '{departmentCode}'");
            }
        }
    }
}
