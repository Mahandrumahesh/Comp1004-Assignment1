namespace assignment1
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.EmployeeName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.employeeId = new System.Windows.Forms.Label();
            this.hoursWorked = new System.Windows.Forms.Label();
            this.totalSales = new System.Windows.Forms.Label();
            this.salesBonus = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.english = new System.Windows.Forms.RadioButton();
            this.french = new System.Windows.Forms.RadioButton();
            this.spanish = new System.Windows.Forms.RadioButton();
            this.languages = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(35, 113);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeName.Size = new System.Drawing.Size(114, 18);
            this.EmployeeName.TabIndex = 0;
            this.EmployeeName.Text = "EmployeeName";
            this.EmployeeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 1;
            // 
            // employeeId
            // 
            this.employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeId.Location = new System.Drawing.Point(50, 152);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(142, 20);
            this.employeeId.TabIndex = 2;
            this.employeeId.Text = "Employee ID :";
            this.employeeId.Click += new System.EventHandler(this.label2_Click);
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSize = true;
            this.hoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorked.Location = new System.Drawing.Point(47, 210);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(114, 18);
            this.hoursWorked.TabIndex = 3;
            this.hoursWorked.Text = "Hours Worked :";
            this.hoursWorked.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalSales
            // 
            this.totalSales.AutoSize = true;
            this.totalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSales.Location = new System.Drawing.Point(71, 246);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(90, 18);
            this.totalSales.TabIndex = 4;
            this.totalSales.Text = "Total Sales :";
            this.totalSales.Click += new System.EventHandler(this.label4_Click);
            // 
            // salesBonus
            // 
            this.salesBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBonus.Location = new System.Drawing.Point(35, 275);
            this.salesBonus.Name = "salesBonus";
            this.salesBonus.Size = new System.Drawing.Size(201, 24);
            this.salesBonus.TabIndex = 2;
            this.salesBonus.Text = "      Sales bonus : ";
            this.salesBonus.Click += new System.EventHandler(this.label5_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(31, 319);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 27);
            this.Calculate.TabIndex = 6;
            this.Calculate.Tag = "calculate";
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.salesCalculation);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(188, 319);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 27);
            this.print.TabIndex = 7;
            this.print.Tag = "print";
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(339, 319);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 27);
            this.clear.TabIndex = 8;
            this.clear.Tag = "clear";
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(242, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(242, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(167, 20);
            this.textBox5.TabIndex = 12;
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Checked = true;
            this.english.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.english.Location = new System.Drawing.Point(6, 20);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(70, 20);
            this.english.TabIndex = 13;
            this.english.TabStop = true;
            this.english.Tag = "english";
            this.english.Text = "English";
            this.english.UseVisualStyleBackColor = true;
            this.english.CheckedChanged += new System.EventHandler(this.Languagetranslate);
            // 
            // french
            // 
            this.french.AutoSize = true;
            this.french.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.french.Location = new System.Drawing.Point(6, 42);
            this.french.Name = "french";
            this.french.Size = new System.Drawing.Size(78, 20);
            this.french.TabIndex = 14;
            this.french.Tag = "french";
            this.french.Text = "Français";
            this.french.UseVisualStyleBackColor = true;
            this.french.CheckedChanged += new System.EventHandler(this.Languagetranslate);
            // 
            // spanish
            // 
            this.spanish.AutoSize = true;
            this.spanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spanish.Location = new System.Drawing.Point(6, 67);
            this.spanish.Name = "spanish";
            this.spanish.Size = new System.Drawing.Size(76, 20);
            this.spanish.TabIndex = 15;
            this.spanish.Tag = "spanish";
            this.spanish.Text = "Español\r\n";
            this.spanish.UseVisualStyleBackColor = true;
            this.spanish.CheckedChanged += new System.EventHandler(this.Languagetranslate);
            // 
            // languages
            // 
            this.languages.Controls.Add(this.english);
            this.languages.Controls.Add(this.spanish);
            this.languages.Controls.Add(this.french);
            this.languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languages.Location = new System.Drawing.Point(276, 12);
            this.languages.Name = "languages";
            this.languages.Size = new System.Drawing.Size(174, 93);
            this.languages.TabIndex = 16;
            this.languages.TabStop = false;
            this.languages.Text = "Languages";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MailOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(493, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.languages);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.print);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.salesBonus);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmployeeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.languages.ResumeLayout(false);
            this.languages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label employeeId;
        private System.Windows.Forms.Label hoursWorked;
        private System.Windows.Forms.Label totalSales;
        private System.Windows.Forms.Label salesBonus;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton english;
        private System.Windows.Forms.RadioButton french;
        private System.Windows.Forms.RadioButton spanish;
        private System.Windows.Forms.GroupBox languages;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

