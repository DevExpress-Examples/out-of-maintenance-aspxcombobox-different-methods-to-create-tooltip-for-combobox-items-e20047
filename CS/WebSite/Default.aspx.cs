using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxComboBox1_Init(object sender, EventArgs e)
    {
        DataView dv = (DataView)AccessDataSource1.Select(DataSourceSelectArguments.Empty);
        foreach (DataRowView row in dv)
            row["CategoryName"] = string.Format("<span title = '{0}'> {1} </span>", row["Description"], row["CategoryName"]);
        ASPxComboBox1.DataSource = dv;
        ASPxComboBox1.DataBind();
    }
    protected void ASPxComboBox3_Init(object sender, EventArgs e)
    {
        ASPxComboBox3.Items.Add(String.Format("<span title = '{0}'>{1}</span>", "ToolTipTest1", "Test1"), "Test1");
        ASPxComboBox3.Items.Add(String.Format("<span title = '{0}'>{1}</span>", "ToolTipTest2", "Test2"), "Test2");
    }
}