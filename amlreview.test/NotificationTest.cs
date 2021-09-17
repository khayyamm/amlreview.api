using amlreview.application;
using amlreview.dataaccess;
using NUnit.Framework;
using System;

namespace amlreview.test
{
    public class NotificationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Company_Notification_Test()
        {
            IScheduleService scheduleService = new ScheduleServiceDK();

            var company = new Company()
            {
                CompanyId = Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b0"),
                CompanyName = "Test",
                CompanyNumber = 1234567890,
                CompanyType = CompanyType.Medium,
                Market = "DK"
            };

            var result = scheduleService.CreateNotification(company);

            Assert.AreEqual(Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b0"), result.CompanyId);
            Assert.AreEqual(DateTime.Now.AddDays(1).ToString(MarketConstants.DateFormat), result.Notifications[0]);
        }
    }
}