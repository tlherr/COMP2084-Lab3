using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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



    }
}