using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TinhToan
{
    public partial class TinhToanCB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnhap_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 1";
                return;
            }
            if (txt2.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 2";
                return;
            }
            double mot = double.Parse(txt1.Text);
            double hai = double.Parse(txt2.Text);




            double tru = mot - hai;
            lblhien.Text = mot + "-" + hai + "=" + tru;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 1";
                return;
            }
            if (txt2.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 2";
                return;
            }
            double mot = double.Parse(txt1.Text);
            double hai = double.Parse(txt2.Text);




            double tru = mot * hai;
            lblhien.Text = mot + "*" + hai + "=" + tru;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 1";
                return;
            }
            if (txt2.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 3";
                return;
            }
            double mot = double.Parse(txt1.Text);
            double hai = double.Parse(txt2.Text);




            double tru = mot / hai;
            lblhien.Text = mot + "/" + hai + "=" + tru;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 1";
                return;
            }
            if (txt2.Text == "")
            {
                lblhien.Text = "bạn chưa nhập số 2";
                return;
            }
            double mot = double.Parse(txt1.Text);
            double hai = double.Parse(txt2.Text);




            double tru = mot + hai;
            lblhien.Text = mot + "+" + hai + "=" + tru;
        }
    }
}