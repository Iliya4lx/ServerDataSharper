using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDataSharper.Models
{
    public class ChangeOsServerData
    {
        public String ApiToken { get; set; } = null!;
        public int VMId { get; set; }
        public int DiskId { get; set; }
        public string Coupon { get; set; } = null!;
    }
}
