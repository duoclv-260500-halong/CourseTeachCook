using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Imagescourse
    {
        public int ImageId { get; set; }
        public string ImageSource { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public List<Imagescourse> GetImagescourses(int id)
        {
            using (var connect = new CourseTeachCookContext())
            {
                List<Imagescourse> images = connect.Imagescourses.Where(I => I.CourseId==id).ToList();
                return images;
            }
        }
    }
}
