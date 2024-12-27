using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GraphData
    {
        public List<Node> Nodes { get; set; }

        public void PrintInfo()
        {
            if (Nodes == null || !Nodes.Any())
            {
                MessageBox.Show("No nodes to display.");
                return; 
            }

            var returning = Nodes.Select(node =>
            {
                var name = node.name ?? "None";

                // Formatting names
                var parents = node.parents != null && node.parents.Any()
                    ? string.Join("\t ", node.parents) + "\n" : "";
                
                // Formatting probabilities 
                var probabilitiesInfo = node.probabilities != null && node.probabilities.Any()
                    ? string.Join("\n", node.probabilities.Select(p => $"{p.Da:F2}\t{p.Nu:F2}"))
                    : "None";

                return $"Name: {name}\n{parents} T \t F\n {probabilitiesInfo}\n";
            });

            foreach (var result in returning)
            {
                MessageBox.Show(result); // Display each node's details
            }
        }
    }
}