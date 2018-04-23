Imports System
Imports DevExpress.Web

Partial Public Class [Default]
    Inherits System.Web.UI.Page

    Protected Sub ASPxComboBox1_ItemRowPrepared(ByVal sender As Object, ByVal e As ListBoxItemRowPreparedEventArgs)
        e.Row.ToolTip = e.Item.GetFieldValue("Description").ToString()
    End Sub

    Protected Sub ASPxComboBox2_Init(ByVal sender As Object, ByVal e As EventArgs)
        ASPxComboBox2.Items.Add("Test1")
        ASPxComboBox2.Items.Add("Test2")
    End Sub

    Protected Sub ASPxComboBox2_ItemRowPrepared(ByVal sender As Object, ByVal e As ListBoxItemRowPreparedEventArgs)
        e.Row.ToolTip = "Tooltip" & e.Item.Text
    End Sub
End Class