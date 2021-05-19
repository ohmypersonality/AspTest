using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["row"] != null && Request.QueryString["colunm"] != null)
            {
                //Label1.Text = (int.Parse(Request.QueryString["row"]) + int.Parse(Request.QueryString["colunm"])).ToString();

                
                string table = "";
                for (int i=1;i<= int.Parse(Request.QueryString["row"]); i++)
                {
                    for (int j = 1; j <= int.Parse(Request.QueryString["colunm"]); j++)
                    {
                        if((i * j)<10)
                        {
                            table = table + i + "*" + j + "= " + (i * j) + " ";
                        }
                        else
                        {
                            table = table + i + "*" + j + "=" + (i * j) + " ";
                        }
                        
                    }
                    table = table + "</br>";
                }
                //Label1.Text = table;
                Response.Write(table);
                

               
                
            }
            
        }
    }
}