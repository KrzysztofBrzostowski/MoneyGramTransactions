using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                TextBox1.Text = "KB";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "C#";


            Button clickedButton = (Button)sender;
            clickedButton.Text = "...button clicked...";
            clickedButton.Enabled = false;

        }

    }
}