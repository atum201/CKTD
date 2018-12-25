using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_CauHinhThongTinHeThong : System.Web.UI.Page
{
    public ThongTinHeThongManagement thongTinHeThongManagement = new ThongTinHeThongManagement();
    public ThongTinHeThong thongTinHeThong;
    protected void Page_Load(object sender, EventArgs e)
    {
        thongTinHeThong = thongTinHeThongManagement.getThongTinHeThong()[0];
        if (!this.IsPostBack)
        {
            initializeDataInControl();
            

        }
        
    }

    private void initializeDataInControl()
    {
        ReadOnlyCollection<TimeZoneInfo> _timeZones = TimeZoneInfo.GetSystemTimeZones();
        ddlTimeZone.DataSource = _timeZones;
        ddlTimeZone.DataTextField = "DisplayName";
        ddlTimeZone.DataValueField = "Id";
        ddlTimeZone.DataBind();
        string idTimeZoneInfo = thongTinHeThong.TimeZoneSystem;
        ddlTimeZone.SelectedValue = idTimeZoneInfo;

        txtHotLine.Text = thongTinHeThong.Hotline??"";
        txtLinkFacebook.Text = thongTinHeThong.LinkFacebook ?? "";
        txtLinkYoutube.Text = thongTinHeThong.LinkYoutube ?? "";
        txtLinkReddit.Text = thongTinHeThong.LinkReddit ?? "";
        txtLinkLinkedIn.Text = thongTinHeThong.LinkLinkedIn ?? "";
        if (thongTinHeThong.Footer != null)
        {
            txtFooter.Text = thongTinHeThong.Footer.Replace("<br/>","\n");
        }
        txtLinkGioiThieu.Text = thongTinHeThong.LinkGioiThieu ?? "";
        txtGiaTriKichHoatHoaHong.Text = thongTinHeThong.GiaTriKichHoatHoaHong.Value.ToString();
        txtTiLeChiaHoaHong.Text = thongTinHeThong.TiLeChiaHoaHong.Value.ToString();
    }
    protected void btnLuuLai_Click(object sender, EventArgs e)
    {
        try
        {
            FileCommon fileCommon = new FileCommon();
            HttpFileCollection httpFileCollection = Page.Request.Files;
            if (httpFileCollection[0] != null && httpFileCollection[0].ContentLength > 0)
            {
                thongTinHeThong.LinkLogo = fileCommon.UploadFile("/Style/images/Uploads/Logo/", httpFileCollection[0]);
            }
            if (httpFileCollection[1] != null && httpFileCollection[1].ContentLength > 0)
            {
                thongTinHeThong.LinkBanner = fileCommon.UploadFile("/Style/images/Uploads/Banner/", httpFileCollection[1]);
            }
            thongTinHeThong.TimeZoneSystem = ddlTimeZone.SelectedValue;
            thongTinHeThong.Hotline = txtHotLine.Text;
            thongTinHeThong.LinkFacebook = txtLinkFacebook.Text;
            thongTinHeThong.LinkYoutube = txtLinkYoutube.Text;
            thongTinHeThong.LinkReddit = txtLinkReddit.Text;
            thongTinHeThong.LinkLinkedIn = txtLinkLinkedIn.Text;
            thongTinHeThong.Footer = txtFooter.Text.Replace("\n","<br/>");
            thongTinHeThong.LinkGioiThieu = txtLinkGioiThieu.Text;
            thongTinHeThong.GiaTriKichHoatHoaHong = float.Parse(txtGiaTriKichHoatHoaHong.Text);
            thongTinHeThong.TiLeChiaHoaHong = float.Parse(txtTiLeChiaHoaHong.Text);
            thongTinHeThongManagement.updateThongTinHeThong(thongTinHeThong);
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert(\"Xảy ra lỗi vui lòng thử lại.\");</script>");
        }
    }
}