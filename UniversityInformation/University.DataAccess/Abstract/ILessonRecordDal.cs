﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Concrete;

namespace University.DataAccess.Abstract
{
    public interface ILessonRecordDal : IEntityRepository<LessonRecord>
    {
        void DeleteByStudentNo(string studentNo);
    }
}
