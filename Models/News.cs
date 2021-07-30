using System;
using System.Collections.Generic;

#nullable disable

namespace CourseTeachCook.Models
{
    public partial class News
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public DateTime NewsDate { get; set; }
        public string FeatureImage { get; set; }
        public string NewsDescription { get; set; }
    }
}
