using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP_Project
{
    public partial class add_working_hours_days_window : Form
    {
        public add_working_hours_days_window()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            ArrayList days = new ArrayList();
            CheckedListBox.CheckedItemCollection workingDays = this.checkedListBox1.CheckedItems;
            
            foreach ( Object item in workingDays )
            {
                days.Add("'"+item.ToString().ToLower()+"'");
            }

            string sql = "UPDATE working_days SET isWorkingDay=1 WHERE day IN ("+string.Join(",",days.Cast<string>().ToArray())+")";
            string iSql = "UPDATE working_days SET isWorkingDay=0 WHERE day NOT IN ("+string.Join(",",days.Cast<string>().ToArray())+")";

            MySqlCommand cmd = new MySqlCommand(sql);
            MySqlCommand iCmd = new MySqlCommand(iSql);
            cmd.Connection = connect;
            iCmd.Connection = connect;

            connect.Open();

            cmd.ExecuteReader().Close();
            iCmd.ExecuteReader().Close();

            MessageBox.Show("Working Days & Hours Updated!");

            connect.Close();

        }

        private void workingDaysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void add_working_hours_days_window_Load(object sender, EventArgs e)
        {
            this.checkItems();
        }
    }
}
