using amlreview.dataaccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace amlreview.application
{
    public class ScheduleServiceDK : IScheduleService
    {
        private readonly int[] days = { 1, 5, 10, 15, 20 };        

        public CompanyScheduleDto CreateNotification(Company company)
        {
            DateTime date = DateTime.Now;

            var companyNotificatoin = new CompanyScheduleDto();

            companyNotificatoin.CompanyId = company.CompanyId;

            var dateStrings = new List<string>();

            foreach (var day in days)
            {
                dateStrings.Add(date.AddDays(day).ToString(MarketConstants.DateFormat));
            }

            companyNotificatoin.Notifications = dateStrings;

            return companyNotificatoin;
        }
    }
}
