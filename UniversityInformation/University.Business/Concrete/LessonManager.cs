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
    public class LessonManager : ILessonService
    {
        private ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }
        public void Add(Lesson entity)
        {
            if(Validation(entity))
            {
                return;
            }
            if(_lessonDal.GetAll().Any(p=>p.LessonCode.Equals(entity.LessonCode)))
            {
                Message.Error("Ders Kodu Mevcut!");
                return;
            }

            try
            {
                _lessonDal.Add(entity);
                Message.Info("Ders eklendi.");
            }
            catch (Exception exp)
            {
                Message.Error("Ders eklenirken hata oluştu!\n" + exp.Message);
            }

        }

        public void Delete(Lesson entity)
        {
            var result = Message.Warning("Dersi silmek istediğinden emin misin?");
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _lessonDal.Delete(entity);
                    Message.Info("Ders silindi.");
                }
                catch (Exception exp)
                {
                    Message.Error("Ders silinirken hata oluştu!\n" + exp.Message);
                }
            }
            
        }

        public List<Lesson> GetAll()
        {
            return _lessonDal.GetAll();
        }

        public void Update(Lesson entity)
        {
            if (Validation(entity))
            {
                return;
            }
            if (_lessonDal.GetAll().Any(p => p.LessonCode.Equals(entity.LessonCode) && p.Id != entity.Id))
            {
                Message.Error("Ders Kodu Mevcut!");
                return;
            }

            try
            {
                _lessonDal.Update(entity);
                Message.Info("Ders güncellendi.");
            }
            catch (Exception exp)
            {
                Message.Error("Ders güncellenirken hata oluştu!\n" + exp.Message);
            }
        }

        public bool Validation(Lesson entity)
        {
            if(string.IsNullOrEmpty(entity.LessonCode) || string.IsNullOrEmpty(entity.Classroom) || string.IsNullOrEmpty(entity.LessonCredit))
            {
                Message.Error("Tüm alanları doldurunuz!");
                return true;
            }
            if(entity.LessonCode.Length < 4)
            {
                Message.Error("Ders Kodu 4 veya 5 haneden oluşabilir!");
                return true;
            }

            if(!entity.LessonCode.StartsWith(entity.DepartmentCode))
            {
                Message.Error("Ders kodu bölüm kodu ile başlamalıdır!");
                return true;
            }
            
            if(!entity.LessonCode.StartsWith(entity.DepartmentCode.Remove(0,1)))
            {

            }

            if(!Regex.IsMatch(entity.Classroom + entity.LessonCredit, "^[0-9]*$"))
            {
                Message.Error("Derslik ve ders kredisi rakamlardan oluşabilir!");
                return true;
            }

            if(!Regex.IsMatch(entity.LessonCode.Substring(1,entity.LessonCode.Length-1), "^[0-9]*$"))
            {
                Message.Error("Ders Kodu hatalı. Ders kodu bölüm kodu + rakamlardan oluşabilir!");
                return true;
            }



            return false;
        }
    }
}
