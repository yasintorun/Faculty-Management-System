using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using University.Business.Abstract;
using University.Core;
using University.DataAccess.Abstract;
using University.Entities.Concrete;

namespace University.Business.Concrete
{
    class LecturerManager : ILecturerService
    {
        private ILecturerDal _lecturerDal;
        public LecturerManager(ILecturerDal lecturerDal)
        {
            _lecturerDal = lecturerDal;
        }
        public void Add(Lecturer entity)
        {
            if(Validation(entity))
            {
                return;
            }

            if(_lecturerDal.GetAll().Any(p=>p.IdentityNumber.Equals(entity.IdentityNumber)))
            {
                Message.Error("Sicil numarası mevcut!");
                return;
            }

            try
            {
                _lecturerDal.Add(entity);
                Message.Info("Öğretim görevlisi eklendi!");
            }
            catch (Exception exp)
            {

                Message.Error("Öğretim Görevlisi Eklenirken bir hata oluştu.\n" + exp.Message);
            }
        }

        public void Delete(Lecturer entity)
        {
            var result = Message.Warning($"{entity.IdentityNumber} sicil numaralı öğretim görevlisini silmek istediğinden emin misin?");
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _lecturerDal.Delete(entity);
                    Message.Info("Öğretim görevlisi silindi!");
                }
                catch (Exception exp)
                {
                    Message.Error("Öğretim görevlisi silinirken hata oluştu\n" + exp.Message);
                }
            }
        }

        public List<Lecturer> GetAll()
        {
            return _lecturerDal.GetAll();
        }

        public List<string> GetLecturerNames()
        {
            return _lecturerDal.GetAll().Select(p => p.IdentityNumber + " " + p.Firstname + " " + p.Lastname).ToList();
        }




        public void Update(Lecturer entity)
        {
            if (Validation(entity))
            {
                return;
            }

            if (_lecturerDal.GetAll().Any(p => p.IdentityNumber.Equals(entity.IdentityNumber) && p.Id != entity.Id))
            {
                Message.Error("Sicil numarası mevcut!");
                return;
            }

            try
            {
                _lecturerDal.Update(entity);
                Message.Info("Öğretim görevlisi güncellendi!");
            }
            catch (Exception exp)
            {

                Message.Error("Öğretim Görevlisi güncellenirken bir hata oluştu.\n" + exp.Message);
            }
        }

        public bool Validation(Lecturer entity)
        {
            if(string.IsNullOrEmpty(entity.IdentityNumber) || string.IsNullOrEmpty(entity.Firstname) || string.IsNullOrEmpty(entity.Lastname))
            {
                Message.Error("Tüm alanları doldurunuz!");
                return true;
            }
            if(entity.IdentityNumber.Length != 4)
            {
                Message.Error("Sicil Numarası 4 rakamdan oluşmalıdır");
                return true;
            }
            if(!entity.IdentityNumber.StartsWith(entity.DepartmentCode.Remove(0,1)))
            {
                Message.Error("Sicil numarasının ilk rakamı bölüm kodu ile başlamalıdır!");
                return true;
            }

            if(!Regex.IsMatch(entity.Firstname + entity.Lastname, "^[a-zA-Z_ğüşıöçĞÜŞİÖÇ]*$"))
            {
                Message.Error("İsim ve soyisim sadece harflerden oluşabilir.");
                return true;
            }
            if(!Regex.IsMatch(entity.IdentityNumber, "^[0-9]*$"))
            {
                Message.Error("Sicil numarası sadece rakamlardan oluşabilir!");
                return true;
            }

            return false;
        }
    }
}
