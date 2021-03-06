using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Concrete;

namespace University.Business.Abstract
{
    public interface ILessonRecordService : IBaseService<LessonRecord>
    {
        void SetGrade(LessonRecord record, string midterm, string final);

        void DeleteByStudentNo(string studentNo);
    }
}
