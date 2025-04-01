namespace Student_Registration
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtcourse = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.registor = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(189, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(271, 26);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(271, 68);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(100, 20);
            this.txtsurname.TabIndex = 3;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(189, 71);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(55, 13);
            this.surname.TabIndex = 2;
            this.surname.Text = "Surname :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(271, 110);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 5;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(189, 113);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 13);
            this.email.TabIndex = 4;
            this.email.Text = "Email : ";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(189, 150);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(46, 13);
            this.course.TabIndex = 6;
            this.course.Text = "Course :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtcourse
            // 
            this.txtcourse.FormattingEnabled = true;
            this.txtcourse.Items.AddRange(new object[] {
            "Select Course",
            "MSc-CS",
            "MCA",
            "BSc-CS",
            "BCS"});
            this.txtcourse.Location = new System.Drawing.Point(271, 150);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(100, 21);
            this.txtcourse.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(271, 200);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(376, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(480, 200);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Other";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender :";
            // 
            // registor
            // 
            this.registor.Location = new System.Drawing.Point(260, 305);
            this.registor.Name = "registor";
            this.registor.Size = new System.Drawing.Size(75, 23);
            this.registor.TabIndex = 13;
            this.registor.Text = "Registor ";
            this.registor.UseVisualStyleBackColor = true;
            this.registor.Click += new System.EventHandler(this.registor_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(446, 305);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 490);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.registor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.course);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Studend Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox txtcourse;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registor;
        private System.Windows.Forms.Button clear;
    }
}

