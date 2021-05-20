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
    public class DepartmentRecordManager : IDepartmentRecordService
    {
        private IDepartmentRecord _departmentRecord;

        public DepartmentRecordManager(IDepartmentRecord departmentRecord)
        {
            _departmentRecord = departmentRecord;
        }

        public void Add(DepartmentRecord entity)
        {

            _departmentRecord.Add(entity);
        }

        public void Delete(DepartmentRecord entity)
        {

            _departmentRecord.Delete(entity);
        }

        public List<DepartmentRecord> GetAll()
        {

            return _departmentRecord.GetAll();
        }

        public void Update(DepartmentRecord entity)
        {

            _departmentRecord.Update(entity);
        }

        public bool Validation(DepartmentRecord entity)
        {
            if(string.IsNullOrEmpty(entity.StudentNo))
            {
                Message.Error("Öğrenci Numarası Boş olamaz!");
                return true;
            }
            if(entity.StudentNo.Length != 9)
            {
                Message.Error("Öğrenci Numarası 9 karakterden oluşabilir!");
                return true;
            }

            if(!Regex.IsMatch(entity.StudentNo, "^[0-9]*$"))
            {
                Message.Error("Öğrenci Numarası sadece Rakamlardan oluşabilir.");
                return true;
            }
            var str = entity.DepartmentCode.Substring(1, entity.DepartmentCode.Length - 1);

            if(!entity.StudentNo.StartsWith(str))
            {
                Message.Error("Öğrenci numarası bölüm kodu ile başlamalıdır.");
                return true;
            }
            
            if(_departmentRecord.Get(p=>p.StudentNo.Equals(entity.StudentTc)) != null)
            {
                Message.Error("Öğrenci Numarası Mevcut!");
                return true;
            }
 
            if(_departmentRecord.Get(p=>p.StudentTc.Equals(entity.StudentTc) && p.Major.Equals(Major.CiftAnaDal)) != null)
            {
                Message.Error("Öğrenci Her iki bölümede kayıtlı!");
                return true;
            }

            if(IsStudentRegistered(entity.StudentTc))
            {
                if(_departmentRecord.Get(p=>p.StudentTc.Equals(entity.StudentTc) && p.DepartmentCode.Equals(entity.DepartmentCode)) != null)
                {
                    Message.Error($"Zaten öğrenci {entity.DepartmentCode} bölümüne kayıtlı!");
                    return true;
                }

                entity.Major = Major.CiftAnaDal;
            }


            return false;
        }

        public bool IsStudentRegistered(string tc)
        {
            return _departmentRecord.Get(p => p.StudentTc.Equals(tc)) != null;
        }
    }
}
