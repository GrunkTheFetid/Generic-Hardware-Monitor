namespace VisualCSharpTestApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripClose = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMinimize = new System.Windows.Forms.ToolStripButton();
            this.CpuPanel = new System.Windows.Forms.Panel();
            this.CpuNameTxt = new System.Windows.Forms.Label();
            this.CpuUsageBar = new VisualCSharpTestApp.CircularProgressBar();
            this.CpuThreadTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CpuCoreTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CpuSpeedTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.RamSpeedTxt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RamUseTxt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RamAmtTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RamUsageBar = new VisualCSharpTestApp.CircularProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GpuNameTxt = new System.Windows.Forms.Label();
            this.GpuUsageBar = new VisualCSharpTestApp.CircularProgressBar();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DriveSpaceTxt4 = new System.Windows.Forms.Label();
            this.DriveNameTxt4 = new System.Windows.Forms.Label();
            this.DriveNameTxt3 = new System.Windows.Forms.Label();
            this.DriveNameTxt2 = new System.Windows.Forms.Label();
            this.DriveNameTxt1 = new System.Windows.Forms.Label();
            this.DriveSpaceTxt3 = new System.Windows.Forms.Label();
            this.DriveSpaceTxt2 = new System.Windows.Forms.Label();
            this.DriveSpaceTxt1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.CpuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Indigo;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ToolStripClose,
            this.ToolStripMinimize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(926, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(269, 37);
            this.toolStripLabel1.Text = "Generic Software";
            // 
            // ToolStripClose
            // 
            this.ToolStripClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripClose.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ToolStripClose.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripClose.Image")));
            this.ToolStripClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripClose.Name = "ToolStripClose";
            this.ToolStripClose.Size = new System.Drawing.Size(27, 37);
            this.ToolStripClose.Text = "X";
            this.ToolStripClose.Click += new System.EventHandler(this.ToolStripClose_Click_1);
            // 
            // ToolStripMinimize
            // 
            this.ToolStripMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMinimize.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.ToolStripMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMinimize.Image")));
            this.ToolStripMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMinimize.Name = "ToolStripMinimize";
            this.ToolStripMinimize.Size = new System.Drawing.Size(27, 37);
            this.ToolStripMinimize.Text = "-";
            this.ToolStripMinimize.Click += new System.EventHandler(this.ToolStripMinimize_Click_1);
            // 
            // CpuPanel
            // 
            this.CpuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CpuPanel.Controls.Add(this.CpuNameTxt);
            this.CpuPanel.Controls.Add(this.CpuUsageBar);
            this.CpuPanel.Controls.Add(this.CpuThreadTxt);
            this.CpuPanel.Controls.Add(this.label8);
            this.CpuPanel.Controls.Add(this.CpuCoreTxt);
            this.CpuPanel.Controls.Add(this.label7);
            this.CpuPanel.Controls.Add(this.CpuSpeedTxt);
            this.CpuPanel.Controls.Add(this.label6);
            this.CpuPanel.Controls.Add(this.label4);
            this.CpuPanel.Controls.Add(this.label2);
            this.CpuPanel.Controls.Add(this.label1);
            this.CpuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CpuPanel.Location = new System.Drawing.Point(25, 54);
            this.CpuPanel.Name = "CpuPanel";
            this.CpuPanel.Size = new System.Drawing.Size(424, 217);
            this.CpuPanel.TabIndex = 2;
            // 
            // CpuNameTxt
            // 
            this.CpuNameTxt.AutoSize = true;
            this.CpuNameTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CpuNameTxt.Location = new System.Drawing.Point(70, 11);
            this.CpuNameTxt.Name = "CpuNameTxt";
            this.CpuNameTxt.Size = new System.Drawing.Size(154, 26);
            this.CpuNameTxt.TabIndex = 11;
            this.CpuNameTxt.Text = "Line of long text";
            this.CpuNameTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CpuUsageBar
            // 
            this.CpuUsageBar.AllowDrop = true;
            this.CpuUsageBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CpuUsageBar.BarColor1 = System.Drawing.Color.Indigo;
            this.CpuUsageBar.BarColor2 = System.Drawing.Color.Indigo;
            this.CpuUsageBar.BarWidth = 14F;
            this.CpuUsageBar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CpuUsageBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CpuUsageBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CpuUsageBar.LineColor = System.Drawing.SystemColors.WindowFrame;
            this.CpuUsageBar.LineWidth = 1;
            this.CpuUsageBar.Location = new System.Drawing.Point(30, 46);
            this.CpuUsageBar.Maximum = ((long)(100));
            this.CpuUsageBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.CpuUsageBar.Name = "CpuUsageBar";
            this.CpuUsageBar.ProgressShape = VisualCSharpTestApp.CircularProgressBar._ProgressShape.Flat;
            this.CpuUsageBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CpuUsageBar.Size = new System.Drawing.Size(130, 130);
            this.CpuUsageBar.TabIndex = 4;
            this.CpuUsageBar.Text = "25";
            this.CpuUsageBar.TextMode = VisualCSharpTestApp.CircularProgressBar._TextMode.Percentage;
            this.CpuUsageBar.Value = ((long)(25));
            // 
            // CpuThreadTxt
            // 
            this.CpuThreadTxt.AutoSize = true;
            this.CpuThreadTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuThreadTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CpuThreadTxt.Location = new System.Drawing.Point(328, 149);
            this.CpuThreadTxt.Name = "CpuThreadTxt";
            this.CpuThreadTxt.Size = new System.Drawing.Size(24, 26);
            this.CpuThreadTxt.TabIndex = 9;
            this.CpuThreadTxt.Text = "0";
            this.CpuThreadTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(174, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Threads";
            // 
            // CpuCoreTxt
            // 
            this.CpuCoreTxt.AutoSize = true;
            this.CpuCoreTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuCoreTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CpuCoreTxt.Location = new System.Drawing.Point(340, 110);
            this.CpuCoreTxt.Name = "CpuCoreTxt";
            this.CpuCoreTxt.Size = new System.Drawing.Size(24, 26);
            this.CpuCoreTxt.TabIndex = 7;
            this.CpuCoreTxt.Text = "0";
            this.CpuCoreTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(174, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cores";
            // 
            // CpuSpeedTxt
            // 
            this.CpuSpeedTxt.AutoSize = true;
            this.CpuSpeedTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuSpeedTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CpuSpeedTxt.Location = new System.Drawing.Point(309, 72);
            this.CpuSpeedTxt.Name = "CpuSpeedTxt";
            this.CpuSpeedTxt.Size = new System.Drawing.Size(60, 26);
            this.CpuSpeedTxt.TabIndex = 5;
            this.CpuSpeedTxt.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(366, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "MHz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(174, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Base Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(50, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "% Usage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.RamSpeedTxt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.RamUseTxt);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.RamAmtTxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RamUsageBar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(25, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 217);
            this.panel1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(366, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 26);
            this.label15.TabIndex = 22;
            this.label15.Text = "MHz";
            // 
            // RamSpeedTxt
            // 
            this.RamSpeedTxt.AutoSize = true;
            this.RamSpeedTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamSpeedTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RamSpeedTxt.Location = new System.Drawing.Point(301, 149);
            this.RamSpeedTxt.Name = "RamSpeedTxt";
            this.RamSpeedTxt.Size = new System.Drawing.Size(60, 26);
            this.RamSpeedTxt.TabIndex = 21;
            this.RamSpeedTxt.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(174, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Speed";
            // 
            // RamUseTxt
            // 
            this.RamUseTxt.AutoSize = true;
            this.RamUseTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamUseTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RamUseTxt.Location = new System.Drawing.Point(301, 112);
            this.RamUseTxt.Name = "RamUseTxt";
            this.RamUseTxt.Size = new System.Drawing.Size(65, 26);
            this.RamUseTxt.TabIndex = 19;
            this.RamUseTxt.Text = "00.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(366, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "GB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(175, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "In Use";
            // 
            // RamAmtTxt
            // 
            this.RamAmtTxt.AutoSize = true;
            this.RamAmtTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamAmtTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RamAmtTxt.Location = new System.Drawing.Point(301, 75);
            this.RamAmtTxt.Name = "RamAmtTxt";
            this.RamAmtTxt.Size = new System.Drawing.Size(65, 26);
            this.RamAmtTxt.TabIndex = 16;
            this.RamAmtTxt.Text = "00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(366, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 26);
            this.label10.TabIndex = 15;
            this.label10.Text = "GB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(186, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total";
            // 
            // RamUsageBar
            // 
            this.RamUsageBar.AllowDrop = true;
            this.RamUsageBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RamUsageBar.BarColor1 = System.Drawing.Color.Indigo;
            this.RamUsageBar.BarColor2 = System.Drawing.Color.Indigo;
            this.RamUsageBar.BarWidth = 14F;
            this.RamUsageBar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.RamUsageBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RamUsageBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.RamUsageBar.LineColor = System.Drawing.SystemColors.WindowFrame;
            this.RamUsageBar.LineWidth = 1;
            this.RamUsageBar.Location = new System.Drawing.Point(30, 54);
            this.RamUsageBar.Maximum = ((long)(100));
            this.RamUsageBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.RamUsageBar.Name = "RamUsageBar";
            this.RamUsageBar.ProgressShape = VisualCSharpTestApp.CircularProgressBar._ProgressShape.Flat;
            this.RamUsageBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RamUsageBar.Size = new System.Drawing.Size(130, 130);
            this.RamUsageBar.TabIndex = 13;
            this.RamUsageBar.Text = "25";
            this.RamUsageBar.TextMode = VisualCSharpTestApp.CircularProgressBar._TextMode.Percentage;
            this.RamUsageBar.Value = ((long)(25));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(50, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "% Usage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "RAM";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.GpuNameTxt);
            this.panel2.Controls.Add(this.GpuUsageBar);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(477, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 217);
            this.panel2.TabIndex = 4;
            // 
            // GpuNameTxt
            // 
            this.GpuNameTxt.AutoSize = true;
            this.GpuNameTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuNameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GpuNameTxt.Location = new System.Drawing.Point(70, 11);
            this.GpuNameTxt.Name = "GpuNameTxt";
            this.GpuNameTxt.Size = new System.Drawing.Size(154, 26);
            this.GpuNameTxt.TabIndex = 11;
            this.GpuNameTxt.Text = "Line of long text";
            this.GpuNameTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GpuUsageBar
            // 
            this.GpuUsageBar.AllowDrop = true;
            this.GpuUsageBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GpuUsageBar.BarColor1 = System.Drawing.Color.Indigo;
            this.GpuUsageBar.BarColor2 = System.Drawing.Color.Indigo;
            this.GpuUsageBar.BarWidth = 14F;
            this.GpuUsageBar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.GpuUsageBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GpuUsageBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GpuUsageBar.LineColor = System.Drawing.SystemColors.WindowFrame;
            this.GpuUsageBar.LineWidth = 1;
            this.GpuUsageBar.Location = new System.Drawing.Point(30, 46);
            this.GpuUsageBar.Maximum = ((long)(100));
            this.GpuUsageBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.GpuUsageBar.Name = "GpuUsageBar";
            this.GpuUsageBar.ProgressShape = VisualCSharpTestApp.CircularProgressBar._ProgressShape.Flat;
            this.GpuUsageBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GpuUsageBar.Size = new System.Drawing.Size(130, 130);
            this.GpuUsageBar.TabIndex = 4;
            this.GpuUsageBar.Text = "25";
            this.GpuUsageBar.TextMode = VisualCSharpTestApp.CircularProgressBar._TextMode.Percentage;
            this.GpuUsageBar.Value = ((long)(25));
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label23.Location = new System.Drawing.Point(50, 187);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 26);
            this.label23.TabIndex = 2;
            this.label23.Text = "% Usage";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label24.Location = new System.Drawing.Point(13, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 30);
            this.label24.TabIndex = 0;
            this.label24.Text = "GPU";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.DriveSpaceTxt4);
            this.panel3.Controls.Add(this.DriveNameTxt4);
            this.panel3.Controls.Add(this.DriveNameTxt3);
            this.panel3.Controls.Add(this.DriveNameTxt2);
            this.panel3.Controls.Add(this.DriveNameTxt1);
            this.panel3.Controls.Add(this.DriveSpaceTxt3);
            this.panel3.Controls.Add(this.DriveSpaceTxt2);
            this.panel3.Controls.Add(this.DriveSpaceTxt1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(477, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 217);
            this.panel3.TabIndex = 5;
            // 
            // DriveSpaceTxt4
            // 
            this.DriveSpaceTxt4.AutoSize = true;
            this.DriveSpaceTxt4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveSpaceTxt4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveSpaceTxt4.Location = new System.Drawing.Point(200, 179);
            this.DriveSpaceTxt4.Name = "DriveSpaceTxt4";
            this.DriveSpaceTxt4.Size = new System.Drawing.Size(24, 26);
            this.DriveSpaceTxt4.TabIndex = 17;
            this.DriveSpaceTxt4.Text = "0";
            this.DriveSpaceTxt4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveSpaceTxt4.Visible = false;
            // 
            // DriveNameTxt4
            // 
            this.DriveNameTxt4.AutoSize = true;
            this.DriveNameTxt4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveNameTxt4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveNameTxt4.Location = new System.Drawing.Point(25, 179);
            this.DriveNameTxt4.Name = "DriveNameTxt4";
            this.DriveNameTxt4.Size = new System.Drawing.Size(29, 26);
            this.DriveNameTxt4.TabIndex = 16;
            this.DriveNameTxt4.Text = "C:";
            this.DriveNameTxt4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveNameTxt4.Visible = false;
            // 
            // DriveNameTxt3
            // 
            this.DriveNameTxt3.AutoSize = true;
            this.DriveNameTxt3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveNameTxt3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveNameTxt3.Location = new System.Drawing.Point(25, 147);
            this.DriveNameTxt3.Name = "DriveNameTxt3";
            this.DriveNameTxt3.Size = new System.Drawing.Size(29, 26);
            this.DriveNameTxt3.TabIndex = 15;
            this.DriveNameTxt3.Text = "C:";
            this.DriveNameTxt3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveNameTxt3.Visible = false;
            // 
            // DriveNameTxt2
            // 
            this.DriveNameTxt2.AutoSize = true;
            this.DriveNameTxt2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveNameTxt2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveNameTxt2.Location = new System.Drawing.Point(25, 110);
            this.DriveNameTxt2.Name = "DriveNameTxt2";
            this.DriveNameTxt2.Size = new System.Drawing.Size(29, 26);
            this.DriveNameTxt2.TabIndex = 14;
            this.DriveNameTxt2.Text = "C:";
            this.DriveNameTxt2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveNameTxt2.Visible = false;
            // 
            // DriveNameTxt1
            // 
            this.DriveNameTxt1.AutoSize = true;
            this.DriveNameTxt1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveNameTxt1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveNameTxt1.Location = new System.Drawing.Point(25, 75);
            this.DriveNameTxt1.Name = "DriveNameTxt1";
            this.DriveNameTxt1.Size = new System.Drawing.Size(29, 26);
            this.DriveNameTxt1.TabIndex = 13;
            this.DriveNameTxt1.Text = "C:";
            this.DriveNameTxt1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveNameTxt1.Visible = false;
            // 
            // DriveSpaceTxt3
            // 
            this.DriveSpaceTxt3.AutoSize = true;
            this.DriveSpaceTxt3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveSpaceTxt3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveSpaceTxt3.Location = new System.Drawing.Point(200, 147);
            this.DriveSpaceTxt3.Name = "DriveSpaceTxt3";
            this.DriveSpaceTxt3.Size = new System.Drawing.Size(24, 26);
            this.DriveSpaceTxt3.TabIndex = 12;
            this.DriveSpaceTxt3.Text = "0";
            this.DriveSpaceTxt3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveSpaceTxt3.Visible = false;
            // 
            // DriveSpaceTxt2
            // 
            this.DriveSpaceTxt2.AutoSize = true;
            this.DriveSpaceTxt2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveSpaceTxt2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveSpaceTxt2.Location = new System.Drawing.Point(200, 110);
            this.DriveSpaceTxt2.Name = "DriveSpaceTxt2";
            this.DriveSpaceTxt2.Size = new System.Drawing.Size(24, 26);
            this.DriveSpaceTxt2.TabIndex = 11;
            this.DriveSpaceTxt2.Text = "0";
            this.DriveSpaceTxt2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveSpaceTxt2.Visible = false;
            // 
            // DriveSpaceTxt1
            // 
            this.DriveSpaceTxt1.AutoSize = true;
            this.DriveSpaceTxt1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveSpaceTxt1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DriveSpaceTxt1.Location = new System.Drawing.Point(200, 75);
            this.DriveSpaceTxt1.Name = "DriveSpaceTxt1";
            this.DriveSpaceTxt1.Size = new System.Drawing.Size(24, 26);
            this.DriveSpaceTxt1.TabIndex = 10;
            this.DriveSpaceTxt1.Text = "0";
            this.DriveSpaceTxt1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DriveSpaceTxt1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label17.Location = new System.Drawing.Point(13, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.TabIndex = 0;
            this.label17.Text = "Drive(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(926, 549);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CpuPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generic Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CpuPanel.ResumeLayout(false);
            this.CpuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton ToolStripClose;
        private System.Windows.Forms.ToolStripButton ToolStripMinimize;
        private System.Windows.Forms.Panel CpuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CpuSpeedTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CpuCoreTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CpuThreadTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CpuNameTxt;
        private CircularProgressBar CpuUsageBar;
        private CircularProgressBar RamUsageBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RamAmtTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RamUseTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label RamSpeedTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GpuNameTxt;
        private CircularProgressBar GpuUsageBar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label DriveSpaceTxt1;
        private System.Windows.Forms.Label DriveSpaceTxt3;
        private System.Windows.Forms.Label DriveSpaceTxt2;
        private System.Windows.Forms.Label DriveNameTxt3;
        private System.Windows.Forms.Label DriveNameTxt2;
        private System.Windows.Forms.Label DriveNameTxt1;
        private System.Windows.Forms.Label DriveSpaceTxt4;
        private System.Windows.Forms.Label DriveNameTxt4;
    }
}

