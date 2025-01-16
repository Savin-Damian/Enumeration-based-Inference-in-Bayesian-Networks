using System;
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
                MessageBox.Show(NodeInfoFormat(node)); // afisam datele nodului
            }
        }

        private string NodeInfoFormat(Node node)
        {
            var name = node.name != null ? ($"Name: {node.name}") + "\n" : "None";
            var parents = node.parents.Count() != 0 ? 
                "Parents: " + string.Join(", ", node.parents) + "\n" : null;
            var probabilities = node.probabilities != null ? 
                string.Join("\t\n\t", node.probabilities.Select(elem => $"{elem.Da:F2}\t{elem.Nu:F2}")) : "None";

            return $"{name}{parents} \tT\t F \n\t{probabilities}\n";
        }   
        private void CalculateNodeProbability(Node node, Dictionary<string, string> _nodeValues, GraphData _graphData)
        {
            // verificam daca nodul este vizibil
            if (_nodeValues.ContainsKey(node.name))
            {
                return;
            }

            // Cazul fara parinti
            if (node.parents.Count == 0)
            {
                return; 
            }

            // Cazul cu un singur parinte
            if (node.parents.Count == 1)
            {
                string parentName = node.parents[0];
                Node parentNode = _graphData.Nodes.First(n => n.name == parentName);

                double probParentTrue = parentNode.probabilities[0].Da;
                double probParentFalse = parentNode.probabilities[0].Nu;

                double probTrue = probParentTrue * node.probabilities[0].Da + probParentFalse * node.probabilities[1].Da;
                double probFalse = 1 - probTrue;

                node.probabilities[0].Da = probTrue;
                node.probabilities[0].Nu = probFalse;
            }

            // Cazul cu doi parinti
            else if (node.parents.Count == 2)
            {
                string parent1Name = node.parents[0];
                string parent2Name = node.parents[1];

                Node parent1Node = _graphData.Nodes.First(n => n.name == parent1Name);
                Node parent2Node = _graphData.Nodes.First(n => n.name == parent2Name);

                double probParent1True = parent1Node.probabilities[0].Da;
                double probParent1False = parent1Node.probabilities[0].Nu;

                double probParent2True = parent2Node.probabilities[0].Da;
                double probParent2False = parent2Node.probabilities[0].Nu;

                double probTrue =
                    (probParent1True * probParent2True * node.probabilities[0].Da) +
                    (probParent1True * probParent2False * node.probabilities[1].Da) +
                    (probParent1False * probParent2True * node.probabilities[2].Da) +
                    (probParent1False * probParent2False * node.probabilities[3].Da);

                double probFalse = 1 - probTrue;

                node.probabilities[0].Da = probTrue;
                node.probabilities[0].Nu = probFalse;
            }

            // calculam recursiv probabilitatea pentru toti stramosii
            foreach (var ancestorName in node.parents)
            {
                Node ancestorNode = _graphData.Nodes.First(n => n.name == ancestorName);
                CalculateNodeProbability(ancestorNode, _nodeValues, _graphData);
            }
        }

        public void CalculateProbability(Node nodeQuery, Dictionary<string, string> _nodeValues, GraphData _graphData)
        {
            // iteram prin toate nodurile ca sa setam valorile de T \ F
            foreach (var node in _graphData.Nodes)
            {
                if (_nodeValues.ContainsKey(node.name))
                {
                    string observedValue = _nodeValues[node.name];
                    if (observedValue == "T")
                    {
                        node.probabilities[0].Da = 1.0; 
                        node.probabilities[0].Nu = 0.0;
                    }
                    else if (observedValue == "F")
                    {
                        node.probabilities[0].Da = 0.0; 
                        node.probabilities[0].Nu = 1.0;
                    }
                    continue; 
                }
            }

            var sortedNodes = TopologicalSort(_graphData.Nodes);

            foreach (var node in sortedNodes)
            {
                if (_nodeValues.ContainsKey(node.name)) continue; 

                CalculateNodeProbability(node, _nodeValues, _graphData);
            }

            MessageBox.Show(ShowNode(nodeQuery, _graphData));
        }

        private string ShowNode(Node nodeQuery, GraphData _graphData)
        {
            var result = "";
            
            foreach (var node in _graphData.Nodes)
            {   
                if(node.name == nodeQuery.name)
                result += $"{node.name} : P(T) = {node.probabilities[0].Da:F4} \t P(F) = {node.probabilities[0].Nu:F4}\n";
            }
            return result;
        }

        private List<Node> TopologicalSort(List<Node> nodes)
        {
            var sorted = new List<Node>();
            var visited = new HashSet<Node>();

            void Visit(Node node)
            {
                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    foreach (var parentName in node.parents)
                    {
                        var parentNode = nodes.FirstOrDefault(n => n.name == parentName);
                        if (parentNode != null)
                        {
                            Visit(parentNode);
                        }
                    }
                    sorted.Add(node);
                }
            }

            foreach (var node in nodes)
            {
                Visit(node);
            }

            return sorted;
        }
    }
}
