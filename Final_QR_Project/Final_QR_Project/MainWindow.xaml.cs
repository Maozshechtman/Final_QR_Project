using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using ZXing;
using System.Drawing;
namespace Final_QR_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void QRCodebtn_Click(object sender, RoutedEventArgs e)
        {
            //Parse Qr CODE
            var qrcodebitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\user\source\repos\Final_QR_Project\Final_QR_Project\Images\test1.png");
            var qrCodeReader = new BarcodeReader();
            var qrCodeResult = qrCodeReader.Decode(qrcodebitmap) ; 
             
            QRCodeTB.Text = qrCodeResult.Text;
        }
    }
}
