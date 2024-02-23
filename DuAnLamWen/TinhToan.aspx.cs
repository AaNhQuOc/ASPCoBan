using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamWen
{
    public partial class TinhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKetQua.Text = (a + b).ToString();
        }

        protected void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKetQua.Text = (a - b).ToString();
        }

        protected void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKetQua.Text = (a * b).ToString();
        }

        protected void btnChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            txtKetQua.Text = (a / b).ToString();
        }
    }
}