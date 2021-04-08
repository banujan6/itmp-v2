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
            this.label1 = new System.Windows.Forms.Label();
            this.Reg_LecturerPan = new System.Windows.Forms.Panel();
            this.Reg_stdPan = new System.Windows.Forms.Panel();
            this.Reg_SubPan = new System.Windows.Forms.Panel();
            this.Reg_RoomPan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.Crt_Lectxt = new System.Windows.Forms.TextBox();
            this.Cur_Grptxt = new System.Windows.Forms.TextBox();
            this.Cur_Modtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(943, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registered Rooms";
            // 
            // Reg_LecturerPan
            // 
            this.Reg_LecturerPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_LecturerPan.Location = new System.Drawing.Point(72, 29);
            this.Reg_LecturerPan.Name = "Reg_LecturerPan";
            this.Reg_LecturerPan.Size = new System.Drawing.Size(109, 93);
            this.Reg_LecturerPan.TabIndex = 3;
            // 
            // Reg_stdPan
            // 
            this.Reg_stdPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_stdPan.Location = new System.Drawing.Point(367, 29);
            this.Reg_stdPan.Name = "Reg_stdPan";
            this.Reg_stdPan.Size = new System.Drawing.Size(109, 93);
            this.Reg_stdPan.TabIndex = 3;
            // 
            // Reg_SubPan
            // 
            this.Reg_SubPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_SubPan.Location = new System.Drawing.Point(669, 29);
            this.Reg_SubPan.Name = "Reg_SubPan";
            this.Reg_SubPan.Size = new System.Drawing.Size(109, 93);
            this.Reg_SubPan.TabIndex = 3;
            // 
            // Reg_RoomPan
            // 
            this.Reg_RoomPan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reg_RoomPan.Location = new System.Drawing.Point(953, 29);
            this.Reg_RoomPan.Name = "Reg_RoomPan";
            this.Reg_RoomPan.Size = new System.Drawing.Size(109, 93);
            this.Reg_RoomPan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registered Students";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(595, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Lecturer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(57, 148);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 24);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Registered Lecturers";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(109, 309);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(239, 88);
            this.progressBar3.TabIndex = 4;
            this.progressBar3.Value = 80;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(109, 403);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(239, 88);
            this.progressBar4.TabIndex = 4;
            this.progressBar4.Value = 30;
            this.progressBar4.Click += new System.EventHandler(this.progressBar4_Click);
            // 
            // Crt_Lectxt
            // 
            this.Crt_Lectxt.Location = new System.Drawing.Point(813, 336);
            this.Crt_Lectxt.Name = "Crt_Lectxt";
            this.Crt_Lectxt.Size = new System.Drawing.Size(249, 27);
            this.Crt_Lectxt.TabIndex = 5;
            // 
            // Cur_Grptxt
            // 
            this.Cur_Grptxt.Location = new System.Drawing.Point(813, 389);
            this.Cur_Grptxt.Name = "Cur_Grptxt";
            this.Cur_Grptxt.Size = new System.Drawing.Size(249, 27);
            this.Cur_Grptxt.TabIndex = 5;
            // 
            // Cur_Modtxt
            // 
            this.Cur_Modtxt.Location = new System.Drawing.Point(813, 438);
            this.Cur_Modtxt.Name = "Cur_Modtxt";
            this.Cur_Modtxt.Size = new System.Drawing.Size(249, 27);
            this.Cur_Modtxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(595, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Current Group";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(595, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Module";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(595, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Latest Updates";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(656, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Registered Subjects";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Locations";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // Location_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 555);
            this.Controls.Add(this.Cur_Modtxt);
            this.Controls.Add(this.Cur_Grptxt);
            this.Controls.Add(this.Crt_Lectxt);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.Reg_RoomPan);
            this.Controls.Add(this.Reg_SubPan);
            this.Controls.Add(this.Reg_stdPan);
            this.Controls.Add(this.Reg_LecturerPan);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Location_Statistics";
            this.Text = "Location_Statistics";
            this.Load += new System.EventHandler(this.Location_Statistics_Load);
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
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.TextBox Crt_Lectxt;
        private System.Windows.Forms.TextBox Cur_Grptxt;
        private System.Windows.Forms.TextBox Cur_Modtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}