using System.Collections.Generic;

namespace RITRemake.Models
{
    /// <summary>
    /// EmploymentTable class, partialyy of EmploymentViewModel
    /// </summary>
    public partial class EmploymentViewModel
    {
        public class EmploymentTable
        {
            public string title { get; set; }
            public List<ProfessionalEmploymentInformation> professionalEmploymentInformation { get; set; }
        }


    }
}
