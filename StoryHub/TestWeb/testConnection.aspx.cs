using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class testConnection : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            //obtainedText.Visible = false;
            //SmartNavigation = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /// tady se odesle zadost o zaslani textu
            /// 
            if (!obtainedText.Visible)
            {
                obtainedText.Visible = true;
            }else
            {
                obtainedText.Visible = false;
            }
        }
    }
}