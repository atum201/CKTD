using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyLoaiTien_CapNhatLoaiTien : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();

    public LoaiTien loaiTien;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDLoaiTien"] != null)
        {
            string iDLoaiTien = HttpContext.Current.Request.QueryString["iDLoaiTien"].ToString();
            try
            {
                loaiTien = loaiTienManagement.getLoaiTien("where ID=N'" + iDLoaiTien + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                loaiTien = null;
            }
        }
    }

    private void initializeDataInControl()
    {
      
        ddlAutoLoad.Items.Add(new ListItem("True", "true"));
        ddlAutoLoad.Items.Add(new ListItem("False", "false"));
        ddlAutoLoad.SelectedValue = loaiTien.AutoLoad;

        ddlTrangThai.Items.Add(new ListItem("Kích hoạt", "KichHoat"));
        ddlTrangThai.Items.Add(new ListItem("Chưa kích hoạt", "ChuaKichHoat"));
        ddlTrangThai.SelectedValue = loaiTien.TrangThai;

        txtTenLoaiTien.Text = loaiTien.TenLoaiTien;
        txtMaLoaiTien.Text = loaiTien.MaLoaiTien;
        txtGiaMua.Text = loaiTien.GiaMua.Value.ToString("0.#");
        txtPhuPhiBan.Text = loaiTien.PhuPhiBan.ToString();
        txtGiaBan.Text = loaiTien.GiaBan.Value.ToString("0.#");
        txtPhuPhiMua.Text = loaiTien.PhuPhiMua.ToString();
        txtThuTu.Text = loaiTien.ThuTu.ToString();
        txtHanMuc.Text = loaiTien.HanMuc.ToString();
        txtThongBaoHetHanMuc.Text = loaiTien.ThongBaoHetHanMuc.ToString();

        if (loaiTien.ThuTuHienThiBox != -1 & loaiTien.ThuTuHienThiBox != null)
        {
            chkHienThiBox.Checked = true;
            txtThuTuHienThiBox.Text = loaiTien.ThuTuHienThiBox.ToString() ;
        }
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        loaiTien.TenLoaiTien = txtTenLoaiTien.Text;
        loaiTien.MaLoaiTien = txtMaLoaiTien.Text;
        loaiTien.GiaMua = float.Parse(txtGiaMua.Text);
        loaiTien.GiaBan = float.Parse(txtGiaBan.Text);
        loaiTien.TrangThai = ddlTrangThai.SelectedValue;
        loaiTien.AutoLoad = ddlAutoLoad.SelectedValue;

        loaiTien.ThuTu = int.Parse(txtThuTu.Text);
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
            loaiTien.PhuPhiBan = 0;
        else
            loaiTien.PhuPhiBan = float.Parse(txtPhuPhiBan.Text);
        if (txtPhuPhiMua.Text == "")
            loaiTien.PhuPhiMua = 0;
        else
            loaiTien.PhuPhiMua = float.Parse(txtPhuPhiMua.Text);

        loaiTienManagement.updateLoaiTien(loaiTien);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx");

    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx");
    }
}