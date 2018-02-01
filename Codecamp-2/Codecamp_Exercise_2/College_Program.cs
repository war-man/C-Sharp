using System.Collections.Generic;

namespace Codecamp_Exercise_2
{
    public class College_Program
    {
        public string ProgramName { get; set; }
        public List<Degree> DegreeList { get; set; } = new List<Degree>();
        
        public void AddDegree(Degree degree)
        {
            DegreeList.Add(degree);
            //return this.DegreeList;
        }

        public College_Program(string program)
        {
            this.ProgramName = program;
        }
        
    }
}