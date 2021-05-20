using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Abstract;

namespace University.Entities.Concrete
{
    public class DepartmentRecord : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Tc Kimlik Numarası")]
        public string StudentTc { get; set; }

        [DisplayName("Öğrenci Numarası")]
        public string StudentNo { get; set; }

        [DisplayName("Bölüm Kodu")]
        public string DepartmentCode { get; set; }

        [DisplayName("Anadal")]
        public string Major { get; set; }
    }
}
