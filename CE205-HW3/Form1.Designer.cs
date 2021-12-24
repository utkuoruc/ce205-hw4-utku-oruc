namespace CE205_HW3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnDouble = new System.Windows.Forms.RadioButton();
            this.rdBtnQuad = new System.Windows.Forms.RadioButton();
            this.rdBtnLineer = new System.Windows.Forms.RadioButton();
            this.rdBtnSeperate = new System.Windows.Forms.RadioButton();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 36);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1398, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(0, 160);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(1398, 550);
            this.gViewer1.TabIndex = 3;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnDouble);
            this.groupBox1.Controls.Add(this.rdBtnQuad);
            this.groupBox1.Controls.Add(this.rdBtnLineer);
            this.groupBox1.Controls.Add(this.rdBtnSeperate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(678, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // rdBtnDouble
            // 
            this.rdBtnDouble.AutoSize = true;
            this.rdBtnDouble.Location = new System.Drawing.Point(355, 40);
            this.rdBtnDouble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnDouble.Name = "rdBtnDouble";
            this.rdBtnDouble.Size = new System.Drawing.Size(118, 33);
            this.rdBtnDouble.TabIndex = 3;
            this.rdBtnDouble.Text = "Double";
            this.rdBtnDouble.UseVisualStyleBackColor = true;
            // 
            // rdBtnQuad
            // 
            this.rdBtnQuad.AutoSize = true;
            this.rdBtnQuad.Location = new System.Drawing.Point(158, 40);
            this.rdBtnQuad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnQuad.Name = "rdBtnQuad";
            this.rdBtnQuad.Size = new System.Drawing.Size(146, 33);
            this.rdBtnQuad.TabIndex = 2;
            this.rdBtnQuad.Text = "Quadratic";
            this.rdBtnQuad.UseVisualStyleBackColor = true;
            // 
            // rdBtnLineer
            // 
            this.rdBtnLineer.AutoSize = true;
            this.rdBtnLineer.Checked = true;
            this.rdBtnLineer.Location = new System.Drawing.Point(8, 40);
            this.rdBtnLineer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnLineer.Name = "rdBtnLineer";
            this.rdBtnLineer.Size = new System.Drawing.Size(105, 33);
            this.rdBtnLineer.TabIndex = 1;
            this.rdBtnLineer.TabStop = true;
            this.rdBtnLineer.Text = "Lineer";
            this.rdBtnLineer.UseVisualStyleBackColor = true;
            this.rdBtnLineer.CheckedChanged += new System.EventHandler(this.rdBtnLineer_CheckedChanged);
            // 
            // rdBtnSeperate
            // 
            this.rdBtnSeperate.AutoSize = true;
            this.rdBtnSeperate.Location = new System.Drawing.Point(524, 40);
            this.rdBtnSeperate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnSeperate.Name = "rdBtnSeperate";
            this.rdBtnSeperate.Size = new System.Drawing.Size(135, 33);
            this.rdBtnSeperate.TabIndex = 0;
            this.rdBtnSeperate.Text = "Seperate";
            this.rdBtnSeperate.UseVisualStyleBackColor = true;
            this.rdBtnSeperate.CheckedChanged += new System.EventHandler(this.rdBtnSeperate_CheckedChanged);
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPreviousStep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousStep.Location = new System.Drawing.Point(1176, 75);
            this.btnPreviousStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(101, 71);
            this.btnPreviousStep.TabIndex = 7;
            this.btnPreviousStep.Text = "prev";
            this.btnPreviousStep.UseVisualStyleBackColor = false;
            this.btnPreviousStep.Click += new System.EventHandler(this.btnPreviousStep_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextStep.Location = new System.Drawing.Point(1285, 75);
            this.btnNextStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(99, 71);
            this.btnNextStep.TabIndex = 8;
            this.btnNextStep.Text = "next";
            this.btnNextStep.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(891, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Lime;
            this.buttonInsert.Location = new System.Drawing.Point(891, 113);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(90, 33);
            this.buttonInsert.TabIndex = 13;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(702, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(987, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 31);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1083, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 31);
            this.textBox3.TabIndex = 16;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Lime;
            this.buttonDelete.Location = new System.Drawing.Point(987, 115);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 31);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Lime;
            this.buttonSearch.Location = new System.Drawing.Point(1083, 115);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 31);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 714);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CE205 HW3 2021-2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private GroupBox groupBox1;
        private RadioButton rdBtnDouble;
        private RadioButton rdBtnQuad;
        private RadioButton rdBtnLineer;
        private RadioButton rdBtnSeperate;
        private Button btnPreviousStep;
        private Button btnNextStep;
        private TextBox textBox1;
        private Button buttonInsert;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonDelete;
        private Button buttonSearch;
    }
}