<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuLoaiTien.ascx.cs" Inherits="UserControl_MenuLoaiTien" %>

<ul class="tradeType">
        <%
            if (listLoaiTien != null) 
            {
                foreach (var loaiTien in listLoaiTien) 
                {  
             %>
                    <li><a href="/Views/Frontend/MuaBanCoin.aspx?idLoaiTien=<%=loaiTien.ID %>">Giao dịch <%=loaiTien.TenLoaiTien %></a></li>
        <%
                }
            }
           %>
        
    </ul>