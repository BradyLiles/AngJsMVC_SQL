using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Net.Cache;
using System.Web;

namespace egDotNetMVC.Models.Courses
{
    public class CourseVm
    {
        [Key]
        public int CourseId { get; set; }
        public string Course { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
    }

    public class CourseVmContext : DbContext
    {
        public CourseVmContext()
        {
            this.Database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public DbSet<CourseVm> CourseVms { get; set; }
    }
}