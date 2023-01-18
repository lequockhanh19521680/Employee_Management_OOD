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

namespace Salary_management.View.Employees_Review
{
    public partial class AddReviewForm : BaseForm
    {
        bool isReward;
        public AddReviewForm(Management mng, bool isReward)
        {
            InitializeComponent();
            this.mng = mng;
            this.isReward = isReward;
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeInComboBox();
        }

        private void LoadEmployeeInComboBox()
        {
            var repoEmployee = new RepositoryEmployee();
            List<Model.Employee> listEmployee = repoEmployee.GetEmployees("");
            foreach (Model.Employee employee in listEmployee)
            {
                employeeComboBox.Items.Add(employee.Id + ":" + employee.Name);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new ReviewForm(mng));
        }
    }
}
