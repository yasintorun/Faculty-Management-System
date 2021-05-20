using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using University.Entities.Concrete;

namespace University.DataAccess.Concrete
{
    public class UniversityContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DepartmentRecord> DepartmentRecords { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonRecord> LessonRecords { get; set; }
    }
}
