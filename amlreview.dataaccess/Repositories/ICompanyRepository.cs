using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace amlreview.dataaccess
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetById(Guid companyId);
    }
}
