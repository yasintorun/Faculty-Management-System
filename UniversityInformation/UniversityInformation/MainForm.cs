using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityInformation
{
    public partial class MainForm : Form
    {

        private Button currentButton;
        private Form activeForm;
        private Form Department;
        private Form Student;
        private Form Lecturer;
        private Form Lessons;
        private Form Grades;
        private Form AboutUs;

        public MainForm()
        {
            InitializeComponent();
            Department = new Forms.Departments(); //uygulama başlatır başlatmaz formları birkez oluşturalım ki Instance oluşsun.
            Student = new Forms.Students();
            Lecturer = new Forms.Lecturers();
            Lessons = new Forms.Lessons();
            Grades = new Forms.Grades();
            AboutUs = new Forms.AboutUs();

            btnDepartments_Click(btnDepartments, null);
        }

        private void ActivateButton(object btnSender, string colorString)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml(colorString);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    lblTitle.Text = currentButton.Text;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, string colorString)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            ActivateButton(btnSender, colorString);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            OpenChildForm(Department, sender, "#EF937E");
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            OpenChildForm(Lecturer, sender, "#35018B");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenChildForm(Student, sender, "#E41A4A");
        }

        private void btnLessons_Click(object sender, EventArgs e)
        {
            OpenChildForm(Lessons, sender, "#018790");
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(Grades, sender, "#8BC240");
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(AboutUs, sender, "#43B76E");
        }
    }
}
