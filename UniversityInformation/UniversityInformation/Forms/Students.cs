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
using University.Core;
using University.Entities.Concrete;

namespace UniversityInformation.Forms
{
    public partial class Students : Form
    {
        private IStudentService _studentService;
        private IDepartmentService _departmentService;
        public Students()
        {
            InitializeComponent();
            
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            LoadStudents();
            cbxAddStudentDepartment.DataSource = _departmentService.GetDepartmentNames();
            cbxAddStudentMajor.DataSource = Major.GetMajor();
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentService.GetAll();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            _studentService.Add(
                //yeni öğrenci oluştur.
                new Student
                {
                    Tc = tbxAddStudentTc.Text,
                    Firstname = tbxAddStudentFirstname.Text,
                    Lastname = tbxAddStudentLastname.Text,
                    PhoneNumber = tbxAddStudentPhone.Text
                }, 
                //Yeni bölüm kaydı oluştur
                new DepartmentRecord
                {
                    DepartmentCode = cbxAddStudentDepartment.Text.Split(' ')[0],
                    Major = cbxAddStudentMajor.Text,
                    StudentNo = tbxAddStudentNo.Text,
                    StudentTc = tbxAddStudentTc.Text
                });

            LoadStudents();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            _studentService.Update(new Student
            {
                Id = (int)dgwStudents.CurrentRow.Cells[0].Value,
                Tc = tbxUpdateStudentTc.Text,
                Firstname = tbxUpdateStudentFirstname.Text,
                Lastname = tbxUpdateStudentLastname.Text,
                PhoneNumber = tbxUpdateStudentPhone.Text
            });
            LoadStudents();
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwStudents.CurrentRow.Cells;
            int studentId = (int)(cells[0].Value);
            Student currentStudent = _studentService.GetAll().SingleOrDefault(prop => prop.Id == studentId);
            if(currentStudent != null)
            {
                tbxUpdateStudentTc.Text = currentStudent.Tc;
                tbxUpdateStudentFirstname.Text = currentStudent.Firstname;
                tbxUpdateStudentLastname.Text = currentStudent.Lastname;
                tbxUpdateStudentPhone.Text = currentStudent.PhoneNumber;
            }
            
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int studentId = (int)dgwStudents.CurrentRow.Cells[0].Value;
            Student currentStudent = _studentService.GetAll().SingleOrDefault(prop => prop.Id == studentId);
            if(currentStudent != null)
            {
                _studentService.Delete(currentStudent);
                LoadStudents();
            }
        }

        private void Students_VisibleChanged(object sender, EventArgs e)
        {
            LoadStudents();
            cbxAddStudentDepartment.DataSource = _departmentService.GetDepartmentNames();
        }
    }
}
