using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Abstract;

namespace University.Entities.Concrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }

        [DisplayName("Bölüm Kodu")]
        public string DepartmentCode { get; set; }
        
        [DisplayName("Bölüm Adı")]
        public string DepartmentName { get; set; }
    }
}
