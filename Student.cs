using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_3_2_2_WPF_CONVERT
{
    public class Student
    {
        //Properties:
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Months MonthOfAdmission { get; set; }
        public char Grade { get; set; }

        public void AddStudent(Student student)
        {
            //Console.WriteLine("\nEnter new student ID:");
            string studentID = Console.ReadLine();
            //Console.WriteLine("\nEnter new student First Name:");
            string firstName = Console.ReadLine();
            //Console.WriteLine("\nEnter new student Last Name:");
            string lastName = Console.ReadLine();
            //Console.WriteLine("\nEnter new student Address:");
            string addressVar = Console.ReadLine();
            //Console.WriteLine("\nEnter new student month of admission i.e. (Jan, Feb, Mar):");
            string admissionString = Console.ReadLine();
            Enum.TryParse(admissionString, out int monthNum);
            //Console.WriteLine("\nEnter new student greade:");
            char gradeVar = char.Parse(Console.ReadLine());

            DataSource.Students.Add(new Student { StudentID = studentID, FirstName = firstName, LastName = lastName, Address = addressVar, MonthOfAdmission = (Months)monthNum, Grade = 'C' });
        }

        public enum Months
        {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }

    }
}


