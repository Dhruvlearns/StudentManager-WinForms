using System;
using System.Windows.Forms;
using newstudent;

namespace student
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (student_registrationEntities context = new student_registrationEntities())
            {
                // Create a new student entity
                var student = new Student
                {
                    Name = textBox1.Text,
                    Gender = textBox2.Text,
                    Mobile = textBox5.Text,
                    Email = textBox4.Text,
                    Address = textBox3.Text,
                    Course = textBox6.Text
                };

                // Add the student entity to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                // Optionally, display a message to the user
                MessageBox.Show("Student registered successfully!");
            }
        }
    }
}
