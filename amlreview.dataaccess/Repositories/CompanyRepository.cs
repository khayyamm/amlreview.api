using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace amlreview.dataaccess
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(SchedulerContext dbContext) : base(dbContext)
        {
        }

        public async Task<Company> GetById(Guid companyId)
        {
            return await GetByGuidIdAsync(companyId);
        }
    }
}
