using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcapp.Models
{
    public class StudentMemoryDataSet
    {
        List<Student> dtset;
        public StudentMemoryDataSet()
        {
            dtset = new List<Student>()
            {
                new Student {Id=1111111,Name="User11", CourseId=11},
                new Student {Id=2222222,Name="User22", CourseId=22},
                new Student {Id=3333333,Name="User33", CourseId=33}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return dtset;
        }
    }
}