using System.Collections.Generic;

namespace RITRemake.Models
{
    /// <summary>
    /// CoopTable class, partially of EmploymentViewModel
    /// </summary>
    public partial class EmploymentViewModel
    {
        public class CoopTable
        {
            public string title { get; set; }
            public List<CoopInformation> coopInformation { get; set; }
        }


    }
}
