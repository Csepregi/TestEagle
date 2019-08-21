using InterviewTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTest.Models
{
    public class Validation
    {
        [AtLeastOneRequired("State", "Region", "Phone", ErrorMessage = "At least state or region is required")]
        public string State { get; set; }

        public string Region { get; set; }
    }
}