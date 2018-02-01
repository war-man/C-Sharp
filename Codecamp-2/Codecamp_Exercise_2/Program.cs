using System;

namespace Codecamp_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            College_Program college_Program = new College_Program("Information Technology");
            Degree bachelor = new Degree("Bachelor");
            Degree master = new Degree("Master");

            college_Program.AddDegree(bachelor);
            college_Program.AddDegree(master);

            Console.WriteLine($"Welcome to {college_Program.ProgramName} program");
            Console.WriteLine($"This program has {college_Program.DegreeList.Count} degrees:");

            foreach (var item in college_Program.DegreeList)
            {
                Console.WriteLine(item.DegreeName);
            }

            Console.WriteLine("---------------------------------------------------------------");

            bachelor.AddCourse(new Degree.Course("Programming with C#"));
            bachelor.AddCourse(new Degree.Course("Javascript for beginner"));

            Console.WriteLine(
                $"The Bachelor degree has {college_Program.DegreeList[0].courseList.Count} courses:"
            );

            foreach (var item in bachelor.courseList)
            {
                Console.WriteLine(item.CourseName);
            }

            Console.WriteLine("---------------------------------------------------------------");

            Student duy = new Student("Duy", 20);
            Student thai = new Student("Thai", 21);
            Student ducanh = new Student("Duc Anh", 22);
            Student hiep = new Student("Hiep", 23);
            Student hieu = new Student("Hieu", 24);

            Teacher linh = new Teacher("Linh", "C# basics");
            Teacher huy = new Teacher("Huy", "Data structure and Algorithm");

            bachelor.courseList[0].addStudent(duy);
            bachelor.courseList[0].addStudent(thai);
            bachelor.courseList[0].addStudent(hieu);
            bachelor.courseList[0].addTeacher(linh);

            bachelor.courseList[1].addStudent(duy);
            bachelor.courseList[1].addStudent(thai);
            bachelor.courseList[1].addStudent(ducanh);
            bachelor.courseList[1].addStudent(hiep);
            bachelor.courseList[1].addTeacher(linh);
            bachelor.courseList[1].addTeacher(huy);

            Console.WriteLine($"Total number of students: {Student.countStudent()}");
            Console.WriteLine($"Total number of teachers: {Teacher.countTeacher()}");

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine(
                $"{bachelor.courseList[0].CourseName} has {bachelor.courseList[0].studentList.Count} students and {bachelor.courseList[0].teacherList.Count} teachers"
            );
            Console.WriteLine("List of students:");
            foreach (var student in bachelor.courseList[0].studentList)
            {
                Console.WriteLine($"Name: {student.Name} - Age: {student.Age}");   
            }
            Console.WriteLine("List of teachers:");
            foreach (var teacher in bachelor.courseList[0].teacherList)
            {
                Console.WriteLine($"Name: {teacher.Name} - Subject: {teacher.Subject}");   
            }

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine(
                $"{bachelor.courseList[1].CourseName} has {bachelor.courseList[1].studentList.Count} students and {bachelor.courseList[1].teacherList.Count} teachers"
            );
            Console.WriteLine("List of students:");
            foreach (var student in bachelor.courseList[1].studentList)
            {
                Console.WriteLine($"Name: {student.Name} - Age: {student.Age}");   
            }
            Console.WriteLine("List of teachers:");
            foreach (var teacher in bachelor.courseList[1].teacherList)
            {
                Console.WriteLine($"Name: {teacher.Name} - Subject: {teacher.Subject}");   
            }
        }
    }
}
