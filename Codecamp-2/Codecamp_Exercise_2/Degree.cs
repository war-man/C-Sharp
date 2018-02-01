using System.Collections.Generic;

namespace Codecamp_Exercise_2
{
    public class Degree
    {
        public string DegreeName { get; set; }
        public List<Course> courseList { get; set; } = new List<Course>();
        
        public Degree(string degree)
        {
            this.DegreeName = degree;
        }

        public void AddCourse(Course course)
        {
            courseList.Add(course);
        }

        public class Course
        {
            public string CourseName { get; set; }
            public List<Teacher> teacherList { get; set; } =  new List<Teacher>();
            public List<Student> studentList { get; set; } =  new List<Student>();
            public Course(string course)
            {
                this.CourseName = course;
            }

            public void addTeacher(Teacher teacher)
            {
                this.teacherList.Add(teacher);
            }

            public void addStudent(Student student)
            {
                this.studentList.Add(student);
            }
        }
        
    }
}