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
    public class LessonRecordManager : ILessonRecordService
    {
        private ILessonRecordDal _lessonRecordDal;

        public LessonRecordManager(ILessonRecordDal lessonRecordDal)
        {
            _lessonRecordDal = lessonRecordDal;
        }

        public List<LessonRecord> GetAll()
        {
            return _lessonRecordDal.GetAll();
        }


        public void Add(LessonRecord entity)
        {
            if(Validation(entity))
            {
                return;
            }

            if (_lessonRecordDal.GetAll().Any(p => p.LessonCode.Equals(entity.LessonCode) && p.StudentNo.Equals(entity.StudentNo)))
            {
                //Message.Error("Zaten öğrenci derse kayıtlı!");
                return;
            }

            try
            {
                _lessonRecordDal.Add(entity);
                //Message.Info("Ders kaydı eklendi!");
            }
            catch (Exception exp)
            {
                //Message.Error("Ders kaydı eklenirken hata oluştu!\n" + exp.Message + "\n" );
            }

        }

        public void Update(LessonRecord entity)
        {
            if (Validation(entity))
            {
                return;
            }

            try
            {
                _lessonRecordDal.Add(entity);
                Message.Info("Ders Kaydı Güncellendi!");
            }
            catch (Exception exp)
            {
                Message.Error("Ders kaydı güncellenirken hata oluştu!\n" + exp.Message);
            }
        }

        public void Delete(LessonRecord entity)
        {
            try
            {
                _lessonRecordDal.Delete(entity);
                //Message.Info("Ders kaydı silindi!");
            }
            catch (Exception exp)
            {
                //Message.Error("Ders kaydı silinirken hata oluştu!\n" + exp.Message);
            }
        }

        public bool Validation(LessonRecord entity)
        {
            //Todo: Kayıt verilerini kontrol et

            

            return false;
        }

        public void SetGrade(LessonRecord record, string midterm, string final)
        {
            if(string.IsNullOrEmpty(midterm) || string.IsNullOrEmpty(final))
            {
                Message.Error("Vize ve Final notunu giriniz!");
                return;
            }
            if(!Regex.IsMatch(midterm + final, "^[0-9]*$"))
            {
                Message.Error("Vize ve final notu sadece rakamdan oluşabilir!");
                return;
            }
            int _midterm = Convert.ToInt32(midterm);
            int _final = Convert.ToInt32(final);
            if(_midterm > 100 || _midterm < 0 || _final > 100 || _final < 0)
            {
                Message.Error("Not 0-100 arasında olmalıdır!");
                return;
            }
            double averageGrade = _midterm * 0.4 + _final * 0.6;
            var result = Message.Warning($"{record.StudentNo} numaralı öğrencinin eski not ortalaması: {record.Grade}\n" +
                $"Yeni Not ortalaması: {averageGrade}\n" +
                $"Notu değiştirmek istiyor musun?");
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                record.Grade = averageGrade;
                try
                {
                    _lessonRecordDal.Update(record);
                    Message.Info("Not girildi!");
                } catch (Exception exp)
                {
                    Message.Error("Not girişi başarısız!\n" + exp.Message);
                }
            }
        }

        public void DeleteByStudentNo(string studentNo)
        {
            try
            {
                _lessonRecordDal.DeleteByStudentNo(studentNo);
            }

            catch
            {
                throw;
            }
        }
    }
}
