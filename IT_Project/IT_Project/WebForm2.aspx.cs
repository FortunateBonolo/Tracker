using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Drawing;

namespace IT_Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            disp_data();
       

        }
        public void disp_data()
        {

            SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select* from [dbo].[Form]", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
            con.Close();


        }

        //public void disp_dat()
        //{

        //    SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand("select ConsaltantInitials from Form", con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    DropDownList.DataSource = dt;
        //    DropDownList.DataBind();
        //    con.Close();


        //}
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

        protected void gridview_SelectedIndexChanged(object sender, EventArgs e)
        {
            disp_data();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //"SELECT * FROM TABLE WHERE Desc LIKE N'%" + SearchContron.Text + "%'"
            if (Intermediary.Text == "")
            {

                Response.Write("Please insert valid infomation");

            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT* FROM Form WHERE ConsaltantInitials LIKE '%" + Intermediary.Text + "%' OR interactionDate LIKE '%" + Intermediary.Text + "%' OR activity LIKE '%" + Intermediary.Text + "%'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridview.DataSource = dt;
                gridview.DataBind();
                con.Close();




            }



        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            Intermediary.Text = "";
            disp_data();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Form4Cust2.aspx");

        }

        //protected void Intermediary_TextChanged(object sender, EventArgs e)
        //{



        //    SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand("SELECT* FROM Form WHERE ConsaltantInitials LIKE '" + Intermediary.Text + "%' ", con);
        //    DataTable data = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(data);
        //    gridview.DataSource = data;

        //    //    SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
        //    //    SqlCommand cmd = new SqlCommand("SELECT* FROM Form WHERE InteractionDate LIKE '%" + Intermediary.Text + "%' ", con);
        //    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    //    DataTable data = new DataTable();
        //    //    da.Fill(data);
        //    //    gridview.DataSource = data;
        //    //}


        //    //OR interactionDate LIKE '%" + Intermediary.Text + "%' OR activity LIKE '%" + Intermediary.Text + "%'


        //}
    }
}