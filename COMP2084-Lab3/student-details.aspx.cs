using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2084_Lab2
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false && !String.IsNullOrEmpty(Request.QueryString["StudentID"]))
            {
                bindStudentForm(Convert.ToInt32(Request.QueryString["StudentID"]));
            }
        }

        /**
         * Save Button Was Clicked
         */
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Int32 StudentID = 0;

            if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
            {
                StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            }

            var connection = new StudentEntities();

            Student s = new Student();

            s.FirstMidName = txtFirstName.Text;
            s.LastName = txtLastName.Text;
            s.EnrollmentDate = DateTime.Parse(txtEnrollmentDate.Text);

            if (StudentID == 0)
            {
                connection.Students.Add(s);
            } else
            {
                s.StudentID = StudentID;
                connection.Students.Attach(s);
                connection.Entry(s).State = System.Data.Entity.EntityState.Modified;
            }

            //Save to DB
            connection.SaveChanges();

            //Redirect
            Response.Redirect("students.aspx");
        }

        protected void bindStudentForm(Int32 StudentID)
        {
            var connection = new StudentEntities();

            Student student = (from d in connection.Students
                          where d.StudentID == StudentID
                          select d).FirstOrDefault();

            txtFirstName.Text = student.FirstMidName;
            txtLastName.Text = student.LastName;
            txtEnrollmentDate.Text = student.EnrollmentDate.ToString("yyyy-MM-dd");
        }
    }
}