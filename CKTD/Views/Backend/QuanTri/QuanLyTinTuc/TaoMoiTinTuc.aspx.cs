using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyTinTuc_TaoMoiTinTuc : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public TinTucManagement tinTucManagement = new TinTucManagement();
    
    public TinTuc tinTuc;
    public NguoiDung nguoiDung;
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
        txtNgayTao.Text = DateTime.Now.ToString();

        ddlLoaiTinTuc.Items.Add(new ListItem("Tin Tức", "TinTuc"));
        ddlLoaiTinTuc.Items.Add(new ListItem("Hướng Dẫn", "HuongDan"));

        ddlTrangThai.Items.Add(new ListItem("Hoạt động", "HoatDong"));
        ddlTrangThai.Items.Add(new ListItem("Không hoạt động", "KhongHoatDong"));

    }
    protected void btnLuu_Click(object sender, EventArgs e)
    {
        tinTuc = new TinTuc();
        tinTuc.TieuDe = txtTieuDe.Text;
        tinTuc.NoiDung = txtNoiDung.Text;
        tinTuc.NgayTao = DateTime.Parse(txtNgayTao.Text);
        tinTuc.LoaiTinTuc = ddlLoaiTinTuc.SelectedValue;
        tinTuc.TrangThai = ddlTrangThai.SelectedValue;

        tinTucManagement.themTinTuc(tinTuc);
        Response.Redirect("/Views/Backend/QuanTri/QuanLytinTuc/DanhSachtinTuc.aspx");
    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLytinTuc/DanhSachtinTuc.aspx");
    }
}