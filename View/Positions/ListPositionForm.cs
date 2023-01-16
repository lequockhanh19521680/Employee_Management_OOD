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

namespace Salary_management.View.Positions
{
    public partial class ListPositionForm : BaseForm
    {

        public ListPositionForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void ListPositionForm_Load(object sender, EventArgs e)
        {
            LoadPosition();
            LoadRank();
        }

        private void LoadPosition()
        {
            this.listPositionsTable.Rows.Clear();
            RepositoryPosition repo1 = new RepositoryPosition();
            List<Model.Position> listPosition = repo1.GetPositions("");
            foreach (Model.Position position in listPosition)
            {
                listPositionsTable.Rows.Add(position.Id, position.Name, position.BaseSalary, position.Description, position.Rank.Name);
            }
        }

        private void LoadRank()
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.listPositionsTable.Rows.Clear();
            RepositoryPosition repo1 = new RepositoryPosition();
            List<Model.Position> listPosition = repo1.GetPositions(searchText.Text);
            foreach (Model.Position position in listPosition)
            {
                listPositionsTable.Rows.Add(position.Id, position.Name, position.BaseSalary, position.Description, position.Rank.Name);
            }
        }
    }
}
