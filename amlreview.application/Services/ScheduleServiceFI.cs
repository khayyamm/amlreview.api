using amlreview.dataaccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace amlreview.application
{
    public class ScheduleServiceFI : IScheduleService
    {
        private readonly int[] days = { 1, 5, 10, 15, 20 };

        public CompanyScheduleDto CreateNotification(Company company)
        {
            if (company.CompanyType != CompanyType.Large)
                return new CompanyScheduleDto();

            DateTime date = DateTime.Now;

            var companyNotification = new CompanyScheduleDto();

            companyNotification.CompanyId = company.CompanyId;

            var dateStrings = new List<string>();

            foreach (var day in days)
            {
                dateStrings.Add(date.AddDays(day).ToString(MarketConstants.DateFormat));
            }

            companyNotification.Notifications = dateStrings;

            return companyNotification;
        }
    }
}
