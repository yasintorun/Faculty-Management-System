using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Business.Abstract;
using University.Business.DependencyResolvers.Ninject;
using University.Entities.Concrete;

namespace UniversityInformation.Forms
{
    public partial class LessonRecords : Form
    {
        private IDepartmentRecordService _departmentRecordService;
        private ILessonRecordService _lessonRecordService;
        private string _lessonCode;
        private string _departmentCode;
        private List<string> _studentNoList = new List<string>();

        public LessonRecords(string departmentCode, string lessonCode)
        {
            InitializeComponent();

            _departmentRecordService = InstanceFactory.GetInstance<IDepartmentRecordService>();
            _lessonRecordService = InstanceFactory.GetInstance<ILessonRecordService>();

            _lessonCode = lessonCode;
            _departmentCode = departmentCode;


            _studentNoList = _departmentRecordService.GetAll().Where(p => p.DepartmentCode.Equals(departmentCode)).Select(p => p.StudentNo).ToList();

            ((ListBox)(checkStudentNoList)).DataSource = _studentNoList;


            for (int i = 0; i < checkStudentNoList.Items.Count; i++)
            {
                bool isThere = _lessonRecordService.GetAll().Any(p => p.StudentNo.Equals(checkStudentNoList.Items[i].ToString()) && p.LessonCode.Equals(lessonCode));
                checkStudentNoList.SetItemChecked(i, isThere);
            }


        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll(true);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            SelectAll(false);
        }

        private void SelectAll(bool isChecked)
        {
            for (int i = 0; i < checkStudentNoList.Items.Count; i++)
            {
                checkStudentNoList.SetItemChecked(i, isChecked);
            }
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            for (int i = 0;  i < checkStudentNoList.Items.Count; i++)
            {
                var record = new LessonRecord
                {
                    StudentNo = checkStudentNoList.Items[i].ToString(),
                    LessonCode = _lessonCode,
                    Grade = 0
                };
                //Eğer index seçili ise bunu kayda ekle.
                if (checkStudentNoList.GetItemChecked(i))
                {
                    _lessonRecordService.Add(record);
                }
                //Eğer kutucuk seçili degilse öğrencileri dersten çıkar.
                else
                {
                    var control = _lessonRecordService.GetAll().SingleOrDefault(p => p.StudentNo.Equals(record.StudentNo) && p.LessonCode.Equals(record.LessonCode));
                    if(control != null)
                    {
                        record.Id = control.Id;
                        _lessonRecordService.Delete(record);
                    }
                }
                
            }
            MessageBox.Show("Öğrenciler Derse Eklendi!");

        }








        /*
         public LessonRecords(string departmentCode, string lessonCode)
         {
             InitializeComponent();
             _departmentRecordService = InstanceFactory.GetInstance<IDepartmentRecordService>();
             _lessonRecordService = InstanceFactory.GetInstance<ILessonRecordService>();

             _lessonCode = lessonCode;
             _departmentCode = departmentCode;

             var studentList = _departmentRecordService.GetAll().Where(p => p.DepartmentCode.Equals(departmentCode)).Select(p => p.StudentNo).ToList();

             foreach (var studentNo in studentList)
             {
                 if(!_lessonRecordService.GetAll().Any(p=>p.StudentNo.Equals(studentNo) && p.LessonCode.Equals(lessonCode)))
                 {
                     _studentNoList.Add(studentNo);
                 }
             }
             if(_studentNoList.Count == 0)
             {
                 lblAddStudent.Text = "Tüm Öğrenciler Derse Ekli";
             }

             lbxSelectStudent.DataSource = _studentNoList;

         }

         private void btnAddStudents_Click(object sender, EventArgs e)
         {

             var result = MessageBox.Show("Öğrenciler Derse Eklenecektir.\nOnaylıyor musun?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (result == DialogResult.Yes)
             {
                 foreach (int i in lbxSelectStudent.SelectedIndices)
                 {
                     _lessonRecordService.Add(new LessonRecord
                     {
                         StudentNo = lbxSelectStudent.Items[i].ToString(),
                         LessonCode = _lessonCode,
                         Grade = 0
                     });
                 }
                 MessageBox.Show("Öğrenciler Derse Eklendi!");
             }
         }

         private void btnAddAllStudents_Click(object sender, EventArgs e)
         {
             var result = MessageBox.Show($"{_departmentCode} bölümündeki tüm öğrenciler {_lessonCode} Derse Eklenecektir.\nOnaylıyor musun?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (result == DialogResult.Yes)
             {
                 foreach (var item in lbxSelectStudent.Items)
                 {
                     _lessonRecordService.Add(new LessonRecord
                     {
                         StudentNo = item.ToString(),
                         LessonCode = _lessonCode,
                         Grade = 0
                     });
                 }
                 MessageBox.Show("Tüm Öğrenciler Derse Eklendi!");
             }
         }
        */

    }
}
