using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class GraphRenderer
    {
        private static Graphics _graphics;
        private static Font _nodeFont; 
        private static Brush _nodeBrush;
        private static Brush _textBrush;
        private static Pen _pen;
        private static Form1 _form;
        public void DrawGraph(PictureBox pictureBox, GraphData graphData)
        {
            _form = (Form1)pictureBox.FindForm();
            _form.nodeBounds.Clear(); // Clear previous bounds

            pictureBox.Paint += (s, e) =>
            {
                _graphics = e.Graphics;
                _graphics.Clear(Color.White);

                _nodeFont = new Font("TimesNewRoman", 10, FontStyle.Bold);
                _nodeBrush = Brushes.LightBlue;
                _textBrush = Brushes.Black;
                _pen = new Pen(Color.Black, 2);

                var positions = GraphLayout.CalculateNodePositions(graphData, pictureBox.Width, pictureBox.Height);

                // Draw nodes
                foreach (var node in graphData.Nodes)
                {
                    if (!positions.TryGetValue(node.name, out var position)) continue;

                    // Node rectangle
                    var rect = new Rectangle(position.X, position.Y, 80, 50);
                    _graphics.FillEllipse(_nodeBrush, rect);
                    _graphics.DrawEllipse(_pen, rect);

                    // Store node bounds
                    _form.nodeBounds[node.name] = rect;

                    // Draw node text
                    var stringSize = _graphics.MeasureString(node.name, _nodeFont);
                    _graphics.DrawString(node.name, _nodeFont, _textBrush,
                        position.X + 40 - stringSize.Width / 2,
                        position.Y + 25 - stringSize.Height / 2);
                }

                // Draw edges
                foreach (var node in graphData.Nodes)
                {
                    if (node.parents == null) continue;

                    foreach (var parent in node.parents)
                    {
                        if (!positions.TryGetValue(parent, out var parentPos) ||
                            !positions.TryGetValue(node.name, out var childPos)) continue;

                        var parentCenter = new Point(parentPos.X + 60, parentPos.Y + 45);
                        var childCenter = new Point(childPos.X + 60, childPos.Y + 45);

                        DrawArrow(parentCenter, childCenter);
                    }
                }
            };
            pictureBox.Refresh();
        }


        private static void DrawArrow(Point start, Point end)
        {
            _graphics.DrawLine(_pen, start, end);

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
            _graphics.FillPolygon(Brushes.Black, new[] { end, leftEnd, rightEnd });
        }
    }
}
