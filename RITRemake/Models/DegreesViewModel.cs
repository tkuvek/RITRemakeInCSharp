using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RITRemake.Models
{
    /// <summary>
    /// Partial class DegreesViewModel, consists of undergraduate, graduate, faculty and about
    /// </summary>
    public partial class DegreesViewModel
    {
            public List<Undergraduate> undergraduate { get; set; }
            public List<Graduate> graduate { get; set; }
            public Faculty[] faculty { get; set; }
            public About[] about { get; set; }
    }

}
