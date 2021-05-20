using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Business.Abstract;
using University.Core;
using University.DataAccess.Abstract;
using University.DataAccess.Concrete;
using University.Entities.Concrete;

namespace University.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public void Add(Department entity)
        {
            if(Validation(entity))
            {
                return;
            }

            try
            {
                _departmentDal.Add(entity);
                Message.Info("Bölüm Eklendi!");
            }
            catch
            {
                Message.Error("Bölüm Eklenemedi!");
            }
        }

        public void Delete(Department entity)
        {
            var result = Message.Warning("Bölüm silinecektir. Onaylıyor musun?");
            if(result == System.Windows.Forms.DialogResult.Yes)
            {                
                try
                {
                    _departmentDal.DeleteBySql(entity.DepartmentCode);
                    Message.Info("Bölüm silindi!");
                }
                catch
                {
                    Message.Error("Bölüm silinemedi!");
                }
                
            }

        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public void Update(Department entity)
        {
            if (Validation(entity))
            {
                return;
            }
            try
            {
                _departmentDal.Update(entity);
                Message.Info("Bölüm Güncellendi");
            }
            catch
            {
                Message.Error("Bölüm Güncellenemedi!");
            }
            
        }

        
        /////////////////
        
        public bool Validation(Department entity)
        {
            if(string.IsNullOrEmpty(entity.DepartmentCode) || string.IsNullOrEmpty(entity.DepartmentName))
            {
                Message.Error("Bölüm adı boş olamaz!");
                return true;
            }

            if (entity.DepartmentCode.Substring(0, 1) != "B")
            {
                Message.Error("Bölüm kodu B ile başlamalıdır!");
                return true;
            }
            if (entity.DepartmentCode.Length < 2)
            {
                Message.Error("Bölüm Kodu en az 2 karakterden oluşmalıdır!");
                return true;
            }
            if (GetAll().Any(p => p.DepartmentCode == entity.DepartmentCode && p.Id != entity.Id))
            {
                Message.Error("Bölüm Kodu Mevcut!");
                return true;
            }

            return false;
        }


        public List<string> GetDepartmentNames()
        {
            return _departmentDal.GetAll().Select(p => p.DepartmentCode + " " + p.DepartmentName).ToList();
        }
    }
}
