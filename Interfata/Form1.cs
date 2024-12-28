using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;
        private GraphData graphData;
        private GraphRenderer graphRenderer = new GraphRenderer();
        public Form1()
        {
            InitializeComponent();
            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(pictureBox);
            pictureBox.MouseClick += mouseClick;
        }

        public Dictionary<string, Rectangle> nodeBounds = new Dictionary<string, Rectangle>();

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (nodeBounds == null)
            {
                MessageBox.Show("Node bounds are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (graphData == null || graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var kvp in nodeBounds)
            {
                if (kvp.Value.Contains(e.Location))
                {
                    // Find the node by name
                    var node = graphData.Nodes.FirstOrDefault(n => n.name == kvp.Key);
                    if (node != null)
                    {
                        graphData.ShowInfo(node); // Call ShowInfo on the clicked node
                    }
                    else
                    {
                        MessageBox.Show($"Node '{kvp.Key}' not found in the graph data.");
                    }
                    return;
                }
            }

            MessageBox.Show("You clicked outside of any nodes.", "Click Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void viewEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void extraLarge30ptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void small8PtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verboseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        var jsonData = System.IO.File.ReadAllText(filePath);
                        graphData = JsonConvert.DeserializeObject<GraphData>(jsonData);

                        if (graphData != null && graphData.Nodes != null)
                        {
                            graphRenderer.DrawGraph(pictureBox, graphData);
                        }
                        else   
                        {
                            MessageBox.Show("Invalid graph data.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}");
                    }
                }
            }
        }
    }
}
