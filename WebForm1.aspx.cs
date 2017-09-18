using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T6_laskin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plusBtn_Click(object sender, EventArgs e)
        {
            double luku1, luku2, luku3;

            if (double.TryParse(TextBox1.Text, out luku1) && double.TryParse(TextBox2.Text, out luku2))
            {
                luku3 = luku1 + luku2;

                TextBox3.Text = luku3.ToString();
            }
            else
            {
                TextBox3.Text = "Käytä numeroita";
            }
        }

        protected void minusBtn_Click(object sender, EventArgs e)
        {
            double luku1, luku2, luku3;

            if (double.TryParse(TextBox1.Text, out luku1) && double.TryParse(TextBox2.Text, out luku2))
            {
                luku3 = luku1 - luku2;

                TextBox3.Text = luku3.ToString();
            }
            else
            {
                TextBox3.Text = "Käytä numeroita";
            }
        }

        protected void kertoBtn_Click(object sender, EventArgs e)
        {
            double luku1, luku2, luku3;

            if (double.TryParse(TextBox1.Text, out luku1) && double.TryParse(TextBox2.Text, out luku2))
            {
                luku3 = luku1 * luku2;

                TextBox3.Text = luku3.ToString();
            }
            else
            {
                TextBox3.Text = "Käytä numeroita";
            }
        }

        protected void jakoBtn_Click(object sender, EventArgs e)
        {
            double luku1, luku2, luku3;

            if (double.TryParse(TextBox1.Text, out luku1) && double.TryParse(TextBox2.Text, out luku2))
            {
                if (luku2 != 0)
                {
                    luku3 = luku1 / luku2;

                    TextBox3.Text = luku3.ToString();
                }
                else
                {
                    TextBox3.Text = "0 jakajana";
                }
            }
            else
            {
                TextBox3.Text = "Käytä numeroita";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            double luku1;
            if (!double.TryParse(TextBox1.Text, out luku1))
            {
                TextBox3.Text = "Käytä numeroita";
            }
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            double luku2;
            if (!double.TryParse(TextBox2.Text, out luku2))
            {
                TextBox3.Text = "Käytä numeroita";
            }
        }
    }
}