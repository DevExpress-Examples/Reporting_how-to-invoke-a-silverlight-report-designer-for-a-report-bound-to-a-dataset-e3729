Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI
Imports ReportLibrary
Imports ReportLibrary.NorthwindTableAdapters

Namespace ReportsSample.Web
	<SilverlightFaultBehavior> _
	Public Class ReportService
		Inherits DevExpress.XtraReports.Service.ReportService
		Protected Overrides Function CreateReportByName(ByVal reportName As String) As XtraReport
			Dim report = MyBase.CreateReportByName(reportName)
			Return report
		End Function
		Protected Overrides Sub RegisterDataSources(ByVal report As XtraReport, ByVal reportName As String)
			report.RegisterDataSourceName("Northwind", report.DataSource)
		End Sub
		Protected Overrides Sub FillDataSources(ByVal report As XtraReport, ByVal reportName As String, ByVal isDesignActive As Boolean)
			Dim dataSet = CType(report.GetDataSourceByName("Northwind"), Northwind)

			Using adapter = New ProductsTableAdapter()
				adapter.Fill(dataSet.Products)
			End Using
		End Sub
	End Class
End Namespace
