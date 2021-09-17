using System;
using System.Collections.Generic;
using System.Text;

namespace amlreview.application
{
    public class ServiceResolver
    {
        public static IScheduleService GetNamedSceduleServiceByMarket(string market) => market switch
        {
            MarketConstants.DENMARK =>new ScheduleServiceDK(),
            MarketConstants.NORWAY => new ScheduleServiceNO(),
            MarketConstants.SWEDEN => new ScheduleServiceSE(),
            MarketConstants.FINLAND => new ScheduleServiceFI(),
            _ => null,
        };
    }
}
