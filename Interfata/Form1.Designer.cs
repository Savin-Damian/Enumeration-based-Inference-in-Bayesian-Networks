using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraLarge30ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.large20ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medium12PtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.small8PtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendForNodesEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load from File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "Save Problem";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveProblem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.lineWidthToolStripMenuItem,
            this.autoscaleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extraLarge30ptToolStripMenuItem,
            this.large20ptToolStripMenuItem,
            this.medium12PtToolStripMenuItem,
            this.small8PtToolStripMenuItem});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // extraLarge30ptToolStripMenuItem
            // 
            this.extraLarge30ptToolStripMenuItem.CheckOnClick = true;
            this.extraLarge30ptToolStripMenuItem.Name = "extraLarge30ptToolStripMenuItem";
            this.extraLarge30ptToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.extraLarge30ptToolStripMenuItem.Text = "Extra Large (30 pt)";
            this.extraLarge30ptToolStripMenuItem.Click += new System.EventHandler(this.extraLarge30ptToolStripMenuItem_Click);
            // 
            // large20ptToolStripMenuItem
            // 
            this.large20ptToolStripMenuItem.CheckOnClick = true;
            this.large20ptToolStripMenuItem.Name = "large20ptToolStripMenuItem";
            this.large20ptToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.large20ptToolStripMenuItem.Text = "Large (20 pt)";
            // 
            // medium12PtToolStripMenuItem
            // 
            this.medium12PtToolStripMenuItem.CheckOnClick = true;
            this.medium12PtToolStripMenuItem.Name = "medium12PtToolStripMenuItem";
            this.medium12PtToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.medium12PtToolStripMenuItem.Text = "Medium (12 pt)";
            // 
            // small8PtToolStripMenuItem
            // 
            this.small8PtToolStripMenuItem.CheckOnClick = true;
            this.small8PtToolStripMenuItem.Name = "small8PtToolStripMenuItem";
            this.small8PtToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.small8PtToolStripMenuItem.Text = "Small (8 pt)";
            this.small8PtToolStripMenuItem.Click += new System.EventHandler(this.small8PtToolStripMenuItem_Click);
            // 
            // lineWidthToolStripMenuItem
            // 
            this.lineWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wideToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.narrowToolStripMenuItem});
            this.lineWidthToolStripMenuItem.Name = "lineWidthToolStripMenuItem";
            this.lineWidthToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.lineWidthToolStripMenuItem.Text = "Line Width";
            // 
            // wideToolStripMenuItem
            // 
            this.wideToolStripMenuItem.Name = "wideToolStripMenuItem";
            this.wideToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.wideToolStripMenuItem.Text = "Wide (4 pixels)";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mediumToolStripMenuItem.Text = "Medium (2 pixels)";
            // 
            // narrowToolStripMenuItem
            // 
            this.narrowToolStripMenuItem.Name = "narrowToolStripMenuItem";
            this.narrowToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.narrowToolStripMenuItem.Text = "Narrow (1 pixel)";
            // 
            // autoscaleToolStripMenuItem
            // 
            this.autoscaleToolStripMenuItem.Name = "autoscaleToolStripMenuItem";
            this.autoscaleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.autoscaleToolStripMenuItem.Text = "Autoscale";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendForNodesEdgesToolStripMenuItem,
            this.aboutThisToolToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // legendForNodesEdgesToolStripMenuItem
            // 
            this.legendForNodesEdgesToolStripMenuItem.Name = "legendForNodesEdgesToolStripMenuItem";
            this.legendForNodesEdgesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.legendForNodesEdgesToolStripMenuItem.Text = "Legend for Nodes/Edges";
            // 
            // aboutThisToolToolStripMenuItem
            // 
            this.aboutThisToolToolStripMenuItem.Name = "aboutThisToolToolStripMenuItem";
            this.aboutThisToolToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aboutThisToolToolStripMenuItem.Text = "About this Tool";
            this.aboutThisToolToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Make Observation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.makeObservation_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Query_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 564);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraLarge30ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem large20ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medium12PtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem small8PtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendForNodesEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisToolToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

