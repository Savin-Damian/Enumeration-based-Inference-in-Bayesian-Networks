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
            this.createNewGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditGraphDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.briefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verboseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesForMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.beliefDecisionModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beliefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decisionNetworkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendForNodesEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineTutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewGraphToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewGraphToolStripMenuItem
            // 
            this.createNewGraphToolStripMenuItem.Name = "createNewGraphToolStripMenuItem";
            this.createNewGraphToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.createNewGraphToolStripMenuItem.Text = "Create New Graph";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.loadFromFileToolStripMenuItem.Text = "Load from File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.saveFileToolStripMenuItem.Text = "Save Problem";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEditToolStripMenuItem,
            this.viewEditGraphDescriptionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewEditToolStripMenuItem
            // 
            this.viewEditToolStripMenuItem.Name = "viewEditToolStripMenuItem";
            this.viewEditToolStripMenuItem.Size = new System.Drawing.Size(346, 34);
            this.viewEditToolStripMenuItem.Text = "View/Edit Text Representation";
            this.viewEditToolStripMenuItem.Click += new System.EventHandler(this.viewEditToolStripMenuItem_Click);
            // 
            // viewEditGraphDescriptionToolStripMenuItem
            // 
            this.viewEditGraphDescriptionToolStripMenuItem.Name = "viewEditGraphDescriptionToolStripMenuItem";
            this.viewEditGraphDescriptionToolStripMenuItem.Size = new System.Drawing.Size(346, 34);
            this.viewEditGraphDescriptionToolStripMenuItem.Text = "View/Edit Graph Description";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.lineWidthToolStripMenuItem,
            this.autoscaleToolStripMenuItem,
            this.panZoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
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
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // extraLarge30ptToolStripMenuItem
            // 
            this.extraLarge30ptToolStripMenuItem.CheckOnClick = true;
            this.extraLarge30ptToolStripMenuItem.Name = "extraLarge30ptToolStripMenuItem";
            this.extraLarge30ptToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.extraLarge30ptToolStripMenuItem.Text = "Extra Large (30 pt)";
            this.extraLarge30ptToolStripMenuItem.Click += new System.EventHandler(this.extraLarge30ptToolStripMenuItem_Click);
            // 
            // large20ptToolStripMenuItem
            // 
            this.large20ptToolStripMenuItem.CheckOnClick = true;
            this.large20ptToolStripMenuItem.Name = "large20ptToolStripMenuItem";
            this.large20ptToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.large20ptToolStripMenuItem.Text = "Large (20 pt)";
            // 
            // medium12PtToolStripMenuItem
            // 
            this.medium12PtToolStripMenuItem.CheckOnClick = true;
            this.medium12PtToolStripMenuItem.Name = "medium12PtToolStripMenuItem";
            this.medium12PtToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.medium12PtToolStripMenuItem.Text = "Medium (12 pt)";
            // 
            // small8PtToolStripMenuItem
            // 
            this.small8PtToolStripMenuItem.CheckOnClick = true;
            this.small8PtToolStripMenuItem.Name = "small8PtToolStripMenuItem";
            this.small8PtToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
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
            this.lineWidthToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.lineWidthToolStripMenuItem.Text = "Line Width";
            // 
            // wideToolStripMenuItem
            // 
            this.wideToolStripMenuItem.Name = "wideToolStripMenuItem";
            this.wideToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.wideToolStripMenuItem.Text = "Wide (4 pixels)";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.mediumToolStripMenuItem.Text = "Medium (2 pixels)";
            // 
            // narrowToolStripMenuItem
            // 
            this.narrowToolStripMenuItem.Name = "narrowToolStripMenuItem";
            this.narrowToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.narrowToolStripMenuItem.Text = "Narrow (1 pixel)";
            // 
            // autoscaleToolStripMenuItem
            // 
            this.autoscaleToolStripMenuItem.Name = "autoscaleToolStripMenuItem";
            this.autoscaleToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.autoscaleToolStripMenuItem.Text = "Autoscale";
            // 
            // panZoomToolStripMenuItem
            // 
            this.panZoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.panToolStripMenuItem});
            this.panZoomToolStripMenuItem.Name = "panZoomToolStripMenuItem";
            this.panZoomToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.panZoomToolStripMenuItem.Text = "Pan/Zoom";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.CheckOnClick = true;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(162, 34);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.CheckOnClick = true;
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(162, 34);
            this.panToolStripMenuItem.Text = "Pan";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryModesToolStripMenuItem,
            this.decimalPlacesForMonitoringToolStripMenuItem,
            this.beliefDecisionModeToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.networkToolStripMenuItem.Text = "Network Options";
            // 
            // queryModesToolStripMenuItem
            // 
            this.queryModesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.briefToolStripMenuItem,
            this.verboseToolStripMenuItem,
            this.promptToolStripMenuItem});
            this.queryModesToolStripMenuItem.Name = "queryModesToolStripMenuItem";
            this.queryModesToolStripMenuItem.Size = new System.Drawing.Size(352, 34);
            this.queryModesToolStripMenuItem.Text = "Query Modes";
            // 
            // briefToolStripMenuItem
            // 
            this.briefToolStripMenuItem.CheckOnClick = true;
            this.briefToolStripMenuItem.Name = "briefToolStripMenuItem";
            this.briefToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.briefToolStripMenuItem.Text = "Brief Query Modes";
            // 
            // verboseToolStripMenuItem
            // 
            this.verboseToolStripMenuItem.CheckOnClick = true;
            this.verboseToolStripMenuItem.Name = "verboseToolStripMenuItem";
            this.verboseToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.verboseToolStripMenuItem.Text = "Verbose Query Modes";
            this.verboseToolStripMenuItem.Click += new System.EventHandler(this.verboseToolStripMenuItem_Click);
            // 
            // promptToolStripMenuItem
            // 
            this.promptToolStripMenuItem.CheckOnClick = true;
            this.promptToolStripMenuItem.Name = "promptToolStripMenuItem";
            this.promptToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.promptToolStripMenuItem.Text = "Prompt Query Modes";
            // 
            // decimalPlacesForMonitoringToolStripMenuItem
            // 
            this.decimalPlacesForMonitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.decimalPlacesForMonitoringToolStripMenuItem.Name = "decimalPlacesForMonitoringToolStripMenuItem";
            this.decimalPlacesForMonitoringToolStripMenuItem.Size = new System.Drawing.Size(352, 34);
            this.decimalPlacesForMonitoringToolStripMenuItem.Text = "Decimal Places for Monitoring";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 34);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 34);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 34);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(124, 34);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(124, 34);
            this.toolStripMenuItem6.Text = "5";
            // 
            // beliefDecisionModeToolStripMenuItem
            // 
            this.beliefDecisionModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beliefToolStripMenuItem,
            this.decisionNetworkModeToolStripMenuItem});
            this.beliefDecisionModeToolStripMenuItem.Name = "beliefDecisionModeToolStripMenuItem";
            this.beliefDecisionModeToolStripMenuItem.Size = new System.Drawing.Size(352, 34);
            this.beliefDecisionModeToolStripMenuItem.Text = "Belief/Decision Mode";
            // 
            // beliefToolStripMenuItem
            // 
            this.beliefToolStripMenuItem.CheckOnClick = true;
            this.beliefToolStripMenuItem.Name = "beliefToolStripMenuItem";
            this.beliefToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.beliefToolStripMenuItem.Text = "Belief Network Mode";
            // 
            // decisionNetworkModeToolStripMenuItem
            // 
            this.decisionNetworkModeToolStripMenuItem.CheckOnClick = true;
            this.decisionNetworkModeToolStripMenuItem.Name = "decisionNetworkModeToolStripMenuItem";
            this.decisionNetworkModeToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.decisionNetworkModeToolStripMenuItem.Text = "Decision Network Mode";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendForNodesEdgesToolStripMenuItem,
            this.onlineHelpToolStripMenuItem,
            this.onlineTutorialsToolStripMenuItem,
            this.aboutThisToolToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // legendForNodesEdgesToolStripMenuItem
            // 
            this.legendForNodesEdgesToolStripMenuItem.Name = "legendForNodesEdgesToolStripMenuItem";
            this.legendForNodesEdgesToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.legendForNodesEdgesToolStripMenuItem.Text = "Legend for Nodes/Edges";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // onlineTutorialsToolStripMenuItem
            // 
            this.onlineTutorialsToolStripMenuItem.Name = "onlineTutorialsToolStripMenuItem";
            this.onlineTutorialsToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.onlineTutorialsToolStripMenuItem.Text = "Online Tutorials";
            // 
            // aboutThisToolToolStripMenuItem
            // 
            this.aboutThisToolToolStripMenuItem.Name = "aboutThisToolToolStripMenuItem";
            this.aboutThisToolToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.aboutThisToolToolStripMenuItem.Text = "About this Tool";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 867);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditGraphDescriptionToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem panZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryModesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesForMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beliefDecisionModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendForNodesEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineTutorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisToolToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem briefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verboseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem beliefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decisionNetworkModeToolStripMenuItem;
    }
}

