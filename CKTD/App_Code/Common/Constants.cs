using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Constants
/// </summary>
public class Constants
{
    public static string kichHoatTaiKhoanBangMail = System.Configuration.ConfigurationSettings.AppSettings["kichHoatTaiKhoanBangMail"];
    public static string CoinBase_API_Key = System.Configuration.ConfigurationSettings.AppSettings["CoinBase_API_Key"];
    public static string CoinBase_API_Secret = System.Configuration.ConfigurationSettings.AppSettings["CoinBase_API_Secret"];
    public static string TieuDe_QuanTri = "Công khai tiến độ Bộ Thông tin & Truyền thông.";
}