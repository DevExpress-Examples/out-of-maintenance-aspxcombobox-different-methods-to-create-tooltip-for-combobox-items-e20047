<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>ASPxComboBox: Three Different Methods to Create ToolTip for ComboBox Items</title>
</head>
<body>
    <form id="form1" runat="server">
        <strong>Categories: </strong>
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ForceDataBinding="true" TextField="CategoryName" ValueField="CategoryID"
            ValueType="System.Int32" DataSourceID="AccessDataSource1" OnItemRowPrepared="ASPxComboBox1_ItemRowPrepared" />
        (Items are created on the server/database side)
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]" />
        <br />
        <br />
        <strong>Custom values: </strong>
        <dx:ASPxComboBox ID="ASPxComboBox2" runat="server" OnInit="ASPxComboBox2_Init" OnItemRowPrepared="ASPxComboBox2_ItemRowPrepared"/>
        (ASPxComboBox is populated at runtime)
    </form>
</body>
</html>