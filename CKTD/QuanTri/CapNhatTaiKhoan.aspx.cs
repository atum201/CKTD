using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;

public partial class QuanTri_CapNhatTaiKhoan : System.Web.UI.Page
{
    public CKTDManagement cktd = new CKTDManagement();
    public CKTDCommon ckcm = new CKTDCommon();
    public CKTD_TaiKhoan nguoidung;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["ID"] != null)
        {
            int id = 0;
            int.TryParse(HttpContext.Current.Request.QueryString["ID"].ToString(),out id);
            try
            {
                nguoidung = cktd.getCKTD_TaiKhoanById(id);
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                nguoidung = null;
            }
        }
        else
        {
            if (HttpContext.Current.Request.QueryString["TaiKhoan"] != null)
            {
                string taiKhoan = HttpContext.Current.Request.QueryString["TaiKhoan"].ToString();
                try
                {
                    nguoidung = cktd.getCKTD_TaiKhoan("where TaiKhoan=N'" + taiKhoan + "'")[0];
                    if (!this.IsPostBack)
                    {
                        initializeDataInControl();
                    }
                }
                catch (Exception ex)
                {
                    nguoidung = null;
                }
            }
        }
    }

    private void initializeDataInControl()
    {
        txtTenDangNhap.Text = nguoidung.TaiKhoan;
        txtTenHienThi.Text = nguoidung.Ten;
        for(int i=0;i< Enum.GetNames(typeof(CKTDLoaiNguoiDung)).Length; i++)
        {
            ddlLoaiTaiKhoan.Items.Add(new ListItem(ckcm.GetEnumTextValue((CKTDLoaiNguoiDung)i), i.ToString()));
        }
        ddlLoaiTaiKhoan.SelectedValue = nguoidung.LoaiNguoiDung.ToString();
    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        if(nguoidung != null)
        {
            nguoidung.Ten = txtTenHienThi.Text.Trim();
            nguoidung.TaiKhoan = txtTenDangNhap.Text.Trim();
            nguoidung.LoaiNguoiDung = int.Parse(ddlLoaiTaiKhoan.SelectedValue);
            cktd.updateCKTD_TaiKhoan(nguoidung);
        }
        else
        {
            nguoidung.Ten = txtTenHienThi.Text.Trim();
            nguoidung.TaiKhoan = txtTenDangNhap.Text.Trim();
            nguoidung.LoaiNguoiDung = int.Parse(ddlLoaiTaiKhoan.SelectedValue);
            cktd.themCKTD_TaiKhoan(nguoidung);
        }
    }
    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/QuanTri/DanhSachTaiKhoan.aspx");
    }
}