using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeReview_DotNetU
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
    }
}
