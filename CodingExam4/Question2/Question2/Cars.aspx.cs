using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question2
{
    public partial class Cars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Benz", "Jaguar", "Porsche", "Audi", "Bugatti" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Benz.ImageUrl = "~/Images/" + str + ".jfif";
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Benz")
            {
                TextBox1.Text = "Rs 1200000";
            }
            else if (DropDownList1.Text == "Jaguar")
            {
                TextBox1.Text = "Rs 1400000";
            }
            else if (DropDownList1.Text == "Porsche")
            {
                TextBox1.Text = "Rs 1600000";
            }
            else if (DropDownList1.Text == "Audi")
            {
                TextBox1.Text = "Rs 1800000";
            }
            else if (DropDownList1.Text == "Bugatti")
            {
                TextBox1.Text = "Rs 2000000";
            }
            else
            {
                TextBox1.Text = "Rs 2000000";
            }
        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }
    }
}