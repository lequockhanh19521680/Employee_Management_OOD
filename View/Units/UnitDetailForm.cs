using Salary_management.Controller.Infrastructure.Repositories;
using ScottPlot.Ticks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Units
{
    public partial class UnitDetailForm : BaseForm
    {
        string idUnit;
        public UnitDetailForm(Management mng, string idUnit)
        {
            InitializeComponent();
            this.idUnit = idUnit;
            this.mng = mng;
        }

        private void UnitDetailForm_Load(object sender, EventArgs e)
        {
            LoadUnitDetail();
        }

        private void LoadUnitDetail()
        {
            var repo = new RepositoryUnit();
            var unit = repo.GetUnitDetail(idUnit);

            nameText.Text = unit.Name;
            addressText.Text = unit.Address;
            phoneText.Text = unit.PhoneNumber;
            dateFoundedDatePicker.Value = new DateTime(unit.DateFounded.Year, unit.DateFounded.Month, unit.DateFounded.Day);
            var repoTable = new RepositoryUnit();
            var table = repoTable.GetTimeline(idUnit).Payload;
            foreach (var employee in table)
            {
                unitDetailTable.Rows.Add(employee.EmployeeId, employee.EmployeeName, employee.StartDate.ToString(), employee.EndDate.ToString());
            }

        }


    }
}
