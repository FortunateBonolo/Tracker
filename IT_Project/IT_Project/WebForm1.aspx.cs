using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using System.Collections;
using System.Data;

namespace IT_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        internal static string username;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select Username,Password from superuserregister ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            con.Close();

            string SelectResultFromDB = "";
            string SelectResult = "";

            string SeletQString = "SELECT Username FROM superuserregister WHERE superuserregister.Username = '" + TxtUsername.Text + "'";
            string SeleQString = "SELECT Password FROM superuserregister WHERE superuserregister.password = '" + TxtPassword.Text + "'";
            //string SeletQStr = "SELECT Username,Password FROM superuserregister WHERE superuserregister.UserType = '" + drbUserType.Text + "'";

            SelectFromSQLDB(SeletQString, out SelectResultFromDB);
            SelectFromSQLDB(SeleQString, out SelectResult);

            if (SelectResultFromDB == TxtUsername.Text)
            {
                if (SelectResult == TxtPassword.Text)
                {
                    Response.Write("Username and Password is correct");

                    Response.Redirect("WebForm3.aspx");


                }
                else
                {
                    Response.Write("password  is incorrect");

                }

            }
            else
            {
                Response.Write("username is incorrect");

            }


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
    }
}