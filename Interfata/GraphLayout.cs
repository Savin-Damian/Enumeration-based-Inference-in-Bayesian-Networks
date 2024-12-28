using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp1
{
    internal class GraphLayout
    {
        private static Dictionary<string, Point> positions;
        private static Dictionary<string, int> levelMapping;
        public static Dictionary<string, Point> CalculateNodePositions(GraphData graphData, int width, int height)
        {
            positions = new Dictionary<string, Point>();
            levelMapping = new Dictionary<string, int>();

            //aflam nivelurile
            foreach (var node in graphData.Nodes)
            {
                CalculateLevel(node, graphData, levelMapping);
            }

            //punem nodurile pe niveluri
            var levels = levelMapping.GroupBy(kvp => kvp.Value).OrderBy(group => group.Key).ToDictionary(group => group.Key,
                                                    group => group.Select(kvp => kvp.Key).ToList());

            int verticalSpacing = height / (levels.Count + 1);
            int horizontalSpacing = width / 4;

            foreach (var level in levels)
            {
                int y = verticalSpacing * (level.Key + 1);
                int xSpacing = width / (level.Value.Count + 1);

                for (int i = 0; i < level.Value.Count; i++)
                {
                    var x = xSpacing * (i + 1);
                    positions[level.Value[i]] = new Point(x - 40, y - 25);
                }
            }

            return positions;
        }

        private static int CalculateLevel(Node node, GraphData graphData, Dictionary<string, int> levelMapping)
        {
            if (levelMapping.ContainsKey(node.name)) return levelMapping[node.name];

            if (node.parents == null || node.parents.Count == 0)
            {
                levelMapping[node.name] = 0;
                return 0;
            }

            var maxParentLevel = node.parents
                                     .Select(parent => graphData.Nodes.FirstOrDefault(n => n.name == parent))
                                     .Where(parentNode => parentNode != null)
                                     .Max(parentNode => CalculateLevel(parentNode, graphData, levelMapping));

            levelMapping[node.name] = maxParentLevel + 1;
            return maxParentLevel + 1;
        }
    }
}
