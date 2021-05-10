using System.Collections.Generic;
/// <summary>
/// Carreers class, partially part of EmploymentViewModel
/// </summary>
namespace RITRemake.Models
{
    public partial class EmploymentViewModel
    {
        public class Careers
        {
            public string title { get; set; }
            public List<string> careerNames { get; set; }
        }


    }
}
