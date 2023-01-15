using Salary_management.Controller.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Employees
{
    public partial class ListEmployeeForm : BaseForm
    {
        public ListEmployeeForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.listEmployeeTable.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees(searchText.Text);
            foreach (Model.Employee employee in list)
            {
                listEmployeeTable.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }

        private void ListEmployeeForm_Load(object sender, EventArgs e)
        {
            this.listEmployeeTable.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees("");
            foreach (Model.Employee employee in list)
            {
                listEmployeeTable.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }
    }
}
