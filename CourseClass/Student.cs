using System.Collections.Generic;

namespace StudentClass
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string id { get; set; }
        public double gpa { get; set; }
        public string standing { get; set; }
        public double credits { get; set; }
        public List<IndividualClass> classes { get; set; }

        public Student(string firstName, string lastName, string id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }
        public void RecordGrades(string className, string classGrade, double credits, double gpa)
        {
            this.gpa = gpa;
            this.credits += credits;

            IndividualClass individualClass = new IndividualClass();
            individualClass.name = className;
            individualClass.grade = classGrade;
            individualClass.credit = credits;
            classes.Add(individualClass);

            //  assumption is that each year requires 20 credits to move forward to a total of 100 credits to complete
            if (this.credits < 26)
            {
                standing = "Freshman";
            }
            else if (this.credits < 51)
            {
                standing = "Sophomore";
            }
            else if (this.credits < 76)
            {
                standing = "Junior";
            }
            else
            {
                standing = "Senior";
            }
        }
    }

    public class IndividualClass
    {
        public string name { get; set; }
        public string grade { get; set; }
        public double credit { get; set; }
    }
}
