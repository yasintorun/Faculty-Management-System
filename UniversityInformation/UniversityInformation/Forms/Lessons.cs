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
    public partial class Lessons : Form
    {
        private ILessonService _lessonService;
        private IDepartmentService _departmentService;
        private ILecturerService _lecturerService;
        public Lessons()
        {
            InitializeComponent();

            _lessonService = InstanceFactory.GetInstance<ILessonService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            _lecturerService = InstanceFactory.GetInstance<ILecturerService>();
        }

        private void LoadLessons()
        {
            dgwLessons.DataSource = _lessonService.GetAll();
        } 

        private void Reset()
        {
            tbxAddLessonCode.Text = "";
            tbxAddLessonCredit.Text = "";
            tbxAddLessonClassroom.Text = "";
            cbxAddLessonDepartment.SelectedIndex = 0;
            cbxAddLessonLecturer.SelectedIndex = 0;

            tbxUpdateLessonCode.Text = "";
            tbxUpdateLessonCredit.Text = "";
            tbxUpdateLessonClassroom.Text = "";
            cbxUpdateLessonDepartment.SelectedIndex = 0;
            cbxUpdateLessonLecturer.SelectedIndex = 0;
        }

        private void dgwLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lessonId = (int)dgwLessons.CurrentRow.Cells["Id"].Value;
            var currentLesson = _lessonService.GetAll().SingleOrDefault(p => p.Id == lessonId);
            
            if(currentLesson != null)
            {
                tbxUpdateLessonCode.Text = currentLesson.LessonCode;
                tbxUpdateLessonCredit.Text = currentLesson.LessonCredit;
                tbxUpdateLessonClassroom.Text = currentLesson.Classroom;
                cbxUpdateLessonDepartment.SelectedIndex = Convert.ToInt32(currentLesson.DepartmentCode.Remove(0, 1)) - 1;

                var lessonLecturerList = cbxUpdateLessonLecturer.Items.Cast<object>().Select(p => p.ToString()).ToList();
                cbxUpdateLessonLecturer.SelectedIndex = lessonLecturerList.IndexOf(lessonLecturerList.SingleOrDefault(p => p.StartsWith(currentLesson.LecturerNo)));

            }

        }


        //Kullanıcı sekmeler arasında geçiş yaptıgında Tekrar yüklenecek olan elemanlar.
        private void Lessons_VisibleChanged(object sender, EventArgs e)
        {
            LoadLessons();
            cbxAddLessonDepartment.DataSource = _departmentService.GetDepartmentNames();
            cbxAddLessonDepartment_SelectedIndexChanged(null, null);

            cbxUpdateLessonDepartment.DataSource = _departmentService.GetDepartmentNames();
            cbxUpdateLessonDepartment_SelectedIndexChanged(null, null);
        }

       
        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            var depCode = _departmentService.GetAll().Select(p => p.DepartmentCode).ToList();
            Random random = new Random();

            foreach (var item in depCode)
            {
                cbxAddLessonLecturer.DataSource = _lecturerService.GetLecturerNames().Where(p => p.StartsWith(item.Remove(0, 1))).ToList();
                int l = random.Next(3, 8);
                for(int i = 1; i< l; i++)
                {
                    cbxAddLessonLecturer.SelectedIndex = random.Next(cbxAddLessonLecturer.Items.Count);
                    
                    _lessonService.Add(new Lesson
                    {
                        LessonCode = item+'0'+i,
                        LessonCredit = random.Next(1,8).ToString(),
                        Classroom = random.Next(1, 10).ToString(),
                        DepartmentCode = item,
                        LecturerNo = cbxAddLessonLecturer.Text.Split(' ')[0]
                    });
                }
            }

           /* _lessonService.Add(new Lesson
            {
                LessonCode = tbxAddLessonCode.Text,
                LessonCredit = tbxAddLessonCredit.Text,
                Classroom = tbxAddLessonClassroom.Text,
                DepartmentCode = cbxAddLessonDepartment.Text.Split(' ')[0],
                LecturerNo = cbxAddLessonLecturer.Text.Split(' ')[0]
            });*/
            LoadLessons();

            //Reset();
        }

        private void btnUpdateLesson_Click(object sender, EventArgs e)
        {
            _lessonService.Update(new Lesson
            {
                Id = (int)dgwLessons.CurrentRow.Cells["Id"].Value,
                LessonCode = tbxUpdateLessonCode.Text,
                LessonCredit = tbxUpdateLessonCredit.Text,
                Classroom = tbxUpdateLessonClassroom.Text,
                DepartmentCode = cbxUpdateLessonDepartment.Text.Split(' ')[0],
                LecturerNo = cbxUpdateLessonLecturer.Text.Split(' ')[0]
            });

            LoadLessons();
            //Reset();
        }

        private void cbxAddLessonDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departmentCode = cbxAddLessonDepartment.Text.Split(' ')[0];

            cbxAddLessonLecturer.DataSource = _lecturerService.GetLecturerNames().Where(p => p.StartsWith(departmentCode.Remove(0, 1))).ToList();

        }

        private void cbxUpdateLessonDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departmentCode = cbxUpdateLessonDepartment.Text.Split(' ')[0];

            cbxUpdateLessonLecturer.DataSource = _lecturerService.GetLecturerNames().Where(p => p.StartsWith(departmentCode.Remove(0, 1))).ToList();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            int lessonId = (int)dgwLessons.CurrentRow.Cells["Id"].Value;

            Lesson currentLesson = _lessonService.GetAll().SingleOrDefault(p => p.Id == lessonId);
            if(currentLesson!=null)
            {
                _lessonService.Delete(currentLesson);
                LoadLessons();
            }

        }

        private void btnAddStudentToLesson_Click(object sender, EventArgs e)
        {
            string departmentCode = dgwLessons.CurrentRow.Cells["DepartmentCode"].Value.ToString();
            string lessonCode = dgwLessons.CurrentRow.Cells["LessonCode"].Value.ToString();
            LessonRecords lessonRecords = new LessonRecords(departmentCode, lessonCode);
            lessonRecords.ShowDialog();
        }

    }
}
