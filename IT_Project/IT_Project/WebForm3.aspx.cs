using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Project
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblUsername.Text = WebForm1.username;
        }
        public void disp_data()
        {

            SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select* from [dbo].[superuserregister]", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //gridview.DataSource = dt;
            //gridview.DataBind();
            con.Close();

        }
        public string SelectFromSQLDB(string queryString1, out string SelectResults)
        {

            SelectResults = "";
            SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
            SqlCommand dbCommand = new SqlCommand(queryString1);
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Connection = con;
            con.Open();

            SelectResults = Convert.ToString(dbCommand.ExecuteScalar());
            // Data is accessible through the DataReader object here.
            con.Close();
            return SelectResults;

        }
            protected void BtnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");

            //con.Open();
            //SqlCommand cmd = new SqlCommand("select Username,Password from superuserregister ", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //con.Close();

            //string SelectResultFromDB = "";
            //string SelectResult = "";

            //string SeletQString = "SELECT Username FROM superuserregister WHERE superuserregister.Username = '" + TxtUsername.Text + "'";
            //string SeleQString = "SELECT Password FROM superuserregister WHERE superuserregister.password = '" + TxtPassword.Text + "'";

            //SelectFromSQLDB(SeletQString, out SelectResultFromDB);
            //SelectFromSQLDB(SeleQString, out SelectResult);

            //if (SelectResultFromDB == TxtUsername.Text)
            //{
            //    if (SelectResult == TxtPassword.Text)
            //    {
            //        Response.Write("Username and Password is correct");

            //        Response.Redirect("Dashboard.aspx");

            //    }


            //    else
            //    {
            //        Response.Write("password  is incorrect");

            //    }



            //else
            //    {
            //        Response.Write("username is incorrect");

            //    }
            //}

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperUserRegister.aspx");
        }
     
        protected void btnInt_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Form4Cust2.aspx");

        }
    }
}
