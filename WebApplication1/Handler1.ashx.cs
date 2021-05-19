using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;


namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : System.Web.UI.Page,IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            context.Response.Write("\n" + "name:"+ Convert.ToString(context.Session["nick_name"]));
            context.Response.Write("\n" + "登入人數："+Convert.ToInt32(context.Application["count"]));

            /*
            if (Convert.ToString(context.Session["nick_name"])=="123")
            {
                context.Response.Redirect("https://google.com.tw");
            }
            else
            {
                context.Response.Redirect("https://yahoo.com.tw");
            }
            */
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}