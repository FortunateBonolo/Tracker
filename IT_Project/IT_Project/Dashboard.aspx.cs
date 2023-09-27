using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Project
{
    public partial class Dashboard : System.Web.UI.Page
    {

        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //    GRVInfo.DataSource = dt;
        //    GRVInfo.DataBind();
        SqlConnection conn = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            if (Session["user"] == null)
            {
                Response.Redirect("");
            }
            else
                conn.ConnectionString = "Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True";
            conn.Open();
            showdata();



        }
        public void showdata()
        {
            
            //cmd.CommandText = "Select firstname,lastname,user_type,create_date,create_by,activity from superuserregister where username=@username";
            //cmd.Connection = con;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select firstname,lastname,user_type,create_date,create_by,activity from superuserregister where username=@username";
            //sda.SelectCommand = cmd;
            //sda.fill(ds);
            
        }
        public void display()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select firstname,lastname,user_type,create_date,create_by,activity from superuserregister where username=@username";


            string SelectResultFromDB = "";
            

            string SeletQString = "SELECT username FROM superuserregister WHERE username=@username";
            LblUsername.Text = SeletQString;

     

            SelectFromSQLDB(SeletQString, out SelectResultFromDB);



            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //GRVInfo.DataSource = dt;
            //GRVInfo.DataBind();

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