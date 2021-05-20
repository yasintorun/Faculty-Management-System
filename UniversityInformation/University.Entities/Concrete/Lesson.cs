using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Abstract;

namespace University.Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Ders Kodu")]
        public string LessonCode { get; set; }

        [DisplayName("Ders Kredisi")]
        public string LessonCredit { get; set; }

        [DisplayName("Derslik")]
        public string Classroom { get; set; }

        [DisplayName("Öğretim Üyesi Sicil No")]
        public string LecturerNo { get; set; }

        [DisplayName("Bölüm Kodu")]
        public string DepartmentCode { get; set; }
    }
}
