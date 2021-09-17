using amlreview.application;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace amlreview.dataaccess
{
    public interface IScheduleRepository : IRepository<CompanySchedule>
    {
        Task<CompanySchedule> SaveSchedule(CompanySchedule companySchedule);

        Task SaveRange(CompanyScheduleDto companyScheduleDtos);
       
    }
}
