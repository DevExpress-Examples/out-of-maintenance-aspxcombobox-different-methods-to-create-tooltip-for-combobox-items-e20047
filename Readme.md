<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128530622/12.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20047)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxComboBox - Different methods to create ToolTip for ComboBox items
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e20047/)**
<!-- run online end -->


<p><strong>UPDATE:</strong><br><br></p>
<p>Starting with 16.2, we have implemented the <a href="http://help.devexpress.com/#AspNet/DevExpressWebASPxAutoCompleteBoxBase_ItemTextCellPreparedtopic">ItemTextCellPrepared</a> and <a href="http://help.devexpress.com/#AspNet/DevExpressWebASPxAutoCompleteBoxBase_ItemRowPreparedtopic">ItemRowPrepared</a> events that allow accomplishing the same task with less effort and do not require so much extra code. Moreover, with a newer approach, you do not need to disable the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxButtonEditBase_EncodeHtmltopic">EncodeHtml</a> setting. This should help protect target webpages against XSS attacks. Note that if you bind the <a href="http://help.devexpress.com/#AspNet/clsDevExpressWebASPxComboBoxtopic">ASPxComboBox</a> control to data via the <strong>DataSourceID</strong> property, rather than the <strong>DataSource</strong> one, and use the item's <a href="http://help.devexpress.com/#AspNet/DevExpressWebListEditItemBase_GetFieldValuetopic">GetFieldValue</a> method in one of the aforementioned events, it is mandatory to enable the <a href="http://help.devexpress.com/#AspNet/DevExpressWebASPxAutoCompleteBoxBase_ForceDataBindingtopic">ForceDataBinding</a> option, so that actual data is applied on every round trip to the server.</p>
<p><br><strong>Prior to 16.2:</strong></p>
<p><br>This example demonstrates how to create a tooltip for each ComboBox item. In the first pair of ASPxComboBoxes, items are read from the database and converted from plain text to HTML code (<span title=’Description’>CategoryName</span>). In the third ComboBox, its items are added at runtime using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebListEditItemCollection_Addtopic">ASPxComboBox.Items.Add</a> method. Please note that it's necessary to use this method with 2 parameters: text and value separately, otherwise the HTML string will be used as a value of an7 item and will be sent to the server on a callback. In this case, ASP.NET environment automatically stops the execution of server-side operations and raises <a href="http://msdn.microsoft.com/en-us/library/system.web.httprequestvalidationexception.aspx">HttpRequestValidationException</a>.</p>
<p>The “EncodeHtml” property of ASPxComboBox is set to “false” to guarantee that the HTML code is executed.</p>
<p>In the first and third methods, the HTML code is created on the server side in the “ASPxComboBox_Init” event.</p>
<p>In the second method, the HTML code is created by modifying the select command of the data source.</p>

<br/>


