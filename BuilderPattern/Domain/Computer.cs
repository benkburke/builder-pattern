using System.Collections.Generic;

namespace BuilderPattern.Domain
{
    public class Computer
    {
        public ComputerModel Model { get; set; }             

        // List of parts and the count of each
        public Dictionary<Part, int> Parts = new Dictionary<Part, int>();
    }
}
