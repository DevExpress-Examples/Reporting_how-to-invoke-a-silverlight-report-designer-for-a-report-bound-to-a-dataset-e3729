using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.Service;
using DevExpress.XtraReports.UI;
using ReportLibrary;
using ReportLibrary.NorthwindTableAdapters;

namespace ReportsSample.Web {
    [SilverlightFaultBehavior]
    public class ReportService : DevExpress.XtraReports.Service.ReportService {
        protected override XtraReport CreateReportByName(string reportName) {
            var report = base.CreateReportByName(reportName);
            return report;
        }
        protected override void RegisterDataSources(XtraReport report, string reportName) {
            report.RegisterDataSourceName("Northwind", report.DataSource);
        }
        protected override void FillDataSources(XtraReport report, string reportName, bool isDesignActive) {
            var dataSet = (Northwind)report.GetDataSourceByName("Northwind");

            using(var adapter = new ProductsTableAdapter())
                adapter.Fill(dataSet.Products);
        }
    }
}
