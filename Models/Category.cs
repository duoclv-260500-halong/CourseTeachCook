using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public Category GetCategory(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Category category = system.Categories.Find(id);
                return category;
            }
        }
        public List<Category> GetCategories()
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Category> categories = new List<Category>();
                categories = system.Categories.Take(7).ToList();
                return categories;
            }
        }
        public Category ViewCategory(int id){
            using (var connect = new CourseTeachingCookContext())
            {
                Category category = new Category();

                category = connect.Categories.Find(id);

                return category;
            }
        }
        
        public bool ChangeCategory(int id, string categoryName)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Category category = system.Categories.Find(id);
                category.CategoryName = categoryName;
                system.Categories.Update(category);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }

            }
        }
    }
}
