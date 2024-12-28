using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GraphData
    {
        public List<Node> Nodes { get; set; }

        public void ShowInfo(Node node)
        {
            if (node == null)
            {
                MessageBox.Show("This node is null");
                return;
            }
            else
            {
                MessageBox.Show(NodeInfoFormat(node)); // Display node's details
            }
        }

        // return formatted node information
        public string NodeInfoFormat(Node node)
        {
            var name = node.name != null ? ($"Name: {node.name}") + "\n" : "None";
            var parents = node.parents.Count() != 0 ? 
                "Parents: " + string.Join(", ", node.parents) + "\n" : null;
            var probabilities = node.probabilities != null ? 
                string.Join("\t\n\t", node.probabilities.Select(elem => $"{elem.Da:F2}\t{elem.Nu:F2}")) : "None";

            return $"{name}{parents} \tT\t F \n\t{probabilities}\n";
        }
    }
}
