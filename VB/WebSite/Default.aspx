<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v12.1, Version=12.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>ASPxComboBox: Two Different Methods to Create ToolTip for ComboBox Items</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<strong>Categories: </strong>
		<dx:ASPxComboBox ID="ASPxComboBox1" runat="server" TextField="CategoryName" ValueField="CategoryID"
			OnInit="ASPxComboBox1_Init" EncodeHtml="False" ValueType="System.Int32">
		</dx:ASPxComboBox>
		(Items are created on the server side)
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind.mdb"
			SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]">
		</asp:AccessDataSource>
		<br />
		<br />
		<strong>Categories: </strong>
		<dx:ASPxComboBox ID="ASPxComboBox2" runat="server" DataSourceID="AccessDataSource2"
			EncodeHtml="False" TextField="CustomDataField" ValueField="CategoryID" ValueType="System.Int32">
		</dx:ASPxComboBox>
		(Items are created on the database side)
		<asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/Northwind.mdb"
			SelectCommand="Select [CategoryID], &quot;&lt;span title='&quot;+[Description]+&quot;'&gt;&quot;+[CategoryName]+&quot;&lt;/span&gt;&quot; as [CustomDataField] FROM Categories">
		</asp:AccessDataSource>
	</div>
	</form>
</body>
</html>