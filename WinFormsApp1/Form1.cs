using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateProgressBar()
        {
            formProgressBar.Value = 0;

            if (fieldFirstName.Text.Length > 0)
            {
                formProgressBar.Value += 1;
            }
            if (fieldLastName.Text.Length > 0)
            {
                formProgressBar.Value += 1;
            }
            if (radioFemale.Checked || radioMale.Checked) formProgressBar.Value += 1;
            if (!fieldProgram.Text.Equals("")) formProgressBar.Value += 1;
            if (!ageLabel.Text.Equals("")) formProgressBar.Value += 1;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - fieldBirthDate.Value.Year;
            ageLabel.Text = age.ToString();
            UpdateProgressBar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine($"Full Name: {fieldFirstName.Text} {fieldLastName.Text}");
            Console.WriteLine($"Birthdate: {fieldBirthDate.Text}");

            DateTime today = DateTime.Now;
            int age = today.Year - fieldBirthDate.Value.Year;
            Console.WriteLine($"Age: {age}");
            if (radioFemale.Checked) {
                Console.WriteLine("Sex: Female");
            } else if (radioMale.Checked)
            {
                Console.WriteLine("Sex: Male");
            }

            Console.WriteLine($"Program: {fieldProgram.SelectedItem}");

            List<String> hobbies = new List<String>(); 
            foreach (Control hobby in groupBox1.Controls)
            {
                if (hobby is CheckBox krom && krom.Checked)
                {
                    hobbies.Add(krom.Text);
                }
            }

            Console.WriteLine($"Hobbies: {String.Join(",", hobbies)}");
            dataGridStudents.Rows.Add(fieldFirstName.Text, fieldBirthDate.Text);
        }

        private void fieldFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();

        }

        private void fieldLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void fieldProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String selectedFilePath = openFileDialog1.FileName;
                photoStudent.Image = Image.FromFile(selectedFilePath);
            }
            UpdateProgressBar();
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }
    }
}
