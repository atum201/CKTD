using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyTinTuc_CapNhatTinTuc : System.Web.UI.Page
{
    public TinTucManagement tinTucManagement = new TinTucManagement();
  //  public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    //  public float hoaHongNguoiGioiThieu = 0;
    public TinTuc tinTuc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDTinTuc"] != null)
        {
            string iDTinTuc = HttpContext.Current.Request.QueryString["iDTinTuc"].ToString();
            try
            {
                tinTuc = tinTucManagement.getTinTuc("where ID=N'" + iDTinTuc + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                tinTuc = null;
            }
        }
    }

    private void initializeDataInControl()
    {
        txtNgayTao.Text = tinTuc.NgayTao.ToString();

        ddlLoaiTinTuc.Items.Add(new ListItem("Tin Tức", "TinTuc"));
        ddlLoaiTinTuc.Items.Add(new ListItem("Hướng Dẫn", "HuongDan"));
        ddlLoaiTinTuc.SelectedValue = tinTuc.LoaiTinTuc;

        ddlTrangThai.Items.Add(new ListItem("Hoạt động", "HoatDong"));
        ddlTrangThai.Items.Add(new ListItem("Không hoạt động", "KhongHoatDong"));
        ddlTrangThai.SelectedValue = tinTuc.TrangThai;

        txtTieuDe.Text = tinTuc.TieuDe;
        txtNoiDung.Text = tinTuc.NoiDung;

        
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
       // tinTuc = new TinTuc();
        tinTuc.TieuDe = txtTieuDe.Text;
        tinTuc.NoiDung = txtNoiDung.Text;
        tinTuc.NgayTao = DateTime.Parse(txtNgayTao.Text);
        tinTuc.LoaiTinTuc = ddlLoaiTinTuc.SelectedValue;
        tinTuc.TrangThai = ddlTrangThai.SelectedValue;

        tinTucManagement.updateTinTuc(tinTuc);
     
        Response.Redirect("/Views/Backend/QuanTri/QuanLytinTuc/DanhSachtinTuc.aspx");
    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLytinTuc/DanhSachtinTuc.aspx");
    }
}