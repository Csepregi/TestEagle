using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace InterviewTest.Models
{
    public class Banner
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public int ImpressionCount { get; set; }

        public int ClickCount { get; set; }
    }
}