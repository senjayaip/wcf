using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.XtraReports.UI;


namespace test15
{
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            // show report
            XtraReport1 r = new XtraReport1();
            r.DataSource = client.GetData().Reportsrc2.ToList();
            r.CreateDocument();
            r.ShowRibbonPreviewDialog();


        }

    }


}
