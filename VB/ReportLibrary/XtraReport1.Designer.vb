Imports Microsoft.VisualBasic
Imports System
Namespace ReportLibrary
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim swiftPlotDiagram1 As New DevExpress.XtraCharts.SwiftPlotDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim swiftPlotSeriesView1 As New DevExpress.XtraCharts.SwiftPlotSeriesView()
			Dim swiftPlotSeriesView2 As New DevExpress.XtraCharts.SwiftPlotSeriesView()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
			Me.productsTableAdapter = New ReportLibrary.NorthwindTableAdapters.ProductsTableAdapter()
			Me.northwind1 = New ReportLibrary.Northwind()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(swiftPlotSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 23F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "UnitPrice")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(286.0418F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(86.95822F, 22.99999F)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ProductName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.0001F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(276.0417F, 23F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrChart1
			' 
			Me.xrChart1.AppearanceName = "In A Fog"
			Me.xrChart1.BorderColor = System.Drawing.Color.Black
			Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChart1.DataAdapter = Me.productsTableAdapter
			Me.xrChart1.DataMember = "Products"
			Me.xrChart1.DataSource = Me.northwind1
			swiftPlotDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
			swiftPlotDiagram1.AxisX.Label.BeginText = "_"
			swiftPlotDiagram1.AxisX.Label.EndText = "_"
			swiftPlotDiagram1.AxisX.Label.Visible = False
			swiftPlotDiagram1.AxisX.Range.SideMarginsEnabled = True
			swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram1.AxisY.Range.SideMarginsEnabled = True
			swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			swiftPlotDiagram1.PaneDistance = 100
			Me.xrChart1.Diagram = swiftPlotDiagram1
			Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrChart1.Name = "xrChart1"
			Me.xrChart1.PaletteName = "Aspect"
			series1.ArgumentDataMember = "ProductName"
			series1.Name = "productsSeries"
			series1.ShowInLegend = False
			series1.ValueDataMembersSerializable = "UnitPrice"
			series1.View = swiftPlotSeriesView1
			Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.xrChart1.SeriesTemplate.View = swiftPlotSeriesView2
			Me.xrChart1.SizeF = New System.Drawing.SizeF(362.9999F, 200F)
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' northwind1
			' 
			Me.northwind1.DataSetName = "Northwind"
			Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart1})
			Me.ReportHeader.HeightF = 200F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.northwind1
			Me.PageHeight = 827
			Me.PageWidth = 583
			Me.PaperKind = System.Drawing.Printing.PaperKind.A5
			Me.ReportPrintOptions.DetailCountAtDesignTime = 4
			Me.Version = "11.2"
			CType(swiftPlotDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(swiftPlotSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrChart1 As DevExpress.XtraReports.UI.XRChart
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private northwind1 As Northwind
		Private productsTableAdapter As NorthwindTableAdapters.ProductsTableAdapter
	End Class
End Namespace
