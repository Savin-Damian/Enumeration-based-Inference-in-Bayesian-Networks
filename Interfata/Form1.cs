using Newtonsoft.Json;
using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                        var graphData = JsonConvert.DeserializeObject<GraphData>(jsonData);

                        graphData.PrintInfo();
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
