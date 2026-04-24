namespace Trian_Nugroho_Solo_OODB
{
    partial class Master_User
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMUAddress = new System.Windows.Forms.TextBox();
            this.txtMUPhone = new System.Windows.Forms.TextBox();
            this.cmbMURole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMUGender = new System.Windows.Forms.ComboBox();
            this.txtMUPassword = new System.Windows.Forms.TextBox();
            this.txtMUEmail = new System.Windows.Forms.TextBox();
            this.txtMUName = new System.Windows.Forms.TextBox();
            this.txtMUID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMUDelete = new System.Windows.Forms.Button();
            this.btnMUCancel = new System.Windows.Forms.Button();
            this.btnMUUpdate = new System.Windows.Forms.Button();
            this.btnMUSave = new System.Windows.Forms.Button();
            this.btnMUInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMUAddress);
            this.groupBox1.Controls.Add(this.txtMUPhone);
            this.groupBox1.Controls.Add(this.cmbMURole);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbMUGender);
            this.groupBox1.Controls.Add(this.txtMUPassword);
            this.groupBox1.Controls.Add(this.txtMUEmail);
            this.groupBox1.Controls.Add(this.txtMUName);
            this.groupBox1.Controls.Add(this.txtMUID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // txtMUAddress
            // 
            this.txtMUAddress.Location = new System.Drawing.Point(276, 82);
            this.txtMUAddress.Multiline = true;
            this.txtMUAddress.Name = "txtMUAddress";
            this.txtMUAddress.Size = new System.Drawing.Size(137, 70);
            this.txtMUAddress.TabIndex = 15;
            // 
            // txtMUPhone
            // 
            this.txtMUPhone.Location = new System.Drawing.Point(276, 55);
            this.txtMUPhone.Name = "txtMUPhone";
            this.txtMUPhone.Size = new System.Drawing.Size(137, 20);
            this.txtMUPhone.TabIndex = 14;
            this.txtMUPhone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cmbMURole
            // 
            this.cmbMURole.FormattingEnabled = true;
            this.cmbMURole.Location = new System.Drawing.Point(276, 27);
            this.cmbMURole.Name = "cmbMURole";
            this.cmbMURole.Size = new System.Drawing.Size(137, 21);
            this.cmbMURole.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Role";
            // 
            // cmbMUGender
            // 
            this.cmbMUGender.FormattingEnabled = true;
            this.cmbMUGender.Location = new System.Drawing.Point(97, 131);
            this.cmbMUGender.Name = "cmbMUGender";
            this.cmbMUGender.Size = new System.Drawing.Size(121, 21);
            this.cmbMUGender.TabIndex = 9;
            // 
            // txtMUPassword
            // 
            this.txtMUPassword.Location = new System.Drawing.Point(97, 105);
            this.txtMUPassword.Name = "txtMUPassword";
            this.txtMUPassword.Size = new System.Drawing.Size(121, 20);
            this.txtMUPassword.TabIndex = 8;
            // 
            // txtMUEmail
            // 
            this.txtMUEmail.Location = new System.Drawing.Point(97, 79);
            this.txtMUEmail.Name = "txtMUEmail";
            this.txtMUEmail.Size = new System.Drawing.Size(121, 20);
            this.txtMUEmail.TabIndex = 7;
            // 
            // txtMUName
            // 
            this.txtMUName.Location = new System.Drawing.Point(97, 53);
            this.txtMUName.Name = "txtMUName";
            this.txtMUName.Size = new System.Drawing.Size(121, 20);
            this.txtMUName.TabIndex = 6;
            // 
            // txtMUID
            // 
            this.txtMUID.Location = new System.Drawing.Point(97, 27);
            this.txtMUID.Name = "txtMUID";
            this.txtMUID.Size = new System.Drawing.Size(121, 20);
            this.txtMUID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMUDelete);
            this.groupBox2.Controls.Add(this.btnMUCancel);
            this.groupBox2.Controls.Add(this.btnMUUpdate);
            this.groupBox2.Controls.Add(this.btnMUSave);
            this.groupBox2.Controls.Add(this.btnMUInsert);
            this.groupBox2.Location = new System.Drawing.Point(522, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnMUDelete
            // 
            this.btnMUDelete.Location = new System.Drawing.Point(33, 103);
            this.btnMUDelete.Name = "btnMUDelete";
            this.btnMUDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMUDelete.TabIndex = 4;
            this.btnMUDelete.Text = "Delete";
            this.btnMUDelete.UseVisualStyleBackColor = true;
            // 
            // btnMUCancel
            // 
            this.btnMUCancel.Location = new System.Drawing.Point(152, 67);
            this.btnMUCancel.Name = "btnMUCancel";
            this.btnMUCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMUCancel.TabIndex = 3;
            this.btnMUCancel.Text = "Cancel";
            this.btnMUCancel.UseVisualStyleBackColor = true;
            this.btnMUCancel.Click += new System.EventHandler(this.btnMUCancel_Click);
            // 
            // btnMUUpdate
            // 
            this.btnMUUpdate.Location = new System.Drawing.Point(33, 67);
            this.btnMUUpdate.Name = "btnMUUpdate";
            this.btnMUUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMUUpdate.TabIndex = 2;
            this.btnMUUpdate.Text = "Update";
            this.btnMUUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMUSave
            // 
            this.btnMUSave.Location = new System.Drawing.Point(152, 27);
            this.btnMUSave.Name = "btnMUSave";
            this.btnMUSave.Size = new System.Drawing.Size(75, 23);
            this.btnMUSave.TabIndex = 1;
            this.btnMUSave.Text = "Save";
            this.btnMUSave.UseVisualStyleBackColor = true;
            // 
            // btnMUInsert
            // 
            this.btnMUInsert.Location = new System.Drawing.Point(32, 27);
            this.btnMUInsert.Name = "btnMUInsert";
            this.btnMUInsert.Size = new System.Drawing.Size(75, 23);
            this.btnMUInsert.TabIndex = 0;
            this.btnMUInsert.Text = "Insert";
            this.btnMUInsert.UseVisualStyleBackColor = true;
            // 
            // Master_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(789, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Master_User";
            this.Text = "Master_User";
            this.Load += new System.EventHandler(this.Master_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMUGender;
        private System.Windows.Forms.TextBox txtMUPassword;
        private System.Windows.Forms.TextBox txtMUEmail;
        private System.Windows.Forms.TextBox txtMUName;
        private System.Windows.Forms.TextBox txtMUID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMUAddress;
        private System.Windows.Forms.TextBox txtMUPhone;
        private System.Windows.Forms.ComboBox cmbMURole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMUDelete;
        private System.Windows.Forms.Button btnMUCancel;
        private System.Windows.Forms.Button btnMUUpdate;
        private System.Windows.Forms.Button btnMUSave;
        private System.Windows.Forms.Button btnMUInsert;
    }
}