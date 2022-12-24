using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServerDataSharper.ServerDataBuilder;

namespace ServerDataSharper.Models
{
    public class RenewServerData
    {
        public String ApiToken { get; set; } = null!;
        public int VMId { get; set; }
        public PeriodType PeriodType { get; set; }
        public int Count { get; set; }
        public string Coupon { get; set; } = null!;
    }
}
