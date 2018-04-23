using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace GetThePageNumber {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            if (e.PageCount > 0) {
                // Check if the control is printed on the first page.
                if (e.PageIndex == 0) {
                    // Cancels the control's printing.
                    e.Cancel = true;
                }
            }
        }

    }
}