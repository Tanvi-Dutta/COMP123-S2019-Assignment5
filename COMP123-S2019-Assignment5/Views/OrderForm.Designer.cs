namespace COMP123_S2019_Assignment5.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.FinishButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(722, 370);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(92, 36);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(522, 370);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 36);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(622, 370);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(92, 36);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(827, 24);
            this.OrderFormMenuStrip.TabIndex = 4;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OrderPrintForm
            // 
            this.OrderPrintForm.DocumentName = "document";
            this.OrderPrintForm.Form = this;
            this.OrderPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.OrderPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("OrderPrintForm.PrinterSettings")));
            this.OrderPrintForm.PrintFileName = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LCDSizeTextBox);
            this.groupBox1.Controls.Add(this.MemoryTextBox);
            this.groupBox1.Controls.Add(this.CPUBrandTextBox);
            this.groupBox1.Controls.Add(this.CPUSpeedTextBox);
            this.groupBox1.Controls.Add(this.OSTextBox);
            this.groupBox1.Controls.Add(this.WebCamTextBox);
            this.groupBox1.Controls.Add(this.HDDTextBox);
            this.groupBox1.Controls.Add(this.OSLabel);
            this.groupBox1.Controls.Add(this.WebcamLabel);
            this.groupBox1.Controls.Add(this.HDDLabel);
            this.groupBox1.Controls.Add(this.CPUSpeedLabel);
            this.groupBox1.Controls.Add(this.CPUBrandLabel);
            this.groupBox1.Controls.Add(this.MemoryLabel);
            this.groupBox1.Controls.Add(this.LCDSizeLabel);
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Controls.Add(this.ManufacturerTextBox);
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Controls.Add(this.PlatformTextBox);
            this.groupBox1.Controls.Add(this.PlatformLabel);
            this.groupBox1.Controls.Add(this.ConditionTextBox);
            this.groupBox1.Controls.Add(this.ConditionLabel);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Components";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(6, 31);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(95, 23);
            this.ConditionLabel.TabIndex = 5;
            this.ConditionLabel.Text = "Condition:";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(121, 28);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(106, 26);
            this.ConditionTextBox.TabIndex = 12;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(255, 33);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(95, 23);
            this.PlatformLabel.TabIndex = 13;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(356, 31);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(125, 26);
            this.PlatformTextBox.TabIndex = 14;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(121, 64);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(106, 26);
            this.ManufacturerTextBox.TabIndex = 16;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 67);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(109, 23);
            this.ManufacturerLabel.TabIndex = 15;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(356, 64);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(125, 26);
            this.ModelTextBox.TabIndex = 18;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(255, 67);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(95, 23);
            this.ModelLabel.TabIndex = 17;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(481, 339);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 468;
            this.lineShape1.Y1 = 83;
            this.lineShape1.Y2 = 84;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(6, 122);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(95, 23);
            this.LCDSizeLabel.TabIndex = 20;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(6, 156);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(95, 23);
            this.MemoryLabel.TabIndex = 21;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 186);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(95, 23);
            this.CPUBrandLabel.TabIndex = 22;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(9, 221);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(95, 23);
            this.CPUSpeedLabel.TabIndex = 25;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(6, 253);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(95, 23);
            this.HDDLabel.TabIndex = 26;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.Location = new System.Drawing.Point(6, 285);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(95, 23);
            this.WebcamLabel.TabIndex = 28;
            this.WebcamLabel.Text = "WebCam";
            this.WebcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(6, 326);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(95, 23);
            this.OSLabel.TabIndex = 29;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(107, 250);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(365, 26);
            this.HDDTextBox.TabIndex = 30;
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(107, 282);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(365, 26);
            this.WebCamTextBox.TabIndex = 32;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(107, 323);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(365, 26);
            this.OSTextBox.TabIndex = 33;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(107, 218);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(365, 26);
            this.CPUSpeedTextBox.TabIndex = 34;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(107, 186);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(365, 26);
            this.CPUBrandTextBox.TabIndex = 37;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(107, 154);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(365, 26);
            this.MemoryTextBox.TabIndex = 38;
            this.MemoryTextBox.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Location = new System.Drawing.Point(107, 119);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(365, 26);
            this.LCDSizeTextBox.TabIndex = 39;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTextBox);
            this.PriceGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.PriceGroupBox.Controls.Add(this.PriceTextBox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.shapeContainer2);
            this.PriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceGroupBox.Location = new System.Drawing.Point(522, 175);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(292, 189);
            this.PriceGroupBox.TabIndex = 6;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(6, 44);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(133, 23);
            this.PriceLabel.TabIndex = 21;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Location = new System.Drawing.Point(13, 82);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(126, 23);
            this.SalesTaxLabel.TabIndex = 22;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            this.SalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Location = new System.Drawing.Point(6, 142);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(95, 23);
            this.TotalLabel.TabIndex = 23;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 274;
            this.lineShape2.Y1 = 102;
            this.lineShape2.Y2 = 102;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(286, 164);
            this.shapeContainer2.TabIndex = 24;
            this.shapeContainer2.TabStop = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(145, 41);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(133, 26);
            this.PriceTextBox.TabIndex = 25;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(145, 79);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(133, 26);
            this.SalesTaxTextBox.TabIndex = 26;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(100, 139);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(178, 26);
            this.TotalTextBox.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2019_Assignment5.Properties.Resources.wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(522, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 136);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(827, 409);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm OrderPrintForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}