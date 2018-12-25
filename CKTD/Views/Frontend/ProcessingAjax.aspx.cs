using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Frontend_ProcessingAjax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (HttpContext.Current.Request.QueryString["Command"] != null)
        {
            if (HttpContext.Current.Request.QueryString["Command"] == "getGiaTuDong")
            {
                getGiaTuDong();
            }
            else if (HttpContext.Current.Request.QueryString["Command"] == "getTenTaiKhoan")
            {
                getTenTaiKhoan();
            }

            else if (HttpContext.Current.Request.QueryString["Command"] == "isExistingBTCAddress")
            {
                isExistingBTCAddress();
            }
            else if (HttpContext.Current.Request.QueryString["Command"] == "isExistingETHAddress")
            {
                isExistingETHAddress();
            }
            else if (HttpContext.Current.Request.QueryString["Command"] == "isExistingAccount")
            {
                isExistingAccount();
            }
            else if (HttpContext.Current.Request.QueryString["Command"] == "getIDTaiKhoanNganHangConHanMuc")
            {
                getIDTaiKhoanNganHangConHanMuc();
            }
            else if (HttpContext.Current.Request.QueryString["Command"] == "callBackFromCoinBase")
            {
                callBackFromCoinBase();
            }
            

            
        }

    }

    public void getGiaTuDong()
    {
        try
        {
            string ReturnValue = "";

            //ReturnValue = new CrawlContent().getGiaRemitano();

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":" + ReturnValue + "}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void getTenTaiKhoan()
    {
        try
        {
            string ReturnValue = "";

            //ReturnValue = new CrawlContent().getTenTaiKhoanNganHang("VCB", Request.QueryString["soTaiKhoan"].ToString());

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":\"" + ReturnValue + "\"}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void isExistingBTCAddress()
    {
        try
        {
            string ReturnValue = "";

            //ReturnValue = new CrawlContent().getBTCAddressBalance(Request.QueryString["address"].ToString());

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":" + ReturnValue + "}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void getReceivedBTCTotal()
    {
        try
        {
            //string ReturnValue = "";

            float receivedTotal = 1;// new CrawlContent().getReceivedBTCTotal(Request.QueryString["address"].ToString());

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":" + receivedTotal + "}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void isExistingETHAddress()
    {
        try
        {
            string ReturnValue = "";

            //ReturnValue = new CrawlContent().getETHAddressBalance(Request.QueryString["address"].ToString());

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":" + ReturnValue + "}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void isExistingAccount()
    {
        try
        {
            string ReturnValue = "false";
            try
            {
                IList<NguoiDung> listNguoiDung = new NguoiDungManagement().getNguoiDung(" where TenDangNhap=N'" + Request.QueryString["tenDangNhap"].ToString() + "'");
                if (listNguoiDung.Count > 0)
                {
                    ReturnValue = "true";
                }
            }
            catch (Exception ex)
            {
            }

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":" + ReturnValue + "}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void getIDTaiKhoanNganHangConHanMuc()
    {
        try
        {
            string ReturnValue = "-1";
            float valueTransaction = float.Parse(Request.Form["valueTransaction"].ToString());
            TaiKhoanNganHangManagement taiKhoanNganHangManagement = new TaiKhoanNganHangManagement();
            IList<TaiKhoanNganHang> listTaiKhoanNganHang = taiKhoanNganHangManagement.getHanMucTrongNgayTaiKhoanNganHang();
            int i;
            for (i = 0; i < listTaiKhoanNganHang.Count; i++)
            {
                if (listTaiKhoanNganHang[i].HanMucTrongNgay >= valueTransaction)
                {
                    break;
                }
            }
            if (i < listTaiKhoanNganHang.Count)
            {
                ReturnValue = listTaiKhoanNganHang[i].ID.ToString();
            }
            else
            {
                ReturnValue = "-1";
            }

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":" + ReturnValue + "}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    public void callBackFromCoinBase()
    {
        try
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            String resultResponse = "{\"Result\":\"ok\"}";
            HttpContext.Current.Response.Write(resultResponse);

            HttpContext.Current.Response.End();
        }
        catch (Exception ex)
        {
            //HttpContext.Current.Response.Write("err: " + ex.ToString());
            return;
        }
    }

    
}