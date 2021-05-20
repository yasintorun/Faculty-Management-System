using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Business.Abstract;
using University.Business.Concrete;
using University.DataAccess.Abstract;
using University.DataAccess.Concrete;

namespace University.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<DepartmentDal>().InSingletonScope();

            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<StudentDal>().InSingletonScope();

            Bind<IDepartmentRecordService>().To<DepartmentRecordManager>().InSingletonScope();
            Bind<IDepartmentRecord>().To<DepartmentRecordDal>().InSingletonScope();

            Bind<ILecturerService>().To<LecturerManager>().InSingletonScope();
            Bind<ILecturerDal>().To<LecturerDal>().InSingletonScope();

            Bind<ILessonService>().To<LessonManager>().InSingletonScope();
            Bind<ILessonDal>().To<LessonDal>().InSingletonScope();

            Bind<ILessonRecordService>().To<LessonRecordManager>().InSingletonScope();
            Bind<ILessonRecordDal>().To<LessonRecordDal>().InSingletonScope();
        }
    }
}
