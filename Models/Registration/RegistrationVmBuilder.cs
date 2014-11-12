using egDotNetMVC.Models.Courses;
using egDotNetMVC.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace egDotNetMVC.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };
            return registrationVm;
        }

        public string GetSerializedCourses()
        {
            var courseData = new[]
            {
                new CourseVm { Course = "CS101", Name = "AngularJs Fundamentals", Instructor = "Larry Page" },
                new CourseVm { Course = "CS102", Name = "OOP Design", Instructor = "Steve Jobs" },
                new CourseVm { Course = "CS103", Name = "C++ Programming", Instructor = "Linus Torvalds" }
            };
            var jsonSettings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courseData, jsonSettings);
        }

        public string GetSerializedInstructors()
        {
            var instructorData = new[]
            {
                new InstructorVm { Name = "Larry Page", Email = "LarryPage@Google.com", RoomNumber = 100 },
                new InstructorVm { Name = "Steve Jobs", Email = "SteveJobs@Apple.com", RoomNumber = 200 },
                new InstructorVm { Name = "Linus Torvalds", Email = "LinusTorvalds@Linux.com", RoomNumber = 300 }
            };
            var jsonSettings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(instructorData, jsonSettings);
        }
    }
}