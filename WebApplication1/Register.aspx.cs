using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            register(Request.Form["ctl00$MainContent$TextBox1"], Request.Form["ctl00$MainContent$TextBox2"], Request.Form["ctl00$MainContent$TextBox3"]);
        }

        protected void register(String acc, String psw,String nickname)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);


            /*
            String sqlString = "Insert into [Orders].[dbo].[Account](account, password,nickname) values('"+ acc + "','"+psw+"','"+ nickname+"')";

            connection.Open();

            SqlCommand Command = new SqlCommand(sqlString, connection);
            
            Command.ExecuteNonQuery();

            connection.Close();
            */


            String sqlString = "Insert into [Orders].[dbo].[Account](account, password,nickname) values(@account, @password, @nickname)";

            connection.Open();         

            SqlCommand Command = new SqlCommand(sqlString, connection);
            Command.Parameters.Add("@account",SqlDbType.NVarChar);
            Command.Parameters["@account"].Value = acc;
            Command.Parameters.Add("@password", SqlDbType.NVarChar);
            Command.Parameters["@password"].Value = psw;
            Command.Parameters.Add("@nickname", SqlDbType.NVarChar);
            Command.Parameters["@nickname"].Value = nickname;

            Command.ExecuteNonQuery();

            connection.Close();
        }
    }
}