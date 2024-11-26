using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ALBRIGHT_ASSIGNMENT_3_2_2_WPF_CONVERT.Student;

namespace ALBRIGHT_ASSIGNMENT_3_2_2_WPF_CONVERT
{
    internal class DataSource
    {
        public static List<Student> Students;

        public static List<Student> CreateData()
        {
            Students = new List<Student>()
            {
                new Student() { StudentID = "1", FirstName = "Kevin", LastName = "Liu", Address = "1234 Lane", MonthOfAdmission = Months.Jan, Grade = 'F' },
                new Student() { StudentID = "2", FirstName = "Martin", LastName = "Weber", Address = "4567 Street", MonthOfAdmission = Months.Feb, Grade = 'A' },
                new Student() { StudentID = "3", FirstName = "George", LastName = "Li", Address = "8910 Avenue", MonthOfAdmission = Months.Mar, Grade = 'C' },
            };
            return Students;
        }
    }
}

