using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamWen
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code khoi tao du lieu cho cac dieu khien
            if (!Page.IsPostBack)
            {
                //khoi tao cho ddlTrinhDo
                ddlTrinhDo.Items.Add(new ListItem("Trung cấp"));
                ddlTrinhDo.Items.Add(new ListItem("Cao đẳng"));
                //...

                //khoi tao cho lstNgheNghiep
                lstNgheNghiep.Items.Add(new ListItem("Công nhân"));
                lstNgheNghiep.Items.Add(new ListItem("Lập trình viên"));
                lstNgheNghiep.Items.Add(new ListItem("Kỹ sư"));
                //...

                //khoi tao cho chkListSoThich
                chkListSoThich.Items.Add(new ListItem("Mua sắm"));
                chkListSoThich.Items.Add(new ListItem("Xem phim"));
                chkListSoThich.Items.Add(new ListItem("Du lịch"));
                chkListSoThich.Items.Add(new ListItem("Ăn nhậu"));

                protected void btGui_Click(object sender, EventArgs e)
                {
                    string kq = "";
                    kq += "<h2> Thông tin đăng ký của bạn </h2>";
                    kq += "<ul>";

                    kq += $"<li>Họ tên {txtHoTen}</li>";
                    kq += string.Format("<li> Ngày sinh: {0} </li>", txtNgaySinh.Text);
                    if (rdNam.Checked)
                    {
                        kq += $"<li> Giới Tính {rdNam.Text} </li>";
                    }
                    else
                    {
                        kq += $"<li> Giới Tính {rdNu.Text} </li>";
                    }
                    kq += $"<li>Trình độ {ddlTrinhDo.SelectedItem.Text}</li>";
                    kq += $"<li>Nghề nghiệp {lstNgheNghiep.SelectedItem.Text}</li>";

                    if (FHinh.HasFile)
                    {
                        string path = Server.MapPath("~/Uploads");
                        FHinh.SaveAs(path + "/" + FHinh.FileName);
                        kq += $"<li>Ánh: <img src='Uploads/{FHinh.FileName}'> </li>";
                    }
                    kq += "<ul>";

                    
                        }
            }
        }
    }

    protected void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
