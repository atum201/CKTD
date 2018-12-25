using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyLoaiTien_TaoMoiLoaiTien : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();

    public LoaiTien loaiTien;
    protected void Page_Load(object sender, EventArgs e)
    {
       // if (HttpContext.Current.Request.QueryString["iDNguoiDung"] != null)
       // {
          //  string idNguoDung = HttpContext.Current.Request.QueryString["iDNguoiDung"].ToString();
            try
            {
              //  nguoiDung = nguoiDungManagement.getNguoiDung("where ID=N'" + idNguoDung + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
               // nguoiDung = null;
            }
       // }
    }

    private void initializeDataInControl()
    {
        ddlAutoLoad.Items.Add(new ListItem("True", "true"));
        ddlAutoLoad.Items.Add(new ListItem("False", "false"));

        ddlTrangThai.Items.Add(new ListItem("Kích hoạt", "KichHoat"));
        ddlTrangThai.Items.Add(new ListItem("Chưa kích hoạt", "ChuaKichHoat"));

    }
    protected void btnLuu_Click(object sender, EventArgs e)
    {
 
        loaiTien = new LoaiTien();
        loaiTien.TenLoaiTien = txtTenLoaiTien.Text;
        loaiTien.GiaMua = float.Parse(txtGiaMua.Text);
        loaiTien.GiaBan = float.Parse(txtGiaBan.Text);
        loaiTien.TrangThai = ddlTrangThai.SelectedValue;
        loaiTien.AutoLoad = ddlAutoLoad.SelectedValue;

        loaiTien.ThuTu =int.Parse( txtThuTu.Text);
        loaiTien.HanMuc = float.Parse(txtHanMuc.Text);
        loaiTien.ThongBaoHetHanMuc = txtThongBaoHetHanMuc.Text;
        //upanh
        FileCommon fileCommon = new FileCommon();
        HttpFileCollection httpFileCollection = Page.Request.Files;
        if (httpFileCollection[0] != null && httpFileCollection[0].ContentLength > 0)
        {
            loaiTien.LinkIcon = fileCommon.UploadFile("/Style/images/Uploads/Money/", httpFileCollection[0]);
        }

        if (chkHienThiBox.Checked == true)
            loaiTien.ThuTuHienThiBox = int.Parse(txtThuTuHienThiBox.Text);
        else
            loaiTien.ThuTuHienThiBox = -1;

        loaiTien.MaLoaiTien = txtMaLoaiTien.Text;

        if (txtPhuPhiBan.Text == "")
            loaiTien.PhuPhiBan =0;
        else
            loaiTien.PhuPhiBan = float.Parse(txtPhuPhiBan.Text);
        if (txtPhuPhiMua.Text == "")
            loaiTien.PhuPhiMua = 0;
        else
            loaiTien.PhuPhiMua = float.Parse(txtPhuPhiMua.Text);

        loaiTienManagement.themLoaiTien(loaiTien);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx");

    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx");
    }
}