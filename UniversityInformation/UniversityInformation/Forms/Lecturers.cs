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
    public partial class Lecturers : Form
    {
        private ILecturerService _lecturerService;
        private IDepartmentService _departmentService;
        public Lecturers()
        {
            InitializeComponent();
            _lecturerService = InstanceFactory.GetInstance<ILecturerService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            cbxAddLecturerDepartment.DataSource = _departmentService.GetDepartmentNames();
            cbxUpdateLecturerDepartment.DataSource = _departmentService.GetDepartmentNames();
            LoadLecturers();
        }
        
        private void LoadLecturers()
        {
            dgwLecturers.DataSource = _lecturerService.GetAll();

        }

        private void Reset()
        {

            tbxAddLecturerFirstname.Text = "";
            tbxAddLecturerIdentityNo.Text = "";
            tbxAddLecturerLastname.Text = "";
            cbxAddLecturerDepartment.SelectedIndex = 0;

            tbxUpdateLecturerIdentityNo.Text = "";
            tbxUpdateLecturerFirstname.Text = "";
            tbxUpdateLecturerLastname.Text = "";
            cbxUpdateLecturerDepartment.SelectedIndex = 0;
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            _lecturerService.Add(new Lecturer
            {
                IdentityNumber = tbxAddLecturerIdentityNo.Text,
                Firstname = tbxAddLecturerFirstname.Text,
                Lastname =  tbxAddLecturerLastname.Text,
                DepartmentCode = cbxAddLecturerDepartment.Text.Split(' ')[0]
            });
            LoadLecturers();
        }

        private void dgwLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lecturerId = (int)dgwLecturers.CurrentRow.Cells["Id"].Value;
            var currentLecturer = _lecturerService.GetAll().SingleOrDefault(p => p.Id == lecturerId);
            if (currentLecturer != null)
            {
                tbxUpdateLecturerIdentityNo.Text = currentLecturer.IdentityNumber;
                tbxUpdateLecturerFirstname.Text = currentLecturer.Firstname;
                tbxUpdateLecturerLastname.Text = currentLecturer.Lastname;
                cbxUpdateLecturerDepartment.SelectedIndex = Convert.ToInt32(currentLecturer.DepartmentCode.Remove(0, 1)) - 1;
            }
        }

        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            _lecturerService.Update(new Lecturer
            {
                Id = (int)dgwLecturers.CurrentRow.Cells["Id"].Value,
                IdentityNumber = tbxUpdateLecturerIdentityNo.Text,
                Firstname = tbxUpdateLecturerFirstname.Text,
                Lastname = tbxUpdateLecturerLastname.Text,
                DepartmentCode = cbxUpdateLecturerDepartment.Text.Split(' ')[0]
            });
            LoadLecturers();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int lecturerId = (int)dgwLecturers.CurrentRow.Cells["Id"].Value;
            var currentLecturer = _lecturerService.GetAll().SingleOrDefault(p => p.Id == lecturerId);
            if(currentLecturer != null)
            {
                _lecturerService.Delete(currentLecturer);
                LoadLecturers();
            }
        }

        private void Lecturers_VisibleChanged(object sender, EventArgs e)
        {
            LoadLecturers();
            cbxAddLecturerDepartment.DataSource = _departmentService.GetDepartmentNames();
            cbxUpdateLecturerDepartment.DataSource = _departmentService.GetDepartmentNames();
            Reset();
        }
    }
}
