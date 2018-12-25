<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TraCuu.aspx.cs" Inherits="Views_Frontend_TraCuu" %>
<%@ Register TagPrefix="uc" TagName="MenuLoaiTien" Src="~/UserControl/MenuLoaiTien.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <uc:MenuLoaiTien runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <form runat="server" class="searchTrade">
	<div class="formInner">
		<div class="field is-horizontal is-alignCenter">
			<div class="field-label">
				<label class="label">Nhập mã</label>
			</div>
			<div class="field-body">
				<div class="field">
					<div class="control">
                        <asp:TextBox runat="server" ID="txtMaTraCuu" CssClass="input"></asp:TextBox>
					</div>
                    <p class="help btcLeft">
                        <asp:Label runat="server" ID="lblMessage"></asp:Label>
                    </p>
				</div>
			</div>
		</div>
		<div class="formFooter">
            <asp:Button runat="server" ID="btnTraCuu" CssClass="button" Text="Tra cứu" OnClick="btnTraCuu_Click" />
		</div>
	</div>
</form>
</asp:Content>

