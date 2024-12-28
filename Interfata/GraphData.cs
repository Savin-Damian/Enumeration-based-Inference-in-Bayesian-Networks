using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static void DrawGraph(PictureBox pictureBox, GraphData graphData)
        {
            pictureBox.Paint += (s, e) =>
            {
                var graphics = e.Graphics;
                graphics.Clear(Color.White);

                var nodeFont = new Font("TimesNewRoman", 10, FontStyle.Bold);
                var nodeBrush = Brushes.LightBlue;
                var textBrush = Brushes.Black;
                var pen = new Pen(Color.Black, 2);

                var positions = CalculateNodePositions(graphData, pictureBox.Width, pictureBox.Height);

                //desenam noduri
                foreach (var node in graphData.Nodes)
                {
                    if (!positions.TryGetValue(node.name, out var position)) continue;

                    //elipsa pentru nod
                    graphics.FillEllipse(nodeBrush, position.X, position.Y, 80, 50);
                    graphics.DrawEllipse(pen, position.X, position.Y, 80, 50);

                    //text in nod
                    var stringSize = graphics.MeasureString(node.name, nodeFont);
                    graphics.DrawString(node.name, nodeFont, textBrush,
                        position.X + 40 - stringSize.Width / 2,
                        position.Y + 25 - stringSize.Height / 2);
                }

                //deseneaza liniile intre noduri
                foreach (var node in graphData.Nodes)
                {
                    if (node.parents == null) continue;

                    foreach (var parent in node.parents)
                    {
                        if (!positions.TryGetValue(parent, out var parentPos) ||
                            !positions.TryGetValue(node.name, out var childPos)) continue;

                        var parentCenter = new Point(parentPos.X + 60, parentPos.Y + 45);
                        var childCenter = new Point(childPos.X + 60, childPos.Y + 45);

                        DrawArrow(graphics, pen, parentCenter, childCenter);
                    }
                }
            };
            pictureBox.Refresh();
        }

        private static void DrawArrow(Graphics graphics, Pen pen, Point start, Point end)
        {
            graphics.DrawLine(pen, start, end);

            //directia sagetii 
            var direction = new Point(end.X - start.X, end.Y - start.Y);
            var length = Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            var unitDirection = new PointF((float)(direction.X / length), (float)(direction.Y / length));

            var arrowSize = 12; 
            var angle = Math.PI / 7; 
            var leftEnd = new PointF(
                end.X - arrowSize * (float)(Math.Cos(angle) * unitDirection.X - Math.Sin(angle) * unitDirection.Y),
                end.Y - arrowSize * (float)(Math.Sin(angle) * unitDirection.X + Math.Cos(angle) * unitDirection.Y));

            var rightEnd = new PointF(
                end.X - arrowSize * (float)(Math.Cos(-angle) * unitDirection.X - Math.Sin(-angle) * unitDirection.Y),
                end.Y - arrowSize * (float)(Math.Sin(-angle) * unitDirection.X + Math.Cos(-angle) * unitDirection.Y));
            graphics.FillPolygon(Brushes.Black, new[] { end, leftEnd, rightEnd });
        }



        private static Dictionary<string, Point> CalculateNodePositions(GraphData graphData, int width, int height)
        {
            var positions = new Dictionary<string, Point>();
            var levelMapping = new Dictionary<string, int>();

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
