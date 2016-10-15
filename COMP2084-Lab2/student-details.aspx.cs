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

        }

        /**
         * Save Button Was Clicked
         */
        protected void btnSave_Click(object sender, EventArgs e)
        {
            var connection = new StudentEntities();

            Student s = new Student();

            s.FirstMidName = txtFirstName.Text;
            s.LastName = txtLastName.Text;
            s.EnrollmentDate = DateTime.Parse(txtEnrollmentDate.Text);

            //Save to DB
            connection.Students.Add(s);
            connection.SaveChanges();

            //Redirect
            Response.Redirect("students.aspx");
        }
    }
}