namespace Codecamp_Exercise_2
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static int numberOfStudent;
        
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            numberOfStudent++;
        }
        public static int countStudent()
        {
            return numberOfStudent;
        }
        
    }
}