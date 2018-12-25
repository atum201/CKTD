using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Default : System.Web.UI.Page
{
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();
    public IList<LoaiTien> listLoaiTien;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        listLoaiTien = loaiTienManagement.getLoaiTien(" where TrangThai like N'KichHoat' order by ThuTu asc");
    }
}