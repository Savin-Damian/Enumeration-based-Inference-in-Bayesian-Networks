using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Node
    {
        public string name { get; set; }
        public List<string> parents { get; set; }
        public List<Probability> probabilities { get; set; }
    }

    public class Probability
    {
        public double Da { get; set; }
        public double Nu { get; set; }
    }
}