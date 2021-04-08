
namespace ITP_Project
{
    partial class add_student_group
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.semAndYear = new System.Windows.Forms.ComboBox();
            this.progrm = new System.Windows.Forms.Label();
            this.programme = new System.Windows.Forms.ComboBox();
            this.grpNumber = new System.Windows.Forms.Label();
            this.grpNum = new System.Windows.Forms.TextBox();
            this.subGrpNumber = new System.Windows.Forms.Label();
            this.subGrpNum = new System.Windows.Forms.TextBox();
            this.grpId = new System.Windows.Forms.Label();
            this.subGrpId = new System.Windows.Forms.Label();
            this.grpIdText = new System.Windows.Forms.TextBox();
            this.SubgrpIdText = new System.Windows.Forms.TextBox();
            this.generateIdBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-132, -38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Acedemic Year and  Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Student Groups";
            // 
            // semAndYear
            // 
            this.semAndYear.FormattingEnabled = true;
            this.semAndYear.Location = new System.Drawing.Point(244, 105);
            this.semAndYear.Name = "semAndYear";
            this.semAndYear.Size = new System.Drawing.Size(201, 28);
            this.semAndYear.TabIndex = 5;
            this.semAndYear.SelectedIndexChanged += new System.EventHandler(this.semAndYear_SelectedIndexChanged);
            // 
            // progrm
            // 
            this.progrm.AutoSize = true;
            this.progrm.Location = new System.Drawing.Point(23, 166);
            this.progrm.Name = "progrm";
            this.progrm.Size = new System.Drawing.Size(87, 20);
            this.progrm.TabIndex = 3;
            this.progrm.Text = "Programme";
            // 
            // programme
            // 
            this.programme.FormattingEnabled = true;
            this.programme.Location = new System.Drawing.Point(244, 166);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(201, 28);
            this.programme.TabIndex = 5;
            // 
            // grpNumber
            // 
            this.grpNumber.AutoSize = true;
            this.grpNumber.Location = new System.Drawing.Point(23, 236);
            this.grpNumber.Name = "grpNumber";
            this.grpNumber.Size = new System.Drawing.Size(108, 20);
            this.grpNumber.TabIndex = 3;
            this.grpNumber.Text = "Group Number";
            // 
            // grpNum
            // 
            this.grpNum.Location = new System.Drawing.Point(244, 233);
            this.grpNum.Name = "grpNum";
            this.grpNum.Size = new System.Drawing.Size(201, 27);
            this.grpNum.TabIndex = 6;
            // 
            // subGrpNumber
            // 
            this.subGrpNumber.AutoSize = true;
            this.subGrpNumber.Location = new System.Drawing.Point(23, 301);
            this.subGrpNumber.Name = "subGrpNumber";
            this.subGrpNumber.Size = new System.Drawing.Size(137, 20);
            this.subGrpNumber.TabIndex = 3;
            this.subGrpNumber.Text = "Sub Group Number";
            this.subGrpNumber.Click += new System.EventHandler(this.label4_Click);
            // 
            // subGrpNum
            // 
            this.subGrpNum.Location = new System.Drawing.Point(244, 298);
            this.subGrpNum.Name = "subGrpNum";
            this.subGrpNum.Size = new System.Drawing.Size(201, 27);
            this.subGrpNum.TabIndex = 6;
            this.subGrpNum.TextChanged += new System.EventHandler(this.subGrpNum_TextChanged);
            // 
            // grpId
            // 
            this.grpId.AutoSize = true;
            this.grpId.Location = new System.Drawing.Point(592, 113);
            this.grpId.Name = "grpId";
            this.grpId.Size = new System.Drawing.Size(69, 20);
            this.grpId.TabIndex = 3;
            this.grpId.Text = "Group ID";
            this.grpId.Click += new System.EventHandler(this.label4_Click);
            // 
            // subGrpId
            // 
            this.subGrpId.AutoSize = true;
            this.subGrpId.Location = new System.Drawing.Point(592, 166);
            this.subGrpId.Name = "subGrpId";
            this.subGrpId.Size = new System.Drawing.Size(98, 20);
            this.subGrpId.TabIndex = 3;
            this.subGrpId.Text = "Sub Group ID";
            this.subGrpId.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpIdText
            // 
            this.grpIdText.Location = new System.Drawing.Point(753, 105);
            this.grpIdText.Name = "grpIdText";
            this.grpIdText.Size = new System.Drawing.Size(201, 27);
            this.grpIdText.TabIndex = 6;
            // 
            // SubgrpIdText
            // 
            this.SubgrpIdText.Location = new System.Drawing.Point(753, 163);
            this.SubgrpIdText.Name = "SubgrpIdText";
            this.SubgrpIdText.Size = new System.Drawing.Size(201, 27);
            this.SubgrpIdText.TabIndex = 6;
            // 
            // generateIdBtn
            // 
            this.generateIdBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generateIdBtn.Location = new System.Drawing.Point(671, 236);
            this.generateIdBtn.Name = "generateIdBtn";
            this.generateIdBtn.Size = new System.Drawing.Size(133, 41);
            this.generateIdBtn.TabIndex = 7;
            this.generateIdBtn.Text = "Generate IDs";
            this.generateIdBtn.UseVisualStyleBackColor = false;
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.Info;
            this.insertBtn.Location = new System.Drawing.Point(40, 370);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(133, 41);
            this.insertBtn.TabIndex = 7;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Info;
            this.updateBtn.Location = new System.Drawing.Point(206, 370);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 41);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Info;
            this.deleteBtn.Location = new System.Drawing.Point(369, 370);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 41);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Info;
            this.clearBtn.Location = new System.Drawing.Point(528, 370);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 41);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 307);
            this.dataGridView1.TabIndex = 8;
            // 
            // add_student_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 759);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.generateIdBtn);
            this.Controls.Add(this.subGrpNum);
            this.Controls.Add(this.SubgrpIdText);
            this.Controls.Add(this.grpIdText);
            this.Controls.Add(this.grpNum);
            this.Controls.Add(this.programme);
            this.Controls.Add(this.semAndYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subGrpId);
            this.Controls.Add(this.grpId);
            this.Controls.Add(this.subGrpNumber);
            this.Controls.Add(this.grpNumber);
            this.Controls.Add(this.progrm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_student_group";
            this.Text = "add_student_group";
            this.Load += new System.EventHandler(this.add_student_group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox semAndYear;
        private System.Windows.Forms.Label progrm;
        private System.Windows.Forms.ComboBox programme;
        private System.Windows.Forms.Label grpNumber;
        private System.Windows.Forms.TextBox grpNum;
        private System.Windows.Forms.Label subGrpNumber;
        private System.Windows.Forms.TextBox subGrpNum;
        private System.Windows.Forms.Label grpId;
        private System.Windows.Forms.Label subGrpId;
        private System.Windows.Forms.TextBox grpIdText;
        private System.Windows.Forms.TextBox SubgrpIdText;
        private System.Windows.Forms.Button generateIdBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}