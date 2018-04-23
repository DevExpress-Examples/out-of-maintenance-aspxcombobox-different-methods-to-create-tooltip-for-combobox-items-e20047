using System;
using DevExpress.Web;

public partial class Default : System.Web.UI.Page {
    protected void ASPxComboBox1_ItemRowPrepared(object sender, ListBoxItemRowPreparedEventArgs e) {
        e.Row.ToolTip = e.Item.GetFieldValue("Description").ToString();
    }

    protected void ASPxComboBox2_Init(object sender, EventArgs e) {
        ASPxComboBox2.Items.Add("Test1");
        ASPxComboBox2.Items.Add("Test2");
    }

    protected void ASPxComboBox2_ItemRowPrepared(object sender, ListBoxItemRowPreparedEventArgs e) {
        e.Row.ToolTip = "Tooltip"  + e.Item.Text;
    }
}