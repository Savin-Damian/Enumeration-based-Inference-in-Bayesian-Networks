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
        private PictureBox _pictureBox;
        private GraphData _graphData;
        private GraphRenderer _graphRenderer = new GraphRenderer();

        private Dictionary<string, string> _nodeValues = new Dictionary<string, string>(); // to check T / F / <none> for every node
        public Dictionary<string, Rectangle> nodeBounds = new Dictionary<string, Rectangle>(); // to show info of every node
        private bool _button1Clicked = false;
        private bool _queryClicked = false;

        public Form1()
        {
            InitializeComponent();
            _pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(_pictureBox);
            _pictureBox.MouseClick += mouseClick;
        }

        

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (nodeBounds == null)
            {
                MessageBox.Show("Node bounds are not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_graphData == null || _graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var kvp in nodeBounds)
            {
                if (kvp.Value.Contains(e.Location))
                {
                    // Find the node by name
                    var node = _graphData.Nodes.FirstOrDefault(n => n.name == kvp.Key);

                    if (node != null)
                    {
                        if (_button1Clicked)
                        {
                            ShowMenu(node, e.Location); 
                        }
                        else
                        {
                            if (_queryClicked)
                            {
                                _graphData.CalculateProbability(_nodeValues, _graphData);
                            }
                            else
                            {
                                _graphData.ShowInfo(node); // Call ShowInfo on the clicked node
                            }
                        }
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

        private void Query_Click(object sender, EventArgs e)
        {
            _queryClicked = true;
            _button1Clicked = false;
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
                        _graphData = JsonConvert.DeserializeObject<GraphData>(jsonData);

                        if (_graphData != null && _graphData.Nodes != null)
                        {
                            _graphRenderer.DrawGraph(_pictureBox, _graphData);
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
        private void ShowMenu(Node node, Point location)
        {

            Form dropdownForm = new Form
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.PointToScreen(location),
                Size = new Size(200, 150),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Text = $"Observation for {node.name}" 
            };

            var comboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Items = { "<none>", "T", "F" },
                Location = new Point(10, 10),
                Width = 150
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new Point(60, 50),
                DialogResult = DialogResult.OK
            };

            dropdownForm.Controls.Add(comboBox);
            dropdownForm.Controls.Add(okButton);

            if (dropdownForm.ShowDialog() == DialogResult.OK)
            {
                var selectedValue = comboBox.SelectedItem?.ToString() ?? "<none>";

                if (_nodeValues.ContainsKey(node.name))
                {
                    _nodeValues[node.name] = selectedValue;
                }
                else
                {
                    _nodeValues.Add(node.name, selectedValue);
                }

                MessageBox.Show($"Valoare selectata pentru nodul '{node.name}':  {selectedValue}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _button1Clicked = true;
            if (_graphData == null || _graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "Node values:\n";
            foreach (var node in _graphData.Nodes)
            {
                string value = _nodeValues.ContainsKey(node.name) ? _nodeValues[node.name] : "<not set>";
                result += $"Node: {node.name}, Value: {value}\n";
            }

            MessageBox.Show(result, "Node Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            _button1Clicked = false;
            if (_graphData == null || _graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var node in _graphData.Nodes)
            {
                _nodeValues[node.name] = "<not set>";
            }
            MessageBox.Show("S-au resetat valorile cu succes! \n");

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Artificial Intelligence\n Copyright \n Savin Damian \n Spiridon Ioan \n 1406A");
        }

    }
}
