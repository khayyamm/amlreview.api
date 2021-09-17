using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace amlreview.dataaccess
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CompanyId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string CompanyName { get; set; }
        [RegularExpression("[0-9]{1,10}", ErrorMessage = "Please enter valid number")]
        public long CompanyNumber { get; set; }
        public CompanyType CompanyType { get; set; }
        public string Market { get; set; }

        public ICollection<CompanySchedule> Schedules { get; set; }
    }
}
