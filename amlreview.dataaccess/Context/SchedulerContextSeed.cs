using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amlreview.dataaccess
{
    public class SchedulerContextSeed
    {
       public static async Task SeedAsync(SchedulerContext schedulerContext)
        {
            try
            {
                if (!schedulerContext.Companies.Any())
                {
                    schedulerContext.Companies.AddRange(GetPreconfiguredCompanies());
                    await schedulerContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static IEnumerable<Company> GetPreconfiguredCompanies()
        {
            return new List<Company>()
            {
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b0"),CompanyName="DKCompany1",CompanyNumber=1122334455,CompanyType=CompanyType.Small,Market="DK" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b1"),CompanyName="DKCompany2",CompanyNumber=1022334455,CompanyType=CompanyType.Medium,Market="DK" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b2"),CompanyName="DKCompany3",CompanyNumber=1102334455,CompanyType=CompanyType.Large,Market="DK" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b3"),CompanyName="NOCompany1",CompanyNumber=1120334455,CompanyType=CompanyType.Small,Market="NO" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b4"),CompanyName="NOCompany2",CompanyNumber=1122034455,CompanyType=CompanyType.Medium,Market="NO" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b5"),CompanyName="NOCompany3",CompanyNumber=1122304455,CompanyType=CompanyType.Large,Market="NO" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b6"),CompanyName="SECompany1",CompanyNumber=1122330455,CompanyType=CompanyType.Small,Market="SE" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b7"),CompanyName="SECompany2",CompanyNumber=1122334055,CompanyType=CompanyType.Medium,Market="SE" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b8"),CompanyName="SECompany3",CompanyNumber=1122334405,CompanyType=CompanyType.Large,Market="SE" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a6b9"),CompanyName="FICompany1",CompanyNumber=1122334450,CompanyType=CompanyType.Small,Market="FI" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a610"),CompanyName="FICompany2",CompanyNumber=1122334450,CompanyType=CompanyType.Medium,Market="FI" },
                new Company(){CompanyId=Guid.Parse("0c92a255-77f2-4490-89f7-259385f7a611"),CompanyName="FICompany3",CompanyNumber=1122334450,CompanyType=CompanyType.Large,Market="FI" }
            };
        }
    }
}
