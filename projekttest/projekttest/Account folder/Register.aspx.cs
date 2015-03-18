using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Projekt_2
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NET_Projekt_2_ADO_ASP_ShopConnectionString"].ConnectionString);
                conn.Open();
                string checkUser = "SELECT COUNT(*) FROM [User] WHERE [username] = '" + TextBoxUserName.Text + "'";
                SqlCommand com = new SqlCommand(checkUser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    Response.Write("User already Exists");
                }
                conn.Close();
            }
        }
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //= new SqlConnection(ConfigurationManager.ConnectionStrings["NET_Projekt_2_ADO_ASP_ShopConnectionString"].ConnectionString);
                conn.Open();
                string InsertQuery = "INSERT into [User] (Username,Password,Email) values (@UserName, @Password,@Email)";
                SqlCommand com = new SqlCommand(InsertQuery, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                com.Parameters.AddWithValue("@UserName", TextBoxUserName.Text);
                com.Parameters.AddWithValue("@Password", TextBoxPassword.Text);
                com.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                com.ExecuteNonQuery();
                Response.Redirect("Manger.aspx");
                Response.Write("Registration is successful");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("ERROR:" + ex.ToString());
            }
        }
    }
}