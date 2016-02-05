using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            4. All types in C# derive from object. 
            Create a Student class like we did this week. 
            Add Name, Grade and Gender properties. 
            Override the Equals function in your Student class to 
            allow instances of Students to compare themselves for equality. 
            Two students should be considered equal if the 
            Name and Gender properties are the same.
            */

            Student s1 = new Student { Name = "Kevin", Grade = 4.0, Gender = "Male" };
            //Student s2 = new Student { Name = "April", Grade = 4.2, Gender = "Female" };
            Student s2 = new Student { Name = "Kevin", Grade = 4.0, Gender = "Male" };

            Console.WriteLine(s1.Equals(s2).ToString());
            Console.ReadKey();

        }
    }
    class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }
        public string Gender { get; set; }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
                return false;

            Student inc = (Student)obj;
            return (Name.Equals(inc.Name, StringComparison.OrdinalIgnoreCase)
                    && Gender.Equals(inc.Gender, StringComparison.OrdinalIgnoreCase));
        }
    
    }
}
