# How to dynamically load and refresh detail data from the database


<p>The task:<br />
We have a huge detail data set, and we don't want to load the entire table. How can we load only the required data on demand, when the detail view is open.<br />
We also want to refresh detail view data by requesting it from the database, without re-expanding the master row.</p><p>The solution:<br />
This functionality can be implemented by handling the grid's MasterRow~ events. You should keep tracing created data views to avoid excessive database queries. To refresh a detail view, reload the underlying data table. If the child list implements the IBindingList interface, the corresponding detail view will be automatically refreshed. Otherwise, you should explicitly call the BaseView.RefreshData method.</p><p>Please also consider using the XtraGrid in server mode (see the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument2990">Server Mode</a> help topic).</p>

<br/>


