using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecurityInAspNet.Models.Student;

namespace SecurityInAspNet.DataServices
{
    public class StudentDataContext: DbContext
    {
        public DbSet<CourseGrade> Grades { get; set; }
       
        public StudentDataContext(DbContextOptions<StudentDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
