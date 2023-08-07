namespace VBEThemeColorEditor
{
    partial class ThemeEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeEditorForm));
            this.buttonModifyDLL = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AddRegistry = new System.Windows.Forms.Button();
            this.buttonModifyDLLauto = new System.Windows.Forms.Button();
            this.ApplyFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.selectedFont = new System.Windows.Forms.TextBox();
            this.labelfont = new System.Windows.Forms.Label();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.ApplyFontSize = new System.Windows.Forms.Button();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.buttonModifyDLLauto1 = new System.Windows.Forms.Button();
            this.linkLabel01 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxThemeList = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonModifyDLL
            // 
            this.buttonModifyDLL.BackColor = System.Drawing.Color.DarkGray;
            this.buttonModifyDLL.FlatAppearance.BorderSize = 0;
            this.buttonModifyDLL.Location = new System.Drawing.Point(247, 427);
            this.buttonModifyDLL.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonModifyDLL.Name = "buttonModifyDLL";
            this.buttonModifyDLL.Size = new System.Drawing.Size(218, 34);
            this.buttonModifyDLL.TabIndex = 0;
            this.buttonModifyDLL.Text = "** Pacth to VBE.DLL ";
            this.buttonModifyDLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifyDLL.UseVisualStyleBackColor = false;
            this.buttonModifyDLL.Click += new System.EventHandler(this.buttonModifyDLL_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 615);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 23, 0);
            this.statusStrip.Size = new System.Drawing.Size(516, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // AddRegistry
            // 
            this.AddRegistry.BackColor = System.Drawing.Color.Azure;
            this.AddRegistry.FlatAppearance.BorderSize = 0;
            this.AddRegistry.Font = new System.Drawing.Font("Arial", 11F);
            this.AddRegistry.Location = new System.Drawing.Point(247, 349);
            this.AddRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.AddRegistry.Name = "AddRegistry";
            this.AddRegistry.Size = new System.Drawing.Size(218, 65);
            this.AddRegistry.TabIndex = 42;
            this.AddRegistry.Text = "2) Add to Registry";
            this.AddRegistry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRegistry.UseVisualStyleBackColor = false;
            this.AddRegistry.Click += new System.EventHandler(this.AddRegistry_Click);
            // 
            // buttonModifyDLLauto
            // 
            this.buttonModifyDLLauto.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonModifyDLLauto.FlatAppearance.BorderSize = 0;
            this.buttonModifyDLLauto.Location = new System.Drawing.Point(198, 302);
            this.buttonModifyDLLauto.Name = "buttonModifyDLLauto";
            this.buttonModifyDLLauto.Size = new System.Drawing.Size(109, 23);
            this.buttonModifyDLLauto.TabIndex = 43;
            this.buttonModifyDLLauto.Text = "Apply AUTO";
            this.buttonModifyDLLauto.UseVisualStyleBackColor = false;
            this.buttonModifyDLLauto.Click += new System.EventHandler(this.buttonModifyDLLauto_Click);
            // 
            // ApplyFont
            // 
            this.ApplyFont.BackColor = System.Drawing.Color.Azure;
            this.ApplyFont.FlatAppearance.BorderSize = 0;
            this.ApplyFont.Location = new System.Drawing.Point(308, 526);
            this.ApplyFont.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyFont.Name = "ApplyFont";
            this.ApplyFont.Size = new System.Drawing.Size(156, 34);
            this.ApplyFont.TabIndex = 45;
            this.ApplyFont.Text = "Apply Font";
            this.ApplyFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFont.UseVisualStyleBackColor = false;
            this.ApplyFont.Click += new System.EventHandler(this.ApplyFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.White;
            this.fontDialog1.Font = new System.Drawing.Font("D2Coding", 50F);
            this.fontDialog1.MaxSize = 200;
            this.fontDialog1.MinSize = 50;
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // selectedFont
            // 
            this.selectedFont.Location = new System.Drawing.Point(155, 527);
            this.selectedFont.Margin = new System.Windows.Forms.Padding(4);
            this.selectedFont.Name = "selectedFont";
            this.selectedFont.Size = new System.Drawing.Size(143, 28);
            this.selectedFont.TabIndex = 47;
            this.selectedFont.Text = "D2Coding";
            this.selectedFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelfont
            // 
            this.labelfont.AutoSize = true;
            this.labelfont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelfont.Location = new System.Drawing.Point(24, 534);
            this.labelfont.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelfont.Name = "labelfont";
            this.labelfont.Size = new System.Drawing.Size(52, 18);
            this.labelfont.TabIndex = 35;
            this.labelfont.Text = "FONT";
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFontSize.Location = new System.Drawing.Point(22, 492);
            this.labelFontSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(94, 18);
            this.labelFontSize.TabIndex = 48;
            this.labelFontSize.Text = "FONT SIZE";
            // 
            // ApplyFontSize
            // 
            this.ApplyFontSize.BackColor = System.Drawing.Color.Azure;
            this.ApplyFontSize.FlatAppearance.BorderSize = 0;
            this.ApplyFontSize.Location = new System.Drawing.Point(308, 484);
            this.ApplyFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyFontSize.Name = "ApplyFontSize";
            this.ApplyFontSize.Size = new System.Drawing.Size(156, 34);
            this.ApplyFontSize.TabIndex = 49;
            this.ApplyFontSize.Text = "Apply Font Size";
            this.ApplyFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFontSize.UseVisualStyleBackColor = false;
            this.ApplyFontSize.Click += new System.EventHandler(this.ApplyFontSize_Click);
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Location = new System.Drawing.Point(155, 488);
            this.textBoxFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.Size = new System.Drawing.Size(143, 28);
            this.textBoxFontSize.TabIndex = 50;
            this.textBoxFontSize.Text = "14";
            this.textBoxFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFontSize.TextChanged += new System.EventHandler(this.textBoxFontSize_TextChanged);
            // 
            // buttonModifyDLLauto1
            // 
            this.buttonModifyDLLauto1.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonModifyDLLauto1.FlatAppearance.BorderSize = 0;
            this.buttonModifyDLLauto1.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonModifyDLLauto1.Location = new System.Drawing.Point(14, 349);
            this.buttonModifyDLLauto1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyDLLauto1.Name = "buttonModifyDLLauto1";
            this.buttonModifyDLLauto1.Size = new System.Drawing.Size(219, 65);
            this.buttonModifyDLLauto1.TabIndex = 51;
            this.buttonModifyDLLauto1.Text = "1) Apply AUTO";
            this.buttonModifyDLLauto1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifyDLLauto1.UseVisualStyleBackColor = false;
            this.buttonModifyDLLauto1.Click += new System.EventHandler(this.buttonModifyDLLauto1_Click);
            // 
            // linkLabel01
            // 
            this.linkLabel01.AutoSize = true;
            this.linkLabel01.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel01.Location = new System.Drawing.Point(200, 586);
            this.linkLabel01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel01.Name = "linkLabel01";
            this.linkLabel01.Size = new System.Drawing.Size(265, 18);
            this.linkLabel01.TabIndex = 52;
            this.linkLabel01.TabStop = true;
            this.linkLabel01.Text = "Link to D2Coding Font webpage";
            this.linkLabel01.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel01_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCopyright, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 246);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxDescription.Location = new System.Drawing.Point(10, 64);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(10, 4, 6, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(488, 178);
            this.textBoxDescription.TabIndex = 24;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCopyright.Location = new System.Drawing.Point(10, 30);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(10, 0, 6, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 24);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(488, 24);
            this.labelCopyright.TabIndex = 22;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelVersion.Location = new System.Drawing.Point(10, 0);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(10, 0, 6, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 24);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(488, 24);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxThemeList
            // 
            this.comboBoxThemeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThemeList.Font = new System.Drawing.Font("Gulim", 11F);
            this.comboBoxThemeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxThemeList.FormattingEnabled = true;
            this.comboBoxThemeList.Items.AddRange(new object[] {
            "VS2012 Dark",
            "Dracular",
            "Dark Easy"});
            this.comboBoxThemeList.Location = new System.Drawing.Point(14, 291);
            this.comboBoxThemeList.Name = "comboBoxThemeList";
            this.comboBoxThemeList.Size = new System.Drawing.Size(284, 30);
            this.comboBoxThemeList.TabIndex = 54;
            this.comboBoxThemeList.SelectedIndexChanged += new System.EventHandler(this.comboBoxThemeList_SelectedIndexChanged);
            // 
            // ThemeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(516, 637);
            this.Controls.Add(this.comboBoxThemeList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.linkLabel01);
            this.Controls.Add(this.buttonModifyDLLauto1);
            this.Controls.Add(this.textBoxFontSize);
            this.Controls.Add(this.ApplyFontSize);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.labelfont);
            this.Controls.Add(this.selectedFont);
            this.Controls.Add(this.ApplyFont);
            this.Controls.Add(this.AddRegistry);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonModifyDLL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "ThemeEditorForm";
            this.Text = "VBE DarkMode Theme Quick V3.0";
            this.Load += new System.EventHandler(this.ThemeEditorForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyDLL;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button AddRegistry;
        private System.Windows.Forms.Button buttonModifyDLLauto;
        private System.Windows.Forms.Button ApplyFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox selectedFont;
        private System.Windows.Forms.Label labelfont;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Button ApplyFontSize;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.Button buttonModifyDLLauto1;
        private System.Windows.Forms.LinkLabel linkLabel01;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxThemeList;
    }
}

