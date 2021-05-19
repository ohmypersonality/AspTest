using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (IsPostBack)
            {
                if (Request.Form["ctl00$MainContent$count"] != "admin")
                {
                    Label3.Text = "帳號輸入錯誤";
                }


                if (Request.Form["ctl00$MainContent$psw"] != "admin")
                {
                    Label3.Text = "密碼輸入錯誤";
                }
            }
            else
            {       
            }
            */

            if (Convert.ToBoolean(Session["login"]))
            {
                //Response.Redirect("RockPaperScissors");
                Server.Transfer("RockPaperScissors.aspx");
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            if (count.Text != "" && psw.Text != "")
            {
                if (count.Text == "admin" && psw.Text == "admin")
                {
                    Response.Redirect("https://google.com.tw");
                }
                else
                {
                    Response.Redirect("https://yahoo.com.tw");
                }
            }
            */

            /*
            if (Request.Form["ctl00$MainContent$count"] != null && Request.Form["ctl00$MainContent$psw"] != null)
            {
                if (Request.Form["ctl00$MainContent$count"] == "admin" && Request.Form["ctl00$MainContent$psw"] == "admin")
                {
                    Response.Redirect("https://google.com.tw");
                }
                else
                {
                    //Response.Redirect("https://yahoo.com.tw");
                }
            }
            */

            /*
            if (Request.Form["user2"] != null && Request.Form["psw2"] != null)
            {
                if (Request.Form["user2"] == "admin" && Request.Form["psw2"] == "admin")
                {
                    //Response.Redirect("https://google.com.tw");
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["login"] = true;
                    Session["nick_name"] = TextBox_nickname.Text.ToString();
                    //Response.Redirect("Handler1.ashx");
                    Server.Transfer("Handler1.ashx");

                    /*
                    Handler1 handler =new Handler1();
                    handler.ProcessRequest(Context);
                    Response.End();
                    */

            //Response.Redirect("RockPaperScissors");
            //Server.Execute("RockPaperScissors.aspx"); //Server.Execute會繼續執行後續動作
            //Session["nick_name"] = TextBox_nickname.Text.ToString();

            accountCheck(Request.Form["user"], Request.Form["password"]);

        }

    

               

            
        

        protected void accountCheck(string account, string password)
        {
            //Label3.Text = "";
            //Label3.Text = "";

            string condition = "where account = '" + account + "'";                 
           
            if (dataQuery("account", "Account", condition) == account)
            {
                if (dataQuery("password", "Account", condition) == password)
                {
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["login"] = true;
                    Session["nick_name"] = Convert.ToString(Request.Form["user"]);
                    //Response.Redirect("Handler1.ashx");
                    Server.Transfer("Handler1.ashx");
                }
                else
                {
                    //Label3.Text = "密碼錯誤";
                }
            }
            else
            {
                //Label3.Text = "無此帳號";
            }
        }


        protected String dataQuery(string item, string table, string condition)
        {
            //創一個變數存放從config內的資訊，其實也可不用創立這變數，直接放進SqlConnection內即可。
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;

            //new一個SqlConnection物件，是與資料庫連結的通道(其名為Connection)，以s_data內的連接字串連接所對應的資料庫。
            SqlConnection connection = new SqlConnection(s_data);

            string queryString = "select " + item + " from [Orders].[dbo].[" + table + "]"+ condition;
            //new一個SqlCommand告訴這個物件準備要執行什麼SQL指令
            SqlCommand Command = new SqlCommand(queryString, connection);

            //與資料庫連接的通道開啟
            connection.Open();

            //new一個DataReader接取Execute所回傳的資料。
            SqlDataReader Reader = Command.ExecuteReader();

            string results = "";
            //檢查是否有資料列
            if (Reader.HasRows)
            {
                //使用Read方法把資料讀進Reader，讓Reader一筆一筆順向指向資料列，並回傳是否成功。
                if (Reader.Read())
                {
                    //DataReader讀出欄位內資料的方式，通常也可寫Reader[0]、[1]...[N]代表第一個欄位到N個欄位。
                    results = Reader[item].ToString().Trim();
                }                
            }           
                  

            //關閉與資料庫連接的通道
            connection.Close();

            return results;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}