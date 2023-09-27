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
    public partial class SuperUserRegister : System.Web.UI.Page
    {

        string path = "Data Source=DESKTOP-KAB5P9H\\SQLEXPRESS;Initial Catalog=Massive;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;


        protected void Page_Load(object sender, EventArgs e)
        {


            con = new SqlConnection(path);
            disp_data();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
         string activityCheck = " ";
                    if (Txtusername.Text ==""|| txtPassword.Text==""|| Txtname.Text ==""||Txtlastname.Text ==""||drbUserType.Text ==""||TxtCreateDate.Text==""||TxtCreateBy.Text =="")
                    {

                        Response.Write("Please insert valid infomation");

                    }
                    else
                    {

                        if(RdbYes.Checked)
                            {
                         activityCheck = "Active";
                            }
                        else
                            {
                          activityCheck = "Deactive";

                            }
                        SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand(@"insert into [dbo].[superuserregister]([username],[password],[firstname],[lastname],[usertype],[createdate],[activity],[CreateBy]) values ('" + Txtusername.Text + "','" + txtPassword.Text + "','" + Txtname.Text + "','" + Txtlastname.Text + "','" + drbUserType.Text + "','" + TxtCreateDate.Text + "','" + activityCheck + "','" + TxtCreateBy.Text + "')", con);
                        con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully added')", true);


                            Txtusername.Text = "";
                            txtPassword.Text = "";
                            Txtname.Text = "";
                            Txtlastname.Text = "";
                            drbUserType.Text = "";
                            TxtCreateDate.Text = "";
                            activityCheck = "";
                            TxtCreateBy.Text = "";



            }




        }




      

      
        public void  disp_data()
        {

            SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select* from [dbo].[superuserregister]", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
            con.Close();

        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {
            string activityCheck = " ";


            if (RdbYes.Checked)
            {
                activityCheck = "Active";
            }
            else
            {
                activityCheck = "Not Active";

            }

            SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
                //SqlCommand cmd = new SqlCommand("update superuserregister set username='" + Txtusername.Text + "',firstname='" + Txtname.Text + "',lastname='" + Txtlastname.Text + "' ,usertype='" + drbUserType + "',createdate='" + TxtCreateDate.Text + "',activity='" + activityCheck + "'  where  username='" + Txtusername.Text + "'", con);
            SqlCommand cmd = new SqlCommand("update superuserregister set lastname='" + Txtlastname.Text + "' ,createdate='" + TxtCreateDate.Text + "',activity='" + activityCheck + "'  where  username='" + Txtusername.Text + "'", con);

            //cmd.CommandText= "update SuperUserRegister set (username='" + Txtusername.Text + "',firstname='" + Txtname.Text + "',lastname='" + Txtlastname.Text + "' ,usertype='" + drbUserType + "',createdate='" + TxtCreateDate.Text + "',activity='" + activityCheck + "',Createdby='" + TxtCreateBy + "' where  username='" + Txtusername.Text + "')",con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Updated')", true);




            Txtusername.Text = "";
            Txtname.Text = "";
            Txtlastname.Text = "";
            drbUserType.Text = "";
            TxtCreateDate.Text = "";
            TxtCreateBy.Text = "";

        }
   

        protected void BtnDelete_Click(object sender, EventArgs e)
        {

           
                     SqlConnection con = new SqlConnection("Data Source=KLO-RENT-FORN\\SQLEXPRESS;Initial Catalog=Tracker;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("delete from superuserregister where username='" + Txtusername.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                  
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Deleted')", true);
                    disp_data();
                    Txtusername.Text = "";

          


        }

    
    }
}