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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button_Login_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NET_Projekt_2_ADO_ASP_ShopConnectionString"].ConnectionString);
            conn.Open();
            string checkUser = "SELECT COUNT(*) FROM [User] WHERE [username] = '" + TextBoxUserName.Text + "'";
            SqlCommand com = new SqlCommand(checkUser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPasswordQuery = "SELECT Password FROM [User] WHERE [username] = '" + TextBoxUserName.Text + "'";
                SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                string password = passComm.ExecuteScalar().ToString().Replace(" ","");
                if (password==TextBoxPassword.Text)
                {
                    Session["New"] = TextBoxUserName.Text;
                    Response.Write("Password is correct");
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    Response.Write("Password is NOT correct");
                }
                conn.Close();
            }
            else
            {
                Response.Write("Username is NOT correct");
            }
           
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
         
        }
    }
}