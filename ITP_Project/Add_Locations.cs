using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP_Project
{
    public partial class Add_Locations : Form
    {
        public Add_Locations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string building = this.txtBuilding.Text;
            string room = this.txtRoom.Text;
            string type = this.roomType.Text;
            string capacity = this.txtCapacity.Text;

            if (building == "" || room == "" || type == "" || capacity == "") {
                MessageBox.Show("You need to fill all fields.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO locations VALUES ('','"+building+"','"+room+"','"+type+"','"+capacity+"')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Location has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.loadData();

            this.Clearbtn_Click(null, EventArgs.Empty);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtBuilding.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtRoom.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.roomType.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtCapacity.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.inserBtn.Enabled = false;
                this.deleteBtn.Enabled = false;
                this.Updatebtn.Text = "Save";
                this.Clearbtn.Text = "Cancel";
                this.updateMode = true;
            }
            else {

                string building = this.txtBuilding.Text;
                string room = this.txtRoom.Text;
                string type = this.roomType.Text;
                string capacity = this.txtCapacity.Text;

                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE locations SET building = '"+ building + "', room = '"+room+"', type = '"+type+"', capacity = '"+capacity+"' WHERE id = "+this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Location has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();


                this.inserBtn.Enabled = true;
                this.deleteBtn.Enabled = true;
                this.Updatebtn.Text = "Update";
                this.Clearbtn.Text = "Clear";
                this.updateMode = true;
                this.selectedRecord = null;

                this.Clearbtn_Click(null, EventArgs.Empty);
            }
        }

        private void loadData()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM locations ORDER BY id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                row.Cells[0].Value = dr.GetInt64("id").ToString();
                row.Cells[1].Value = dr.GetString("building");
                row.Cells[2].Value = dr.GetString("room");
                row.Cells[3].Value = dr.GetString("type");
                row.Cells[4].Value = dr.GetString("capacity");
                this.dataGridView1.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void Add_Locations_Load(object sender, EventArgs e)
        {
            this.loadData();   
        }

        private Boolean updateMode = false;
        private string selectedRecord = null;

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.txtBuilding.Text = "";
            this.txtRoom.Text = "";
            this.roomType.Text = "";
            this.txtCapacity.Text = "";
            this.selectedRecord = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Do you want to delete location '" + name + "'", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM locations WHERE id = "+id);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Location has been removed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();
            }
        }
    }
}
