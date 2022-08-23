namespace Fast_Food_Proj
{
    partial class CUSTOMER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUSTOMER));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CUS_ID = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Lname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Fname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Mname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CUS_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(343, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 164);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // CUS_ID
            // 
            this.CUS_ID.Location = new System.Drawing.Point(3, 3);
            this.CUS_ID.Name = "CUS_ID";
            this.CUS_ID.Size = new System.Drawing.Size(153, 22);
            this.CUS_ID.TabIndex = 0;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(165, 85);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(154, 22);
            this.Lname.TabIndex = 3;
            // 
            // Mname
            // 
            this.Mname.Location = new System.Drawing.Point(3, 85);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(153, 22);
            this.Mname.TabIndex = 2;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(165, 3);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(153, 22);
            this.Fname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "MIDDLE NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "LAST NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CUSTOMER ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(512, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 47;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 48;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 45;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 264);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CUSTOMER";
            this.Text = "CUSTOMER";
            this.Load += new System.EventHandler(this.CUSTOMER_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CUS_ID;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}