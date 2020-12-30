using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace Final_QR_Project.Models
{
    public class ScanModel
    {
        public List<Scan> scans { get; set; }
        public ScanModel  ()
        {
            scans = new List<Scan>();
        }
    }
}
