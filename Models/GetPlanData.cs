using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServerDataSharper.ServerDataBuilder;

namespace ServerDataSharper.Models
{
    public class GetPlanData
    {
        public String ApiToken { get; set; } = null!;
        public int LocationId { get; set; }
        public int PlanId { get; set; }
        public PeriodType PeriodType { get; set; }
    }
}
