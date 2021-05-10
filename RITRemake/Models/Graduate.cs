﻿using System.Collections.Generic;

namespace RITRemake.Models
{
    public partial class DegreesViewModel
    {
        /// <summary>
        /// Graduate class, partially of DegreesViewModel
        /// </summary>
        public class Graduate
        {
            public string degreeName { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public List<string> concentrations { get; set; }
            public List<string> availableCertificates { get; set; }
        }
    }
}
