namespace Codecamp_Exercise_2
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public static int numberOfTeacher;
        public Teacher(string name, string subject)
        {
            this.Name = name;
            this.Subject = subject;
            numberOfTeacher++;
        }
        
        public static int countTeacher()
        {
            return numberOfTeacher;
        }
        
    }
}