namespace Trian_Nugroho_Solo_OODB
{
    partial class Buy_Book
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBAddtoCart = new System.Windows.Forms.Button();
            this.txtBQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBCheckOut = new System.Windows.Forms.Button();
            this.btnBDeleteFrom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TR003";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cart";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(484, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBAddtoCart);
            this.groupBox1.Controls.Add(this.txtBQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(505, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // btnBAddtoCart
            // 
            this.btnBAddtoCart.Location = new System.Drawing.Point(134, 66);
            this.btnBAddtoCart.Name = "btnBAddtoCart";
            this.btnBAddtoCart.Size = new System.Drawing.Size(75, 23);
            this.btnBAddtoCart.TabIndex = 2;
            this.btnBAddtoCart.Text = "Add to Cart";
            this.btnBAddtoCart.UseVisualStyleBackColor = true;
            this.btnBAddtoCart.Click += new System.EventHandler(this.btnBAddtoCart_Click);
            // 
            // txtBQuantity
            // 
            this.txtBQuantity.Location = new System.Drawing.Point(87, 40);
            this.txtBQuantity.Name = "txtBQuantity";
            this.txtBQuantity.Size = new System.Drawing.Size(166, 20);
            this.txtBQuantity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBCheckOut);
            this.groupBox2.Controls.Add(this.btnBDeleteFrom);
            this.groupBox2.Location = new System.Drawing.Point(505, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnBCheckOut
            // 
            this.btnBCheckOut.Location = new System.Drawing.Point(134, 79);
            this.btnBCheckOut.Name = "btnBCheckOut";
            this.btnBCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnBCheckOut.TabIndex = 1;
            this.btnBCheckOut.Text = "Check Out";
            this.btnBCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnBDeleteFrom
            // 
            this.btnBDeleteFrom.Location = new System.Drawing.Point(134, 39);
            this.btnBDeleteFrom.Name = "btnBDeleteFrom";
            this.btnBDeleteFrom.Size = new System.Drawing.Size(75, 23);
            this.btnBDeleteFrom.TabIndex = 0;
            this.btnBDeleteFrom.Text = "Delete from Cart";
            this.btnBDeleteFrom.UseVisualStyleBackColor = true;
            this.btnBDeleteFrom.Click += new System.EventHandler(this.btnBDeleteFrom_Click);
            // 
            // Buy_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(776, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Buy_Book";
            this.Text = "Buy_Book";
            this.Load += new System.EventHandler(this.Buy_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBAddtoCart;
        private System.Windows.Forms.TextBox txtBQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBCheckOut;
        private System.Windows.Forms.Button btnBDeleteFrom;
    }
}