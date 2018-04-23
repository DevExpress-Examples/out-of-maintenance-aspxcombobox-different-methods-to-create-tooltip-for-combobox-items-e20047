Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ASPxComboBox1_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim dv As DataView = DirectCast(AccessDataSource1.Select(DataSourceSelectArguments.Empty), DataView)
        For Each row As DataRowView In dv
            row("CategoryName") = String.Format("<span title = '{0}'> {1} </span>", row("Description"), row("CategoryName"))
        Next row
        ASPxComboBox1.DataSource = dv
        ASPxComboBox1.DataBind()
    End Sub
    Protected Sub ASPxComboBox3_Init(ByVal sender As Object, ByVal e As EventArgs)
        ASPxComboBox3.Items.Add(String.Format("<span title = '{0}'>{1}</span>", "ToolTipTest1", "Test1"), "Test1")
        ASPxComboBox3.Items.Add(String.Format("<span title = '{0}'>{1}</span>", "ToolTipTest2", "Test2"), "Test2")
    End Sub
End Class