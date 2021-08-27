using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Books
{
    public partial class ReportFilter : Form
    {
        public ReportFilter()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Viewr viewr = new Viewr(comboBoxType.SelectedItem.ToString(),textBoxAtribute.Text);
            viewr.Show();
        }

        
    }
}
