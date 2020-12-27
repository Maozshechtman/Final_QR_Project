using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using System.Drawing;
namespace BL
{
    class QRCodeDecoder
    {
        static string GetDataFromQRCode(string url)
        {
            var qrcodebitmap = (Bitmap)Bitmap.FromFile(url);
            var qrCodeReader = new BarcodeReader();
            var qrCodeResult = qrCodeReader.Decode(qrcodebitmap);
           return qrCodeResult.Text;

        }
    }
}
