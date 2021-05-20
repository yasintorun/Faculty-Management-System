using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Concrete;

namespace University.DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        void DeleteBySql(string departmentCode);
    }
}
