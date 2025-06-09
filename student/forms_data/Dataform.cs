using DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace forms_data
{
    public partial class Form1 : Form
    {
       


        public class StudentCourseInfo
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Mobile { get; set; }
            public string Gender { get; set; }
            public string EnrollmentNumber { get; set; }
            public string CourseName { get; set; }
        }


        List<StudentCourseInfo> listOfStudentInformation = new List<StudentCourseInfo>();


        public Form1()
        {
            InitializeComponent();
        }

      
private void GetStudentRecord()
{
    try
    {
        using (var context = new StudentEntities_new())
        {
            // Fetch students and join with courses based on CourseID
            var studentCourseData = from student in context.Student_information
                                    join course in context.courses on student.Courseid equals course.Courseid
                                    select new StudentCourseInfo
                                    {
                                        Id = student.Id,
                                        Name = student.Name,
                                        Address = student.Address,
                                        Mobile = student.Mobile,
                                        Gender = student.Gender,
                                        EnrollmentNumber = student.EnrollmentNumber,
                                        CourseName = course.Coursename  // Bind the CourseName to the new class property
                                    };
                    listOfStudentInformation = studentCourseData.ToList(); // can we comment it ?
                    // Convert the result to a list and bind it to the DataGridView
                    dataGridView1.DataSource = listOfStudentInformation;
                }

            }
    catch (Exception ex)
    {
        MessageBox.Show("An error occurred while retrieving student and course records: " + ex.Message);
    }
}

        

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
           



        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmstudentregistration stu = new frmstudentregistration();
            //stu.ShowDialog();
            if (stu.ShowDialog() == DialogResult.OK)
            {
                GetStudentRecord();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {   // suppose u have selcted student in a datagird view abd the user can edit the field
            try
            {
                //Student_information selectedStudent = (Student_information)dataGridView1.SelectedRows[0].DataBoundItem;
                int index = dataGridView1.SelectedRows[0].Index;

                if (index>=0)
                {
                    frmstudentregistration stu = new frmstudentregistration();
                    stu.m_bIsedit = true;
                    stu.studentId = listOfStudentInformation[index].Id;

                    if (stu.ShowDialog() == DialogResult.OK)
                    {
                        GetStudentRecord();
                    }
                }
                else
                {
                    MessageBox.Show("please fill all the details");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured while editing " + ex.Message);
            }


        }
        // deleting using index
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }

                // Get the index of the selected row
                int index = dataGridView1.SelectedRows[0].Index;

                // Check if the index is valid
                if (index >= 0 && index < listOfStudentInformation.Count)
                {
                    // Get the selected student using the index
                    var selectedStudent = listOfStudentInformation[index];

                    // Confirm the deletion of the student record
                    var confirmationResult = MessageBox.Show(
                        "Are you sure you want to delete this student record?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // If the user confirms the deletion
                    if (confirmationResult == DialogResult.Yes)
                    {
                        using (var context = new StudentEntities_new())
                        {
                            // Retrieve the student from the database based on Id
                            var studentToDelete = context.Student_information
                                                         .FirstOrDefault(s => s.Id == selectedStudent.Id);

                            if (studentToDelete != null)
                            {
                                // Remove the student from the DbSet
                                context.Student_information.Remove(studentToDelete);
                                // Save the changes to the database
                                int deleteCount = context.SaveChanges();
                                if (deleteCount > 0)
                                {
                                    MessageBox.Show("Student record deleted successfully!");
                                    GetStudentRecord(); // Refresh DataGridView to reflect changes
                                }
                            }
                            else
                            {
                                MessageBox.Show("The selected student could not be found in the database.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student selected for deletion.");
                }
            }
            catch (Exception ex)
            {
                // Log or display a more detailed error message
                MessageBox.Show($"An error occurred while deleting the student: {ex.Message}\n{ex.StackTrace}");
            }
        }



        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem;

        //        if (selectedStudent != null)
        //        {
        //            //confirm he deletion of the user
        //            var confirmationResult = MessageBox.Show(
        //                "Are you sure you want to delete this student record?",
        //                "Confirm Deletion",
        //                MessageBoxButtons.YesNo,
        //                MessageBoxIcon.Warning
        //            );
        //            //if the user confirms deletion
        //            if (confirmationResult == DialogResult.Yes)
        //            {
        //                using (var context = new StudentEntities_new())
        //                {
        //                    //retreive the student from the database based on id 
        //                    var studentToDelete = context.Student_information
        //                                                  .FirstOrDefault(s => s.Id == selectedStudent.Id);

        //                    if (studentToDelete != null)
        //                    {
        //                        //remove the student from the dbset
        //                        context.Student_information.Remove(studentToDelete);
        //                        //save the changes to the db
        //                        int deleteCount = context.SaveChanges();
        //                        if (deleteCount > 0)
        //                        {
        //                            MessageBox.Show("Student record deleted successfully!");
        //                            GetStudentRecord(); // Refresh DataGridView to reflect changes
        //                        }


        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select a student to delete.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while deleting the student: " + ex.Message);
        //    }

        //}

        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Check if any row is selected in the DataGridView
        //        if (dataGridView1.SelectedRows.Count == 0)
        //        {
        //            MessageBox.Show("Please select a student to delete.");
        //            return; // Exit if no row is selected
        //        }

        //        // Debugging: Check if the selected row is valid
        //        var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem as Student_information;
        //        if (selectedStudent == null)
        //        {
        //            MessageBox.Show("The selected row does not contain valid student data.");
        //            return; // Exit if DataBoundItem is null
        //        }

        //        // Confirm deletion of the student
        //        var confirmationResult = MessageBox.Show(
        //            "Are you sure you want to delete this student record?",
        //            "Confirm Deletion",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning
        //        );

        //        // Proceed with deletion if the user confirms
        //        if (confirmationResult == DialogResult.Yes)
        //        {
        //            using (var context = new StudentEntities_new())
        //            {
        //                // Retrieve the student from the database based on ID
        //                var studentToDelete = context.Student_information
        //                                             .FirstOrDefault(s => s.Id == selectedStudent.Id);

        //                if (studentToDelete != null)
        //                {
        //                    // Remove the student from the DbSet
        //                    context.Student_information.Remove(studentToDelete);

        //                    // Save the changes to the database
        //                    int deleteCount = context.SaveChanges();

        //                    if (deleteCount > 0)
        //                    {
        //                        MessageBox.Show("Student record deleted successfully!");
        //                        RefreshDataGridView();  // Refresh DataGridView to reflect changes
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No records were deleted. Please try again.");
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("The student record could not be found.");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while deleting the student: " + ex.Message);
        //    }
        //}




    }
}
