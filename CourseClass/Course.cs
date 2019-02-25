using System;
using System.Collections.Generic;
using StudentClass;

namespace CourseClass
{
    public class Course
    {
        public string name { get; set; }
        public string id { get; set; }
        public int seatsAvailable { get; set; }

        public List<Student> students { get; set; }

        public Course(string name, int seatsAvailable)
        {
            this.name = name;
            this.seatsAvailable = seatsAvailable;
        }

        public bool AddStudentToCourse(Student student)
        {
            if (students.Count < seatsAvailable)
            {
                Student newStudent = new Student(student.firstName, student.lastName, student.id);
                students.Add(newStudent);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DropStudent(Student student)
        {
            foreach (Student enrolledStudent in students)
            {
                if (enrolledStudent.id == student.id)
                {
                    students.Remove(enrolledStudent);
                    return true;
                }
            }

            return false;
        }
        public double GetStudentAverageGPA()
        {
            double sumGrades = 0;

            foreach (Student enrolledStudent in students)
            {
                sumGrades += enrolledStudent.gpa;
            }

            return sumGrades / students.Count;
        }
    }


}
