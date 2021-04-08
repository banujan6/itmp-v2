
namespace ITP_Project
{
    partial class Add_Tags
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
            this.tagNametxt = new System.Windows.Forms.TextBox();
            this.tagNameLbl = new System.Windows.Forms.Label();
            this.tagCodeLbl = new System.Windows.Forms.Label();
            this.tagCodetxt = new System.Windows.Forms.TextBox();
            this.relatedTagLbl = new System.Windows.Forms.Label();
            this.relatedTagtxt = new System.Windows.Forms.TextBox();
            this.insertBtn_tag = new System.Windows.Forms.Button();
            this.updateBtn_tag = new System.Windows.Forms.Button();
            this.deleteBtn_tag = new System.Windows.Forms.Button();
            this.clearBtn_tag = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Tags";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tagNametxt
            // 
            this.tagNametxt.Location = new System.Drawing.Point(170, 126);
            this.tagNametxt.Name = "tagNametxt";
            this.tagNametxt.Size = new System.Drawing.Size(239, 27);
            this.tagNametxt.TabIndex = 1;
            this.tagNametxt.TextChanged += new System.EventHandler(this.tagNametxt_TextChanged);
            // 
            // tagNameLbl
            // 
            this.tagNameLbl.AutoSize = true;
            this.tagNameLbl.Location = new System.Drawing.Point(39, 129);
            this.tagNameLbl.Name = "tagNameLbl";
            this.tagNameLbl.Size = new System.Drawing.Size(76, 20);
            this.tagNameLbl.TabIndex = 2;
            this.tagNameLbl.Text = "Tag Name";
            this.tagNameLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // tagCodeLbl
            // 
            this.tagCodeLbl.AutoSize = true;
            this.tagCodeLbl.Location = new System.Drawing.Point(39, 198);
            this.tagCodeLbl.Name = "tagCodeLbl";
            this.tagCodeLbl.Size = new System.Drawing.Size(71, 20);
            this.tagCodeLbl.TabIndex = 2;
            this.tagCodeLbl.Text = "Tag Code";
            this.tagCodeLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // tagCodetxt
            // 
            this.tagCodetxt.Location = new System.Drawing.Point(170, 195);
            this.tagCodetxt.Name = "tagCodetxt";
            this.tagCodetxt.Size = new System.Drawing.Size(239, 27);
            this.tagCodetxt.TabIndex = 1;
            this.tagCodetxt.TextChanged += new System.EventHandler(this.tagCodetxt_TextChanged);
            // 
            // relatedTagLbl
            // 
            this.relatedTagLbl.AutoSize = true;
            this.relatedTagLbl.Location = new System.Drawing.Point(39, 270);
            this.relatedTagLbl.Name = "relatedTagLbl";
            this.relatedTagLbl.Size = new System.Drawing.Size(87, 20);
            this.relatedTagLbl.TabIndex = 2;
            this.relatedTagLbl.Text = "Related Tag";
            this.relatedTagLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // relatedTagtxt
            // 
            this.relatedTagtxt.Location = new System.Drawing.Point(170, 267);
            this.relatedTagtxt.Name = "relatedTagtxt";
            this.relatedTagtxt.Size = new System.Drawing.Size(239, 27);
            this.relatedTagtxt.TabIndex = 1;
            this.relatedTagtxt.TextChanged += new System.EventHandler(this.relatedTagtxt_TextChanged);
            // 
            // insertBtn_tag
            // 
            this.insertBtn_tag.BackColor = System.Drawing.SystemColors.Info;
            this.insertBtn_tag.Location = new System.Drawing.Point(189, 319);
            this.insertBtn_tag.Name = "insertBtn_tag";
            this.insertBtn_tag.Size = new System.Drawing.Size(127, 42);
            this.insertBtn_tag.TabIndex = 4;
            this.insertBtn_tag.Text = "Insert";
            this.insertBtn_tag.UseVisualStyleBackColor = false;
            // 
            // updateBtn_tag
            // 
            this.updateBtn_tag.BackColor = System.Drawing.SystemColors.Info;
            this.updateBtn_tag.Location = new System.Drawing.Point(384, 319);
            this.updateBtn_tag.Name = "updateBtn_tag";
            this.updateBtn_tag.Size = new System.Drawing.Size(127, 42);
            this.updateBtn_tag.TabIndex = 4;
            this.updateBtn_tag.Text = "Update";
            this.updateBtn_tag.UseVisualStyleBackColor = false;
            // 
            // deleteBtn_tag
            // 
            this.deleteBtn_tag.BackColor = System.Drawing.SystemColors.Info;
            this.deleteBtn_tag.Location = new System.Drawing.Point(579, 319);
            this.deleteBtn_tag.Name = "deleteBtn_tag";
            this.deleteBtn_tag.Size = new System.Drawing.Size(127, 42);
            this.deleteBtn_tag.TabIndex = 4;
            this.deleteBtn_tag.Text = "Delete";
            this.deleteBtn_tag.UseVisualStyleBackColor = false;
            // 
            // clearBtn_tag
            // 
            this.clearBtn_tag.BackColor = System.Drawing.SystemColors.Info;
            this.clearBtn_tag.Location = new System.Drawing.Point(768, 319);
            this.clearBtn_tag.Name = "clearBtn_tag";
            this.clearBtn_tag.Size = new System.Drawing.Size(127, 42);
            this.clearBtn_tag.TabIndex = 4;
            this.clearBtn_tag.Text = "Clear";
            this.clearBtn_tag.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 311);
            this.dataGridView1.TabIndex = 5;
            // 
            // Add_Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 725);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBtn_tag);
            this.Controls.Add(this.deleteBtn_tag);
            this.Controls.Add(this.updateBtn_tag);
            this.Controls.Add(this.insertBtn_tag);
            this.Controls.Add(this.relatedTagLbl);
            this.Controls.Add(this.tagCodeLbl);
            this.Controls.Add(this.tagNameLbl);
            this.Controls.Add(this.relatedTagtxt);
            this.Controls.Add(this.tagCodetxt);
            this.Controls.Add(this.tagNametxt);
            this.Controls.Add(this.label1);
            this.Name = "Add_Tags";
            this.Text = "Add_Tags";
            this.Load += new System.EventHandler(this.Add_Tags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagNametxt;
        private System.Windows.Forms.Label tagNameLbl;
        private System.Windows.Forms.Label tagCodeLbl;
        private System.Windows.Forms.TextBox tagCodetxt;
        private System.Windows.Forms.Label relatedTagLbl;
        private System.Windows.Forms.TextBox relatedTagtxt;
        private System.Windows.Forms.Button insertBtn_tag;
        private System.Windows.Forms.Button updateBtn_tag;
        private System.Windows.Forms.Button deleteBtn_tag;
        private System.Windows.Forms.Button clearBtn_tag;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}