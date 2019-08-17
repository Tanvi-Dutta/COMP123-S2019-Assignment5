namespace COMP123_S2019_Assignment5.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.ProductInfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.NextLabel = new System.Windows.Forms.Label();
            this.AnotherProductButton = new System.Windows.Forms.Button();
            this.ProductInfoFormMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(661, 380);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(68, 26);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(733, 380);
            this.Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(61, 26);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ProductInfoFormMenuStrip
            // 
            this.ProductInfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoFormMenuStrip.Name = "ProductInfoFormMenuStrip";
            this.ProductInfoFormMenuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.ProductInfoFormMenuStrip.Size = new System.Drawing.Size(805, 24);
            this.ProductInfoFormMenuStrip.TabIndex = 3;
            this.ProductInfoFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select &Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductToolStripMenuItem_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Location = new System.Drawing.Point(52, 56);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(95, 23);
            this.ProductIDLabel.TabIndex = 4;
            this.ProductIDLabel.Text = "Product ID :";
            this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(144, 54);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(70, 26);
            this.ProductIDTextBox.TabIndex = 5;
            // 
            // CostLabel
            // 
            this.CostLabel.Location = new System.Drawing.Point(506, 56);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(64, 23);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost:";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(258, 56);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(81, 23);
            this.ConditionLabel.TabIndex = 7;
            this.ConditionLabel.Text = "Condition:";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(345, 53);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(114, 26);
            this.ConditionTextBox.TabIndex = 8;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(576, 53);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(112, 26);
            this.CostTextBox.TabIndex = 9;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 98);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(781, 100);
            this.ProductInfoGroupBox.TabIndex = 10;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(26, 28);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(95, 23);
            this.PlatformLabel.TabIndex = 5;
            this.PlatformLabel.Text = "   Platform :";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 64);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(115, 23);
            this.ManufacturerLabel.TabIndex = 11;
            this.ManufacturerLabel.Text = "Manufacturer :";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(127, 28);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(106, 26);
            this.PlatformTextBox.TabIndex = 11;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(127, 61);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(106, 26);
            this.ManufacturerTextBox.TabIndex = 12;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(246, 30);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(95, 23);
            this.OSLabel.TabIndex = 11;
            this.OSLabel.Text = "OS :";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(246, 63);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(95, 23);
            this.ModelLabel.TabIndex = 11;
            this.ModelLabel.Text = "Model :";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(347, 31);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(428, 26);
            this.OSTextBox.TabIndex = 11;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(347, 62);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(428, 26);
            this.ModelTextBox.TabIndex = 12;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 220);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(780, 155);
            this.TechSpecsGroupBox.TabIndex = 11;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(6, 33);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(95, 23);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Memory:";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(5, 75);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(95, 23);
            this.CPUBrandLabel.TabIndex = 7;
            this.CPUBrandLabel.Text = "CPU Brand:";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(5, 116);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(95, 23);
            this.CPUTypeLabel.TabIndex = 8;
            this.CPUTypeLabel.Text = "CPU Type :";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(107, 31);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(106, 26);
            this.MemoryTextBox.TabIndex = 12;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(106, 72);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUBrandTextBox.TabIndex = 13;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Location = new System.Drawing.Point(106, 116);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUTypeTextBox.TabIndex = 14;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(231, 33);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(95, 23);
            this.LCDSizeLabel.TabIndex = 15;
            this.LCDSizeLabel.Text = "LCD Size :";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Location = new System.Drawing.Point(218, 75);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(108, 23);
            this.CPUNumberLabel.TabIndex = 16;
            this.CPUNumberLabel.Text = "CPU Number:";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(218, 119);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(101, 23);
            this.CPUSpeedLabel.TabIndex = 17;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Location = new System.Drawing.Point(322, 33);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(106, 26);
            this.LCDSizeTextBox.TabIndex = 18;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Location = new System.Drawing.Point(322, 73);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.ReadOnly = true;
            this.CPUNumberTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUNumberTextBox.TabIndex = 19;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(322, 116);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUSpeedTextBox.TabIndex = 20;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(434, 36);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(95, 23);
            this.HDDLabel.TabIndex = 21;
            this.HDDLabel.Text = "HDD:";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Location = new System.Drawing.Point(434, 74);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(95, 23);
            this.GPUTypeLabel.TabIndex = 22;
            this.GPUTypeLabel.Text = "GPU Type:";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Location = new System.Drawing.Point(434, 116);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(95, 23);
            this.WebCamLabel.TabIndex = 23;
            this.WebCamLabel.Text = "WebCam :";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(535, 36);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(239, 26);
            this.HDDTextBox.TabIndex = 24;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Location = new System.Drawing.Point(535, 75);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(239, 26);
            this.GPUTypeTextBox.TabIndex = 25;
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(535, 113);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(239, 26);
            this.WebCamTextBox.TabIndex = 26;
            // 
            // NextLabel
            // 
            this.NextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLabel.Location = new System.Drawing.Point(9, 385);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(359, 23);
            this.NextLabel.TabIndex = 12;
            this.NextLabel.Text = "Click Next to confirm your selection";
            this.NextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnotherProductButton
            // 
            this.AnotherProductButton.Location = new System.Drawing.Point(462, 380);
            this.AnotherProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.AnotherProductButton.Name = "AnotherProductButton";
            this.AnotherProductButton.Size = new System.Drawing.Size(182, 26);
            this.AnotherProductButton.TabIndex = 13;
            this.AnotherProductButton.Text = "Select Another Product";
            this.AnotherProductButton.UseVisualStyleBackColor = true;
            this.AnotherProductButton.Click += new System.EventHandler(this.AnotherProductButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(805, 417);
            this.ControlBox = false;
            this.Controls.Add(this.AnotherProductButton);
            this.Controls.Add(this.NextLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ProductInfoFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.ProductInfoFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoFormMenuStrip.ResumeLayout(false);
            this.ProductInfoFormMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.MenuStrip ProductInfoFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label NextLabel;
        private System.Windows.Forms.Button AnotherProductButton;
    }
}