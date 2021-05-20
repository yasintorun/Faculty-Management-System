using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Abstract;

namespace University.Entities.Concrete
{
    public class LessonRecord : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Ders Kodu")]
        public string LessonCode { get; set; }

        [DisplayName("Öğrenci numarası")]
        public string StudentNo { get; set; }

        [DisplayName("Ortalama Notu")]
        public double Grade { get; set; }
    }
}
