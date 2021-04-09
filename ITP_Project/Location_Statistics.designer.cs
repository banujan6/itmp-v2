namespace ITP_Project
{
    partial class Location_Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.Reg_LecturerPan = new System.Windows.Forms.Panel();
            this.Reg_stdPan = new System.Windows.Forms.Panel();
            this.Reg_SubPan = new System.Windows.Forms.Panel();
            this.Reg_RoomPan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Crt_Lectxt = new System.Windows.Forms.TextBox();
            this.Cur_Grptxt = new System.Windows.Forms.TextBox();
            this.Cur_Modtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Reg_LecturerPan.SuspendLayout();
            this.Reg_stdPan.SuspendLayout();
            this.Reg_SubPan.SuspendLayout();
            this.Reg_RoomPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(884, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registered Locations";
            // 
            // Reg_LecturerPan
            // 
            this.Reg_LecturerPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_LecturerPan.Controls.Add(this.label9);
            this.Reg_LecturerPan.Location = new System.Drawing.Point(72, 23);
            this.Reg_LecturerPan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reg_LecturerPan.Name = "Reg_LecturerPan";
            this.Reg_LecturerPan.Size = new System.Drawing.Size(109, 74);
            this.Reg_LecturerPan.TabIndex = 3;
            // 
            // Reg_stdPan
            // 
            this.Reg_stdPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_stdPan.Controls.Add(this.label10);
            this.Reg_stdPan.Location = new System.Drawing.Point(367, 23);
            this.Reg_stdPan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reg_stdPan.Name = "Reg_stdPan";
            this.Reg_stdPan.Size = new System.Drawing.Size(109, 74);
            this.Reg_stdPan.TabIndex = 3;
            // 
            // Reg_SubPan
            // 
            this.Reg_SubPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_SubPan.Controls.Add(this.label11);
            this.Reg_SubPan.Location = new System.Drawing.Point(652, 23);
            this.Reg_SubPan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reg_SubPan.Name = "Reg_SubPan";
            this.Reg_SubPan.Size = new System.Drawing.Size(109, 74);
            this.Reg_SubPan.TabIndex = 3;
            // 
            // Reg_RoomPan
            // 
            this.Reg_RoomPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_RoomPan.Controls.Add(this.label12);
            this.Reg_RoomPan.Location = new System.Drawing.Point(909, 23);
            this.Reg_RoomPan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reg_RoomPan.Name = "Reg_RoomPan";
            this.Reg_RoomPan.Size = new System.Drawing.Size(109, 74);
            this.Reg_RoomPan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(338, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registered Students";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.label3.Location = new System.Drawing.Point(595, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Lecturer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Label4.Location = new System.Drawing.Point(45, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 24);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Registered Lecturers";
            // 
            // Crt_Lectxt
            // 
            this.Crt_Lectxt.Location = new System.Drawing.Point(813, 269);
            this.Crt_Lectxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Crt_Lectxt.Name = "Crt_Lectxt";
            this.Crt_Lectxt.Size = new System.Drawing.Size(249, 22);
            this.Crt_Lectxt.TabIndex = 5;
            // 
            // Cur_Grptxt
            // 
            this.Cur_Grptxt.Location = new System.Drawing.Point(813, 311);
            this.Cur_Grptxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cur_Grptxt.Name = "Cur_Grptxt";
            this.Cur_Grptxt.Size = new System.Drawing.Size(249, 22);
            this.Cur_Grptxt.TabIndex = 5;
            // 
            // Cur_Modtxt
            // 
            this.Cur_Modtxt.Location = new System.Drawing.Point(813, 350);
            this.Cur_Modtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cur_Modtxt.Name = "Cur_Modtxt";
            this.Cur_Modtxt.Size = new System.Drawing.Size(249, 22);
            this.Cur_Modtxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.label6.Location = new System.Drawing.Point(595, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Current Group";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.label7.Location = new System.Drawing.Point(595, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Subject";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(595, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Latest Updates";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label8.Location = new System.Drawing.Point(632, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Registered Subjects";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(72, 188);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Lecture Rooms";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Labs";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(283, 227);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Name = "Lecture Rooms";
            this.chart1.Titles.Add(title1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(26, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 29);
            this.label12.TabIndex = 7;
            this.label12.Text = "0";
            // 
            // Location_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 444);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Cur_Modtxt);
            this.Controls.Add(this.Cur_Grptxt);
            this.Controls.Add(this.Crt_Lectxt);
            this.Controls.Add(this.Reg_RoomPan);
            this.Controls.Add(this.Reg_SubPan);
            this.Controls.Add(this.Reg_stdPan);
            this.Controls.Add(this.Reg_LecturerPan);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Location_Statistics";
            this.Text = "Location Statics";
            this.Load += new System.EventHandler(this.Location_Statistics_Load);
            this.Reg_LecturerPan.ResumeLayout(false);
            this.Reg_LecturerPan.PerformLayout();
            this.Reg_stdPan.ResumeLayout(false);
            this.Reg_stdPan.PerformLayout();
            this.Reg_SubPan.ResumeLayout(false);
            this.Reg_SubPan.PerformLayout();
            this.Reg_RoomPan.ResumeLayout(false);
            this.Reg_RoomPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Reg_LecturerPan;
        private System.Windows.Forms.Panel Reg_stdPan;
        private System.Windows.Forms.Panel Reg_SubPan;
        private System.Windows.Forms.Panel Reg_RoomPan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox Crt_Lectxt;
        private System.Windows.Forms.TextBox Cur_Grptxt;
        private System.Windows.Forms.TextBox Cur_Modtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}