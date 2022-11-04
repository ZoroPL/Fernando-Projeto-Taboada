using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nTabuada
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            var n = TextBox1.Text;
            int t = 0;
           
            for (int i = 1; i < 11; i++)
            {
                t = (int)(float)(Convert.ToDouble(n) * i);
                ListBox1.Items.Add(i.ToString() + "X" + n.ToString() + "=" + t);
            }
        }
    }
}