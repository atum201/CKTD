using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CommonUtil
/// </summary>
public class CommonUtil
{

	public CommonUtil()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static TimeZoneInfo getTimeZoneInfoById(string id)
    {
        ReadOnlyCollection<TimeZoneInfo> _timeZones = TimeZoneInfo.GetSystemTimeZones();
        TimeZoneInfo result = null;
        for (int i = 0; i < _timeZones.Count; i++)
        {
            if (_timeZones[i].Id == id)
            {
                result = _timeZones[i];
                return result;
            }
        }
        return result;
    }

    public static DateTime getDateTimeByTimeZoneID(DateTime dateTime, string id)
    {
       
        var localDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
        TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(id);
        DateTime result = TimeZoneInfo.ConvertTime(localDateTime, timeZoneInfo);
        return result;
        //return TimeZoneInfo.ConvertTimeFromUtc(dateTime, getTimeZoneInfoById(id));
    }

    public static string GetStringSha256Hash(string text)
    {
        if (String.IsNullOrEmpty(text))
            return String.Empty;

        using (var sha = new System.Security.Cryptography.SHA256Managed())
        {
            byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] hash = sha.ComputeHash(textData);
            return BitConverter.ToString(hash).Replace("-", String.Empty);
        }
    }

    public static String pageNavigator_TrangTrong(String nameFuction, int currentPage, int totalPage, int pageSize, int totalItems)
    {
        if (nameFuction.IndexOf("(") == -1)
            nameFuction += "(";
        String buffer = "";
        try
        {
            if (totalItems > pageSize)
            {

                int start = (currentPage - 1) * pageSize + 1;
                int end = currentPage * pageSize;
                if (end > totalItems) end = totalItems;
                int maxPage = totalItems % pageSize == 0 ? totalItems / pageSize : totalItems / pageSize + 1;
                if (currentPage > 2)
                {
                    buffer += "<li><a class=\"pagination-link\" aria-label=\"Goto page 1\" href=\"javascript:" + nameFuction + "'" + 1 + "')\">&lt;&lt;</a></li>";
                }
                if (currentPage > 1)
                {
                    buffer += "<li><a class=\"pagination-link\" aria-label=\"Goto page 1\" href=\"javascript:" + nameFuction + "'" + (currentPage - 1) + "')\">&lt;</a></li>";
                }
                int count = currentPage / totalPage;
                int range = (maxPage < (count + 1) * totalPage) ? maxPage : ((count + 1) * totalPage);//?luc  nao cung bang maxPage
                int startPage = count * totalPage < currentPage ? count * totalPage + 1 : currentPage;
                for (int i = startPage; i <= range; i++)
                {
                    if (i == currentPage)
                        buffer += "<li><a class=\"pagination-link is-current\" aria-label=\"Goto page "+i+"\" href=\"javascript:" + nameFuction + "'" + i + "')\">" + i + "</a></li>";
                    else
                        buffer += "<li><a class=\"pagination-link\" aria-label=\"Goto page 1\" href=\"javascript:" + nameFuction + "'" + i + "')\">" + i + "</a></li>";
                }
                if (range < maxPage)
                {
                    buffer += "<li><a class=\"pagination-link\" aria-label=\"Goto page 1\" href=\"javascript:" + nameFuction + "'" + (range + 1) + "')\">...</a></li>";
                }

                if (currentPage < maxPage)
                {
                    buffer += "<li><a class=\"pagination-link\" aria-label=\"Goto page 1\" href=\"javascript:" + nameFuction + "'" + (currentPage + 1) + "')\">	&gt;</a></li>";
                }
                if (currentPage < maxPage - 1)
                {
                    buffer += "<li><a class=\"pagination-link\" aria-label=\"Goto page 1\" href=\"javascript:" + nameFuction + "'" + maxPage + "')\">	&gt;&gt;</a></li>";
                }


            }

        }
        catch (Exception e)
        {
        }
        return buffer;
    }

    public float getSoDuConLaiLoaiTien(LoaiTien loaiTien)
    {
        float result = 0;
        LoaiTienManagement loaiTienManagement = new LoaiTienManagement();
        DonHangManagement donHangManagement = new DonHangManagement();
        result = loaiTien.HanMuc.Value - donHangManagement.tongGiaTriGiaoDich(" where IDLoaiTien=" + loaiTien.ID + " and TrangThai=N'DaChuyenCoin'");
        return result;
    }

}