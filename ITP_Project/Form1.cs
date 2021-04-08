using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_working_schedule_Click(object sender, EventArgs e)
        {
            add_working_hours_days_window workingHoursWindow = new add_working_hours_days_window();
            workingHoursWindow.ShowDialog();
        }

        private void btn_manage_taglist_Click(object sender, EventArgs e)
        {
            Add_Tags tagWindow = new Add_Tags();
            tagWindow.ShowDialog();
        }
    }
}
