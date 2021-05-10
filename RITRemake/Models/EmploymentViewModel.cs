using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RITRemake.Models
{
    /// <summary>
    /// Partial class EmploymentViewModel, consists of multiple classes
    /// </summary>
    public partial class EmploymentViewModel
    {

            public Introduction introduction { get; set; }
            public DegreeStatistics degreeStatistics { get; set; }
            public Employers employers { get; set; }
            public Careers careers { get; set; }
            public CoopTable coopTable { get; set; }
            public EmploymentTable employmentTable { get; set; }
   
    }
}
