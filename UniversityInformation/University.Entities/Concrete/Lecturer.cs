using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Abstract;

namespace University.Entities.Concrete
{
    public class Lecturer : IEntity
    {
        public int Id { get; set; }
        
        [DisplayName("Sicil Numarası")]
        public string IdentityNumber { get; set; }
        
        [DisplayName("Ad")]
        public string Firstname { get; set; }
        
        [DisplayName("Soyad")]
        public string Lastname { get; set; }
        
        [DisplayName("Bölüm Kodu")]
        public string DepartmentCode { get; set; }
    }
}
