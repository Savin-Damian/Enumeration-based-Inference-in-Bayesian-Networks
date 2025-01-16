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

        private Dictionary<string, string> _nodeValues = new Dictionary<string, string>(); // T / F / <none> pentru fiecare nod
        public Dictionary<string, Rectangle> nodeBounds = new Dictionary<string, Rectangle>(); // informatii despre fiecare nod
        private bool _observationButton = false;
        private bool _queryClick = false;

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
                    // cautam nodul dupa nume
                    var node = _graphData.Nodes.FirstOrDefault(n => n.name == kvp.Key);

                    if (node != null)
                    {
                        if (_observationButton)
                        {
                            ShowMenu(node, e.Location); 
                        }
                        else if (_queryClick)
                        {
                            _graphData.CalculateProbability(node, _nodeValues, _graphData);
                        }
                        else
                        {
                            _graphData.ShowInfo(node);
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
            _observationButton = false;
            _queryClick = !_queryClick;
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

                if (selectedValue == "T")
                {
                    node.probabilities[0].Da = 1.0; 
                    node.probabilities[0].Nu = 0.0; 
                }
                else if (selectedValue == "F")
                {
                    node.probabilities[0].Da = 0.0; 
                    node.probabilities[0].Nu = 1.0; 
                }
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Artificial Intelligence\n Copyright \n Savin Damian \n Spiridon Ioan \n 1406A");
        }

        private void makeObservation_Click(object sender, EventArgs e)
        {
            _queryClick = false;
            _observationButton = !_observationButton;
            if (_graphData == null || _graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "Node values:\n";
            foreach (var node in _graphData.Nodes)
            {
                string value = _nodeValues.ContainsKey(node.name) ? _nodeValues[node.name] : "<none>";
                result += $"Node: {node.name}, Value: {value}\n";
            }
            if (_observationButton == false)
                MessageBox.Show(result, "Node Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _observationButton = false;
            if (_graphData == null || _graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var node in _graphData.Nodes)
            {
                _nodeValues[node.name] = "<none>";
            }
            MessageBox.Show("S-au resetat valorile cu succes! \n");
        }

        private void saveProblem_Click(object sender, EventArgs e)
        {
            if (_graphData == null || _graphData.Nodes == null)
            {
                MessageBox.Show("Graph data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Graph Data";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Serialize GraphData to JSON
                        var jsonData = JsonConvert.SerializeObject(_graphData, Formatting.Indented);

                        // Save JSON to the selected file
                        System.IO.File.WriteAllText(filePath, jsonData);

                        MessageBox.Show("Graph data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
