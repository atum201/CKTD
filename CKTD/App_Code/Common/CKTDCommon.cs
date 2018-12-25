using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;

/// <summary>
/// Summary description for CKTDCommon
/// </summary>
public  class CKTDCommon
{
    public string ShowTaiKhoan(IList<CKTD_TaiKhoan> list, int start) {
        string str = string.Empty;
        for(int i=0; i < list.Count; i++)
        {
            object[] objArray1 = new object[] {
                    str, "<tr><td> ", start+i, "</td><td> <a  href='/QuanTri/CapNhatTaiKhoan.aspx?TaiKhoan=",
                    list[i].ID.ToString(), "'>", list[i].Ten, "</a></td><td>", list[i].TaiKhoan, "</td><td>",list[i].LoaiNguoiDung,"</td><td>",list[i].TrangThai,
                    "</td><td>","Thoi Gian Cap Nhat",
                    "</td><td><a href=\"/QuanTri/CapNhatTaiKhoan.aspx?CapNhatTaiKhoan=",list[i].ID.ToString(),"'>"+
                                "<span class=\"icon has-text-success\">"+
                                    "<i class=\"fa fa-edit\"></i>"+
                                "</span></a>"+
                            "<span class=\"icon has-text-success\"><i class=\"fa fa-trash\"></i></span></td></tr>"
                };
            str = string.Concat(objArray1);
        }
        return str;
    }
    public string ShowDonVi(IList<CKTD_DonVi> list, int start)
    {
        string str = string.Empty;
        EnumTextValue e=(EnumTextValue)CKTDLoaiNguoiDung.DonViChuQuan.GetType().GetCustomAttributes(typeof(EnumTextValue), false).First();
        return str;
    }
    public string ShowVanBan(IList<CKTD_VanBan> list, int start)
    {
        string str = string.Empty;
        return str;
    }
    public string ShowDichVuCong(IList<CKTD_DichVuCong> list, int start)
    {
        string str = string.Empty;
        return str;
    }
    public string GetEnumTextValue(Enum t)
    {
        //EnumTextValue e = (EnumTextValue)t.GetType().GetCustomAttributes(typeof(EnumTextValue), false).First();

        return "";
    }
}
[System.AttributeUsage(System.AttributeTargets.All)]
public class EnumTextValue : System.Attribute
{
    private string text;

    public EnumTextValue(string text)
    {
        this.text = text;
    }
}
public enum LoaiDanhSach {
    TaiKhoan,
    DonVi,
    DichVuCong,
    VanBan
}

public enum CKTDTrangThai
{

}

public enum CKTDLoaiNguoiDung
{
    [EnumTextValue("Quản trị hệ thống")]
    QuanTriHeThong,
    [EnumTextValue("Đơn vị chủ quản")]
    DonViChuQuan,
    [EnumTextValue("Khác")]
    Khac
}
