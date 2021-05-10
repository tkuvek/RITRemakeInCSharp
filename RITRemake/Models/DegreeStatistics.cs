using System.Collections.Generic;

namespace RITRemake.Models
{
    /// <summary>
    /// DegreeStatistics class, partially of EmploymentViewModel
    /// </summary>
    public partial class EmploymentViewModel
    {
        public class DegreeStatistics
        {
            public string title { get; set; }
            public List<Statistic> statistics { get; set; }
        }


    }
}
