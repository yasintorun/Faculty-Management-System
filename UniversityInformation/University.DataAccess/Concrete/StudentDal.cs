using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DataAccess.Abstract;
using University.Entities.Concrete;

namespace University.DataAccess.Concrete
{
    public class StudentDal : EntityRepositoryBase<Student, UniversityContext>, IStudentDal
    {
    }
}
