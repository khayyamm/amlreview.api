using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace amlreview.dataaccess
{
    public class CompanySchedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public string NotificationDate { get; set; }
        public Company Company { get; set; }
    }
}
