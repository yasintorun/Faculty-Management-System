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
    public class LessonRecordDal : EntityRepositoryBase<LessonRecord, UniversityContext>, ILessonRecordDal
    {
        public void DeleteByStudentNo(string studentNo)
        {
            using (DbContext context = new UniversityContext())
            {
                context.Database.ExecuteSqlCommand($"Delete LessonRecords where StudentNo = '{studentNo}'");
            }
        }
    }
}
