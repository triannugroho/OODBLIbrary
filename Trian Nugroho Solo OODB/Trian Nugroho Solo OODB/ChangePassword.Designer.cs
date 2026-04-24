namespace Trian_Nugroho_Solo_OODB
{
    partial class ChangePassword
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
            this.txtCPConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtCPNewPassword = new System.Windows.Forms.TextBox();
            this.txtCPPassword = new System.Windows.Forms.TextBox();
            this.btnCPChangePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCPConfirmPassword
            // 
            this.txtCPConfirmPassword.Location = new System.Drawing.Point(57, 126);
            this.txtCPConfirmPassword.Name = "txtCPConfirmPassword";
            this.txtCPConfirmPassword.Size = new System.Drawing.Size(155, 20);
            this.txtCPConfirmPassword.TabIndex = 13;
            // 
            // txtCPNewPassword
            // 
            this.txtCPNewPassword.Location = new System.Drawing.Point(57, 87);
            this.txtCPNewPassword.Name = "txtCPNewPassword";
            this.txtCPNewPassword.Size = new System.Drawing.Size(155, 20);
            this.txtCPNewPassword.TabIndex = 12;
            // 
            // txtCPPassword
            // 
            this.txtCPPassword.Location = new System.Drawing.Point(57, 48);
            this.txtCPPassword.Name = "txtCPPassword";
            this.txtCPPassword.Size = new System.Drawing.Size(155, 20);
            this.txtCPPassword.TabIndex = 11;
            // 
            // btnCPChangePassword
            // 
            this.btnCPChangePassword.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCPChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPChangePassword.Location = new System.Drawing.Point(70, 152);
            this.btnCPChangePassword.Name = "btnCPChangePassword";
            this.btnCPChangePassword.Size = new System.Drawing.Size(132, 40);
            this.btnCPChangePassword.TabIndex = 10;
            this.btnCPChangePassword.Text = "Change Password";
            this.btnCPChangePassword.UseVisualStyleBackColor = false;
            this.btnCPChangePassword.Click += new System.EventHandler(this.btnCPChangePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.txtCPConfirmPassword);
            this.Controls.Add(this.txtCPNewPassword);
            this.Controls.Add(this.txtCPPassword);
            this.Controls.Add(this.btnCPChangePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCPConfirmPassword;
        private System.Windows.Forms.TextBox txtCPNewPassword;
        private System.Windows.Forms.TextBox txtCPPassword;
        private System.Windows.Forms.Button btnCPChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}