using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    

    public partial class RockPaperScissors : System.Web.UI.Page
    {
        public static int ct=600;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(Session["login"]))
            {
                //Response.Redirect("Login");
                Server.Transfer("Login.aspx");
            }
            else
            {
                
                countTimer.Enabled = true;
                countTimer.Interval = 1000;
                Label_user_name.Text = Convert.ToString(Session["nick_name"])+"君您好：     "; 
                Label_login_number.Text = "目前登入人數：" + Convert.ToString(Application["count"]);
            }
            
                        
        }

        

        protected void Button_Click(object sender, ImageClickEventArgs e)
        {
            int user = 0;
            if (sender== ImageButton1)
            {
                Image2.ImageUrl = "~/pic/Scissors.png";
                Label_user_RockPaperScissors.Text = "玩家出剪刀";
                user = 1;
            }
            else if(sender == ImageButton2)
            {
                Image2.ImageUrl = "~/pic/Rock.png";
                Label_user_RockPaperScissors.Text = "玩家出石頭";
                user = 2;
            }
            else
            {
                Image2.ImageUrl = "~/pic/Paper.png";
                Label_user_RockPaperScissors.Text = "玩家出布";
                user = 3;
            }

            Random rnd = new Random();
            int computer = rnd.Next(1, 4); //產生亂數
            if (computer == 1)
            {
                Image1.ImageUrl = "~/pic/Scissors.png";
                if (IsPostBack)
                {
                    Label_computer_RockPaperScissors.Text = "電腦出剪刀";
                }

            }
            else if (computer == 2)
            {
                Image1.ImageUrl = "~/pic/Rock.png";
                if (IsPostBack)
                {
                    Label_computer_RockPaperScissors.Text = "電腦出石頭";
                }
            }
            else if (computer == 3)
            {
                Image1.ImageUrl = "~/pic/Paper.png";
                if (IsPostBack)
                {
                    Label_computer_RockPaperScissors.Text = "電腦出布";
                }
            }

            if ((user == 1 && computer == 3) ||
               (user == 2 && computer == 1) ||
               (user == 3 && computer == 2))
            {
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
                Label_result_RockPaperScissors.Text = "玩家贏了";
            }
               
            else if ((user == 1 && computer == 2)
                || (user == 2 && computer == 3)
                || (user == 3 && computer == 1))
            {
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
                Label_result_RockPaperScissors.Text = "玩家輸了";
            }
                
            else
            {
                Session["tie"] = Convert.ToInt32(Session["tie"]) + 1;
                Label_result_RockPaperScissors.Text = "平手";
            }

            Label_record_RockPaperScissors.Text = Convert.ToInt32(Session["win"]) + "勝"+ Convert.ToInt32(Session["tie"]) + "平"+ Convert.ToInt32(Session["lose"]) + "敗";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Logout();
        }

        protected void Logout()
        {
            Session.Remove("login");
            Application["count"] = Convert.ToInt32(Application["count"]) - 1;
            Session.Remove("win");
            Session.Remove("tie");
            Session.Remove("lose");
            Response.Redirect("Login");
        }


        protected void countTimer_Tick(object sender, EventArgs e)
        {
            if(ct==0)
            {
                Logout();
            }
            else
            {
                ct--;
                Label_count.Text = "倒數時間：" + ct;
                Label_chat_room.Text = Convert.ToString(Application["chat"]);
            }            
        }
               
        protected void Button2_Click(object sender, EventArgs e)
        {
            Application["chat"]= Convert.ToString(Application["chat"])+(Convert.ToString(Session["nick_name"]) + ": " + TextBox_message.Text+"</br>");
            TextBox_message.Text = "";
            Label_chat_room.Text = Convert.ToString(Application["chat"]);
        }
        
    }
}