namespace Trian_Nugroho_Solo_OODB
{
    partial class Genre1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGDelete = new System.Windows.Forms.Button();
            this.btnGCancel = new System.Windows.Forms.Button();
            this.btnGUpdate = new System.Windows.Forms.Button();
            this.btnGSave = new System.Windows.Forms.Button();
            this.btnGInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.txtGId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGDelete);
            this.groupBox2.Controls.Add(this.btnGCancel);
            this.groupBox2.Controls.Add(this.btnGUpdate);
            this.groupBox2.Controls.Add(this.btnGSave);
            this.groupBox2.Controls.Add(this.btnGInsert);
            this.groupBox2.Location = new System.Drawing.Point(339, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnGDelete
            // 
            this.btnGDelete.Location = new System.Drawing.Point(169, 120);
            this.btnGDelete.Name = "btnGDelete";
            this.btnGDelete.Size = new System.Drawing.Size(75, 23);
            this.btnGDelete.TabIndex = 4;
            this.btnGDelete.Text = "Delete";
            this.btnGDelete.UseVisualStyleBackColor = true;
            // 
            // btnGCancel
            // 
            this.btnGCancel.Location = new System.Drawing.Point(169, 74);
            this.btnGCancel.Name = "btnGCancel";
            this.btnGCancel.Size = new System.Drawing.Size(75, 23);
            this.btnGCancel.TabIndex = 3;
            this.btnGCancel.Text = "Cancel";
            this.btnGCancel.UseVisualStyleBackColor = true;
            this.btnGCancel.Click += new System.EventHandler(this.btnGCancel_Click);
            // 
            // btnGUpdate
            // 
            this.btnGUpdate.Location = new System.Drawing.Point(25, 74);
            this.btnGUpdate.Name = "btnGUpdate";
            this.btnGUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnGUpdate.TabIndex = 2;
            this.btnGUpdate.Text = "Update";
            this.btnGUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGSave
            // 
            this.btnGSave.Location = new System.Drawing.Point(169, 30);
            this.btnGSave.Name = "btnGSave";
            this.btnGSave.Size = new System.Drawing.Size(75, 23);
            this.btnGSave.TabIndex = 1;
            this.btnGSave.Text = "Save";
            this.btnGSave.UseVisualStyleBackColor = true;
            // 
            // btnGInsert
            // 
            this.btnGInsert.Location = new System.Drawing.Point(25, 30);
            this.btnGInsert.Name = "btnGInsert";
            this.btnGInsert.Size = new System.Drawing.Size(75, 23);
            this.btnGInsert.TabIndex = 0;
            this.btnGInsert.Text = "Insert";
            this.btnGInsert.UseVisualStyleBackColor = true;
            this.btnGInsert.Click += new System.EventHandler(this.btnGInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGName);
            this.groupBox1.Controls.Add(this.txtGId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(31, 110);
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(228, 20);
            this.txtGName.TabIndex = 3;
            // 
            // txtGId
            // 
            this.txtGId.Location = new System.Drawing.Point(31, 51);
            this.txtGId.Name = "txtGId";
            this.txtGId.Size = new System.Drawing.Size(228, 20);
            this.txtGId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Genre1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(649, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Genre1";
            this.Text = "Genre1";
            this.Load += new System.EventHandler(this.Genre1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGDelete;
        private System.Windows.Forms.Button btnGCancel;
        private System.Windows.Forms.Button btnGUpdate;
        private System.Windows.Forms.Button btnGSave;
        private System.Windows.Forms.Button btnGInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.TextBox txtGId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}