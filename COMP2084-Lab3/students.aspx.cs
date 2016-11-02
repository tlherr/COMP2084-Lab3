using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.ModelBinding;

namespace COMP2084_Lab2
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getStudents();
        }

        protected void getStudents()
        {
            var connection = new StudentEntities();
            var Students = from d in connection.Students select d;

            //Save to DB
            gridStudents.DataSource = Students.ToList();
            gridStudents.DataBind();
        }

        protected void gridStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Int32 gridIndex = e.RowIndex;
            Int32 StudentID = Convert.ToInt32(gridStudents.DataKeys[gridIndex].Value);
            var conn = new StudentEntities();

            Student s = new Student();
            s.StudentID = StudentID;
            conn.Students.Attach(s);
            conn.Students.Remove(s);
            conn.SaveChanges();

            getStudents();
        }
    }
}