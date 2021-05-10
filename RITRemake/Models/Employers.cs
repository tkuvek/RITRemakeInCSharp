using System.Collections.Generic;

namespace RITRemake.Models
{
    /// <summary>
    /// Class Employers, partially of EmploymentViewModel
    /// </summary>
    public partial class EmploymentViewModel
    {
        public class Employers
        {
            public string title { get; set; }
            public List<string> employerNames { get; set; }
        }


    }
}
