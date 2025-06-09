using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBContext;
using Microsoft.VisualBasic.Devices;

//using Context_DB;
//using newstudent;


namespace forms_data
{
    public partial class frmstudentregistration : Form
    {
        public Guid studentId = new Guid();
        public Guid courseId { get; set; }
        public bool m_bIsedit = false;
        public frmstudentregistration()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle picture box click event if needed
        }

        private void lbladdress_Load(object sender, EventArgs e)
        {
            // Handle label load event if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }


        private void lblsubmit_Click(object sender, EventArgs e)
        {
            try
            {   // Basic validation: Check if all fields are filled
                if (string.IsNullOrEmpty(txbname.Text) || string.IsNullOrEmpty(txbaddress.Text) || string.IsNullOrEmpty(txbmobile.Text) || string.IsNullOrEmpty(txbgender.Text) || string.IsNullOrEmpty(comboBoxCourses.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                if (m_bIsedit)
                {
                    using (StudentEntities_new entities = new StudentEntities_new())
                    {
                        // retrieving thw student existing data by its id
                        var studenttoedit = entities.Student_information.FirstOrDefault(s => s.Id == studentId);
                        if (studenttoedit != null)
                        {
                            //update the student details form the values from the textboxes
                            studenttoedit.Name = txbname.Text;
                            studenttoedit.Address = txbaddress.Text;
                            studenttoedit.Mobile = txbmobile.Text;
                            studenttoedit.Courseid = Convert.ToInt32(comboBoxCourses.SelectedValue);
                            studenttoedit.Gender = txbgender.Text;

                            //save the changes to the database
                            int update = entities.SaveChanges();
                            MessageBox.Show("student reocrd updated successfully " + update);

                        }
                        else
                        {
                            MessageBox.Show("student record does not exist ");
                        }
                    }

                }
                else
                {//IF NOT EDTING ,THEN ITS A NEW STUDENT REGISTRATION
                    using (
                   StudentEntities_new entities = new StudentEntities_new())

                    {

                        Student_information data = new Student_information();
                        data.Name = txbname.Text;
                        data.Address = txbaddress.Text;
                        data.Mobile = txbmobile.Text;
                        data.Courseid = Convert.ToInt32(comboBoxCourses.SelectedValue);
                        data.Gender = txbgender.Text;
                        data.Id = Guid.NewGuid(); //ASSIGN A NEW GUID FOR THE NEW STUDENT


                        //ADD THE NEW STUDENT DATA TO THE DB
                        entities.Student_information.Add(data);


                        //SAVE THE NEW STUDENT TO THE DATBASE
                        int update = entities.SaveChanges();
                        MessageBox.Show("Student registered successfully! " + update);

                    }
                }


            }
            catch (Exception ex)
            {
                // Handle any errors that might occur (e.g., database issues)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        


        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void txbid_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void txbname_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed

        }

        private void txbgender_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
            string input = txbgender.Text.ToUpper();

            if(input !="M" && input != "F")
            {
                txbgender.Text = "";// clear the invalid input
                MessageBox.Show("please enter 'M' or 'F' ");
            }
        }

        private void txbmobile_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void txbaddress_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void txbcourse_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void frmstudentregistration_Load(object sender, EventArgs e)
        {

            if (studentId != null)
            { //updating the records with new values
                using (StudentEntities_new entities = new StudentEntities_new())
                {
                    var student = entities.Student_information.FirstOrDefault(s => s.Id == studentId);
                    if (student != null)
                    {
                        txbname.Text = student.Name;
                        txbaddress.Text = student.Address;
                        txbmobile.Text = student.Mobile;
                        txbgender.Text = student.Gender;
                        LoadCourses();
                    }
                }
               
            }

        }
        //private void LoadCourses()
        //{
        //    using (var context = new StudentEntities_new())
        //    {
        //        var courses = context.courses.ToList(); // You can also use ToBindingList() here for automatic binding support.
        //        comboBoxCourses.DataSource = new BindingList<cours>(courses); // BindingList provides better support for data binding in WinForms


        //        comboBoxCourses.DataSource = courses;
        //        comboBoxCourses.DisplayMember = "Coursename";  // Column name that you want to display
        //        comboBoxCourses.ValueMember = "Courseid";

        //        // If you want to set the current course selected (if this is an update scenario)
        //        if (context.courses != null)
        //        //if (stuinfo != null && stuinfo.Courseid != 0)
        //        {
        //            // Set the selected index based on the CourseID
        //            comboBoxCourses.SelectedValue = courseId; // Assuming stuinfo has a CourseID field
        //        }
        //    }
        //}
        private void LoadCourses()
        {
            using (var context = new StudentEntities_new())
            {
                var courses = context.courses.ToList(); // Fetch the courses from the database

                if (courses != null && courses.Count > 0)
                {
                    comboBoxCourses.DataSource = new BindingList<cours>(courses); // Bind the courses to the ComboBox
                    comboBoxCourses.DisplayMember = "Coursename";  // Column name to display
                    comboBoxCourses.ValueMember = "Courseid";      // Column name for value

                    // If you want to set the current course selected (if this is an update scenario)
                    if (courseId != Guid.Empty)
                    {
                        comboBoxCourses.SelectedValue = courseId; // Set the selected value based on courseId
                    }
                }
                else
                {
                    MessageBox.Show("No courses available.");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow the digit from (0-9)

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')

            {
                e.Handled = true;
            }
        }

        private void txbaddress_MultilineChanged(object sender, EventArgs e)
        {

        }
    }
}
