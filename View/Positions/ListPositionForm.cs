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

        }
    }
}
