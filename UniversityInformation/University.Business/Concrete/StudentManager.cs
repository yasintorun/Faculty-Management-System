using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using University.Business.Abstract;
using University.Business.DependencyResolvers.Ninject;
using University.Core;
using University.DataAccess.Abstract;
using University.Entities.Concrete;

namespace University.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;
        private IDepartmentRecordService _departmentRecordService;
        private ILessonRecordService _lessonRecordService;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
            _departmentRecordService = InstanceFactory.GetInstance<IDepartmentRecordService>();
            _lessonRecordService = InstanceFactory.GetInstance<ILessonRecordService>();
        }

        public void Add(Student entity)
        {
            if(Validation(entity))
            {
                return;
            }

            if(_studentDal.Get(p=>p.Tc.Equals(entity.Tc)) != null)
            {
                return;
            }

            try
            {
                _studentDal.Add(entity);
                Message.Info("Öğrenci Eklendi!");
            }
            catch
            {
                Message.Error("Öğrenci Eklenemedi!");
            }

        }
        public void Update(Student entity)
        {
            if (Validation(entity))
            {
                return;
            }

            if(_studentDal.Get(p=>p.Id != entity.Id && p.Tc.Equals(entity.Tc)) != null)
            {
                Message.Error("Tc Kimlik numarası hatalı!\nBu tc kimlik numarası ile başka bir öğrenci kayıtlı.");
                return;
            }

            try
            {
                _studentDal.Update(entity);
                Message.Info("Öğrenci Güncellendi!");
            }
            catch
            {
                Message.Error("Öğrenci Güncellenemedi!");
            }
        }
        public void Delete(Student entity)
        {
            var record = _departmentRecordService.GetAll().SingleOrDefault(p => p.StudentTc.Equals(entity.Tc) && p.Major == Major.CiftAnaDal);
            if (record != null)
            {
                var result = Message.Warning("Öğrenci hem Ana Bilim Dalı hemde Çift Anadal programına kayıtlı.\n" +
                    "Öğrenciyi sadece Çift Anadal Programından silmek ister misin?");
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    _departmentRecordService.Delete(record);
                    Message.Info("Öğrenci Çift Anadal Programından silindi!");
                    return;
                }
            }

            var studentNo = _departmentRecordService.GetAll().SingleOrDefault(p => p.StudentTc.Equals(entity.Tc)).StudentNo;

            try
            {
                _lessonRecordService.DeleteByStudentNo(studentNo);
            }
            catch (Exception)
            {
                Message.Error("Hata Oluştu!");
                return;
            }

            try
            {
                _studentDal.Delete(entity);
                Message.Info("Öğrenci Silindi!");   
            }
            catch
            {
                Message.Error("Öğrenci Silinemedi!");
            }
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }




        public bool Validation(Student entity)
        {
            ///Temel öğrenci bilgilerini kontrol ediyoruz.
            if (string.IsNullOrEmpty(entity.Tc) || string.IsNullOrEmpty(entity.Firstname)
                 || string.IsNullOrEmpty(entity.Lastname) || string.IsNullOrEmpty(entity.PhoneNumber))
            {
                Message.Error("Tüm alanları doldurunuz!");
                return true;
            }

            if (entity.Tc.Length != 11)
            {
                Message.Error("Tc kimlik numarası 11 haneli olmalı!");
                return true;
            }
            if(!Regex.IsMatch(entity.Tc, "^[0-9]*$"))
            {
                Message.Error("Tc kimlik numarası sadece rakam içerebilir!");
                return true;
            }

            if (!Regex.IsMatch(entity.PhoneNumber, "^[0-9]*$"))
            {
                Message.Error("Telefon numarası sadece rakam içerebilir!");
                return true;
            }

            if (!Regex.IsMatch(entity.Firstname + entity.Lastname, "^[a-zA-Z_ğüşıöçĞÜŞİÖÇ]*$"))
            {
                Message.Error("İsim ve Soyisim sadece harflerden oluşabilir!");
                return true;
            }
            
            return false;
        }

        public void Add(Student student, DepartmentRecord departmentRecord)
        {
            if (this.Validation(student))
            {
                return;
            }
            if (_departmentRecordService.Validation(departmentRecord))
            {
                return;
            }

            try
            {
                if (!_departmentRecordService.IsStudentRegistered(student.Tc))
                {
                    _studentDal.Add(student);
                }
                _departmentRecordService.Add(departmentRecord);
                Message.Info("Kayıt Başarılı!");
            }
            catch (Exception exp)
            {
                Message.Error("Hata oluştu\n" + exp.Message);
            }

            
        }
    }
}
