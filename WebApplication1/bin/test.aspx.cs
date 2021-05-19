using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
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
                    Label4.Text = "密碼輸入錯誤";
                }
            }
            else
            {       
            }
            */

            if(Convert.ToBoolean(Session["login"]))
            {
                //Response.Redirect("WebForm3");
                Server.Transfer("WebForm3.aspx");
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


            if (Request.Form["user2"] != null && Request.Form["psw2"] != null)
            {
                if (Request.Form["user2"] == "admin" && Request.Form["psw2"] == "admin")
                {
                    //Response.Redirect("https://google.com.tw");
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    TextBox1.Text = Convert.ToString(Application["count"]);
                    Session["login"] = true;
                    Session["nick_name"] = TextBox_nickname.Text.ToString();
                    //Response.Redirect("Handler1.ashx");
                    Server.Transfer("Handler1.ashx");

                    /*
                    Handler1 handler =new Handler1();
                    handler.ProcessRequest(Context);
                    Response.End();
                    */

                    //Response.Redirect("WebForm3");
                    //Server.Execute("WebForm3.aspx"); //Server.Execute會繼續執行後續動作
                    //Session["nick_name"] = TextBox_nickname.Text.ToString();
                }
                else
                {
                    //Response.Redirect("https://yahoo.com.tw");
                }
            }
            
        }
        
    }
}