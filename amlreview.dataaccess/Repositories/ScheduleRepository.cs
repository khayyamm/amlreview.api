using amlreview.application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace amlreview.dataaccess
{
    public class ScheduleRepository :Repository<CompanySchedule>, IScheduleRepository
    {
        public ScheduleRepository(SchedulerContext dbContext) : base(dbContext)
        {
        }

        public async Task SaveRange(CompanyScheduleDto companyScheduleDto)
        {
            foreach (var notification in companyScheduleDto.Notifications)
            {
                await SaveSchedule(new CompanySchedule() { CompanyId = companyScheduleDto.CompanyId, NotificationDate = notification });
            }
        }

        public async Task<CompanySchedule> SaveSchedule(CompanySchedule companySchedule)
        {
            return await AddAsync(companySchedule);
        }
    }
}
