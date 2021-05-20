using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Abstract;

namespace University.Entities.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Tc Kimlik numarası")]
        public string Tc { get; set; }

        [DisplayName("Ad")]
        public string Firstname { get; set; }

        [DisplayName("Soyad")]
        public string Lastname { get; set; }

        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
    }
}
