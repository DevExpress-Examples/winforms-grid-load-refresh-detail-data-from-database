<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628270/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1173)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Dynamically load and refresh detail data from the database

This example shows how to load only the required data on demand when the detail view is open. This can be useful if the grid control is bound to a large set of detailed data and you do not want to load the entire data table. The example also shows how to update the data in the detail view without re-expanding the main row.


* Handle [master-detail-related events](https://docs.devexpress.com/WindowsForms/732/controls-and-libraries/data-grid/master-detail/working-with-master-detail-relationships-in-code) to avoid excessive database queries.
* Reload the underlying data table to refresh a detail view. If the child list implements the `IBindingList` interface, the corresponding detail view will be automatically refreshed. Otherwise, you should explicitly call the [RefreshData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.RefreshData) method.

> **Note**
> 
> Consider using a WinForms Data Grid in [server mode](https://docs.devexpress.com/WindowsForms/8398/controls-and-libraries/data-grid/data-binding/large-data-sources-server-and-instant-feedback-modes).


## Files to Review
* [Form1.cs](./CS/WindowsApplication297/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication297/Form1.vb))


## Documentation

* [Master-Detail Relationships](https://docs.devexpress.com/WindowsForms/3473/controls-and-libraries/data-grid/master-detail-relationships)
* [Working with Master-Detail Relationships in Code](https://docs.devexpress.com/WindowsForms/732/controls-and-libraries/data-grid/master-detail/working-with-master-detail-relationships-in-code)


## See Also

* [DevExpress WinForms Cheat Sheets - XtraGrid Master-Detail Mode](https://go.devexpress.com/CheatSheets_WinForms_Examples_T919464.aspx)
* [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-load-refresh-detail-data-from-database&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-load-refresh-detail-data-from-database&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
