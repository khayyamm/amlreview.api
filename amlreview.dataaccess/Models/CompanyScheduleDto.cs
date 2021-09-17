using System;
using System.Collections.Generic;
using System.Text;

namespace amlreview.application
{
    public class CompanyScheduleDto
    {
        public Guid CompanyId { get; set; }
        public List<string> Notifications { get; set; }
    }
}
