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
    public partial class Grades : Form
    {
        private ILessonRecordService _lessonRecordService;
        private IDepartmentRecordService _departmentRecordService;
        private IStudentService _studentService;
        private IDepartmentService _departmentService;
        public Grades()
        {
            InitializeComponent();

            _lessonRecordService = InstanceFactory.GetInstance<ILessonRecordService>();
            _departmentRecordService = InstanceFactory.GetInstance<IDepartmentRecordService>();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }

        private void btnEnterGrade_Click(object sender, EventArgs e)
        {
            var record = _lessonRecordService.GetAll().SingleOrDefault(p=>p.StudentNo.Equals(cbxEnterStudentNo.Text) && p.LessonCode.Equals(cbxSelectLesson.Text));
            if(record != null)
            {
                _lessonRecordService.SetGrade(record, tbxEnterMidterm.Text, tbxEnterFinal.Text);
            }
        }

        private void cbxEnterStudentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSelectLesson.DataSource = _lessonRecordService.GetAll().Where(p => p.StudentNo.Equals(cbxEnterStudentNo.Text)).Select(p => p.LessonCode).ToList();
            var departmentRecord = _departmentRecordService.GetAll().SingleOrDefault(p => p.StudentNo.Equals(cbxEnterStudentNo.Text));
            Student student = _studentService.GetAll().SingleOrDefault(p=>p.Tc.Equals(departmentRecord.StudentTc));

            tbxStudentName.Text = student.Firstname + "  " + student.Lastname;
            tbxStudentTc.Text = student.Tc;
            tbxStudentPhone.Text = student.PhoneNumber;
            tbxDepartmentName.Text = _departmentService.GetAll().SingleOrDefault(p => p.DepartmentCode.Equals(departmentRecord.DepartmentCode)).DepartmentName;
        }

        private void Grades_VisibleChanged(object sender, EventArgs e)
        {
            cbxEnterStudentNo.DataSource = _departmentRecordService.GetAll().Select(p => p.StudentNo).Distinct().ToList();
        }

    }
}
