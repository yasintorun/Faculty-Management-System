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
using University.Business.Concrete;
using University.Business.DependencyResolvers.Ninject;
using University.Entities.Concrete;

namespace UniversityInformation.Forms
{
    public partial class Departments : Form
    {
        private IDepartmentService _departmentService;
        public Departments()
        {
            InitializeComponent();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
            dgwDepartments.DataSource = _departmentService.GetAll();

           // dgwDepartments.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            _departmentService.Add(new Department
            {
                DepartmentCode = tbxAddDepartmentCode.Text,
                DepartmentName = tbxAddDepartmentName.Text
            });
            dgwDepartments.DataSource = _departmentService.GetAll();
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            int id = (int)dgwDepartments.CurrentRow.Cells["Id"].Value;

            _departmentService.Update(new Department
            {
                Id = id,
                DepartmentCode = tbxUpdateDepartmentCode.Text.ToUpper(),
                DepartmentName = tbxUpdateDepartmentName.Text
            }) ;
            dgwDepartments.DataSource = _departmentService.GetAll();
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            var cells = dgwDepartments.CurrentRow.Cells;
            if (cells.Count < 3) return;

            _departmentService.Delete(new Department
            {
                DepartmentCode = cells["DepartmentCode"].Value.ToString(),
                DepartmentName = cells["DepartmentName"].Value.ToString()
            });
            dgwDepartments.DataSource = _departmentService.GetAll();
        }

        private void dgwDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwDepartments.CurrentRow.Cells;
            tbxUpdateDepartmentCode.Text = cells["DepartmentCode"].Value.ToString();
            tbxUpdateDepartmentName.Text = cells["DepartmentName"].Value.ToString();
        }
    }
}
