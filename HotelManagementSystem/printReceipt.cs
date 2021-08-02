using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class printReceipt : Form
    {

        List<Receipt> _list;
        string _total; string _date;

        public printReceipt(List<Receipt> datasource, string total, string date)
        {
            InitializeComponent();
            _list = datasource;
            _total = total;
            _date = date;
        }


        private void printReceipt_Load(object sender, EventArgs e)
        {
            ReceiptBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] parameter = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", _total),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date)
            };
            this.reportViewer.LocalReport.SetParameters(parameter);
            this.reportViewer.RefreshReport();
        }
    }
}
