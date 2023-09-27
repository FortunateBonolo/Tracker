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
using static System.Net.Mime.MediaTypeNames;


namespace IT_Project
{
    public partial class Form4Cust2 : System.Web.UI.Page
    {
        public object txtComments { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //disp_data();
        }









        //public void disp_data()
        //{

        //    SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand("select* from [dbo].[ConsultantForm]", con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    gridview.DataSource = dt;
        //    gridview.DataBind();
        //    con.Close();

        //}
     

        //protected void BtnUpdate_Click1(object sender, EventArgs e)
        //{


        //    SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand("update SuperUserRegister set (ConsultantForm='" + txtInterhouse.Value + "',kaelo_consultant='" + txtConsult.Value + "',activity='" + txtActivity.Value + "' ,region='" + txtRegion.Value + "',add_date='" + txtDate.Value + "',company_name='" + txtCompany.Value + "',comment='" + txtComment.Value + "' where  username='" + Txtusername.Text + "')",con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Updated')", true);




        //    txtInterhouse.Value = "";
        //    txtConsult.Value = "";
        //    txtActivity.Value = "";
        //    txtRegion.Value = "";
        //    txtDate.Value = "";
        //    txtCompany.Value = "";
        //    txtComment.Value = "";


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
            con.Close();
            return SelectResults;

           


        }

        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {
            if (txtInterhouse.Text == "" || txtConsult.Text == "" || drbUserType.Text == "" || drbUserType2.Text == "" || date.Text == "" || IntermediaryConsultant.Text == "" || txtCompany.Text == "" || txtComment.Text == "")
            {

                Response.Write("Please insert valid infomation");

            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"insert into [dbo].[Form]([intermediaryhouse],[ConsaltantInitials],[activity],[region],[intermediaryConsultant],[company],[interactionDate],[comment]) values ('" + txtInterhouse.Text + "','" + txtConsult.Text + "','" + drbUserType.Text + "','" + drbUserType2.Text + "','" + IntermediaryConsultant.Text + "','" + txtCompany.Text + "','" + date.Text + "','" + txtComment.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully added')", true);



                txtInterhouse.Text = "";
                txtConsult.Text = "";
                drbUserType.Text = "";
                drbUserType2.Text = "";
                date.Text = "";
                IntermediaryConsultant.Text = "";
                txtCompany.Text = "";
                txtComment.Text = "";




            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");

        }
    }
}