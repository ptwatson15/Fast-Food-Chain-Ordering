namespace Fast_Food_Proj
{
    partial class MENU
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Menu_Id = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Food = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(501, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 11;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(420, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 10;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(582, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 32);
            this.button7.TabIndex = 12;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(336, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Menu_Id, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Category, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Price, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Food, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 50);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Menu_Id
            // 
            this.Menu_Id.Location = new System.Drawing.Point(3, 3);
            this.Menu_Id.Name = "Menu_Id";
            this.Menu_Id.Size = new System.Drawing.Size(153, 22);
            this.Menu_Id.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(483, 3);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(154, 22);
            this.Category.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(323, 3);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(153, 22);
            this.Price.TabIndex = 2;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(163, 3);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(153, 22);
            this.Food.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "MENU ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "FOOD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "PRICE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "CATEGORY";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 177);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MENU";
            this.Text = "MENU";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Menu_Id;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Food;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}