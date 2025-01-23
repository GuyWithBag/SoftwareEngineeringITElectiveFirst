
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoStudent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.formProgressBar = new System.Windows.Forms.ProgressBar();
            this.fieldLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.fieldBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.fieldProgram = new System.Windows.Forms.ComboBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoStudent
            // 
            this.photoStudent.Location = new System.Drawing.Point(31, 57);
            this.photoStudent.Name = "photoStudent";
            this.photoStudent.Size = new System.Drawing.Size(121, 113);
            this.photoStudent.TabIndex = 0;
            this.photoStudent.TabStop = false;
            this.photoStudent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // fieldFirstName
            // 
            this.fieldFirstName.Location = new System.Drawing.Point(209, 75);
            this.fieldFirstName.Name = "fieldFirstName";
            this.fieldFirstName.Size = new System.Drawing.Size(124, 23);
            this.fieldFirstName.TabIndex = 2;
            this.fieldFirstName.TextChanged += new System.EventHandler(this.fieldFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Program";
            // 
            // formProgressBar
            // 
            this.formProgressBar.Location = new System.Drawing.Point(31, 12);
            this.formProgressBar.Maximum = 5;
            this.formProgressBar.Name = "formProgressBar";
            this.formProgressBar.Size = new System.Drawing.Size(745, 23);
            this.formProgressBar.Step = 1;
            this.formProgressBar.TabIndex = 8;
            // 
            // fieldLastName
            // 
            this.fieldLastName.Location = new System.Drawing.Point(364, 75);
            this.fieldLastName.Name = "fieldLastName";
            this.fieldLastName.Size = new System.Drawing.Size(124, 23);
            this.fieldLastName.TabIndex = 10;
            this.fieldLastName.TextChanged += new System.EventHandler(this.fieldLastName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(209, 358);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(279, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save Student Information";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Reading Books";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 19);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Watching Anime";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(137, 19);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Playing Video Games";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(16, 97);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 19);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Fishing";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // fieldBirthDate
            // 
            this.fieldBirthDate.Location = new System.Drawing.Point(209, 134);
            this.fieldBirthDate.Name = "fieldBirthDate";
            this.fieldBirthDate.Size = new System.Drawing.Size(200, 23);
            this.fieldBirthDate.TabIndex = 16;
            this.fieldBirthDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 17;
            // 
            // fieldProgram
            // 
            this.fieldProgram.FormattingEnabled = true;
            this.fieldProgram.Items.AddRange(new object[] {
            "Information Technology",
            "Computer Science"});
            this.fieldProgram.Location = new System.Drawing.Point(209, 242);
            this.fieldProgram.Name = "fieldProgram";
            this.fieldProgram.Size = new System.Drawing.Size(121, 23);
            this.fieldProgram.TabIndex = 18;
            this.fieldProgram.SelectedIndexChanged += new System.EventHandler(this.fieldProgram_SelectedIndexChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(15, 22);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(51, 19);
            this.radioMale.TabIndex = 19;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(72, 22);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(63, 19);
            this.radioFemale.TabIndex = 20;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Location = new System.Drawing.Point(31, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What are your hobbies?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.BirthDate});
            this.dataGridStudents.Location = new System.Drawing.Point(20, 396);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowTemplate.Height = 25;
            this.dataGridStudents.Size = new System.Drawing.Size(756, 150);
            this.dataGridStudents.TabIndex = 22;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFemale);
            this.groupBox2.Controls.Add(this.radioMale);
            this.groupBox2.Location = new System.Drawing.Point(209, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 52);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sex";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(450, 140);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 15);
            this.ageLabel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fieldProgram);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fieldBirthDate);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.fieldLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.formProgressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.photoStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fieldFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar formProgressBar;
        private System.Windows.Forms.TextBox fieldLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DateTimePicker fieldBirthDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fieldProgram;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ageLabel;
    }
}

