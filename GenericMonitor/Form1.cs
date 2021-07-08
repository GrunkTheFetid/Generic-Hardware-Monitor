using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;

namespace VisualCSharpTestApp
{
    // Todo:
    // Enable draging form from toolstrip
    // Add more GPU info
    // Get CPU current speed
    // Add a custom progress bar for drive space
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        ManagementObject cpuManagement = new ManagementObject("Win32_Processor.DeviceId='CPU0'");

        double res;
        double res2;
        int CoreCount = 0;
        string CpuName;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Timer Setup
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            //Get CPU Info
            var CpuPercent = (long)(Math.Round(cpuCounter.NextValue(), 0));
            CpuUsageBar.Value = CpuPercent;

            var cpuSpeed = (uint)(cpuManagement["CurrentClockSpeed"]);
            CpuSpeedTxt.Text = Convert.ToString(cpuSpeed);

            foreach (var item in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                CoreCount += int.Parse(item["NumberOfCores"].ToString());
                CpuName = Convert.ToString(item["Name"]);
            }
            CpuCoreTxt.Text = Convert.ToString(CoreCount);
            CpuNameTxt.Text = CpuName;

            CpuThreadTxt.Text = Convert.ToString(Environment.ProcessorCount);

            //Get Memory Info
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                double TotalMem = Math.Round((res / (1024 * 1024)), 2);

                res2 = Convert.ToDouble(result["FreePhysicalMemory"]);
                double FreeMem = Math.Round((res2 / (1024 * 1024)), 2);

                double UsedMem = TotalMem - FreeMem;

                double MemPercent = Math.Round((UsedMem / TotalMem) * 100, 0);
                RamUsageBar.Value = (long)(MemPercent);
                RamAmtTxt.Text = Convert.ToString(TotalMem);
                RamUseTxt.Text = Convert.ToString(UsedMem);
            }

            query = new ObjectQuery("Select * from Win32_PhysicalMemory");
            searcher = new ManagementObjectSearcher(query);
            results = searcher.Get();
            foreach (ManagementObject result in results)
            {
                int MemSpeed = Convert.ToInt32(result["Speed"]);
                RamSpeedTxt.Text = Convert.ToString(MemSpeed);
            }

            //Get GPU Info
            query = new ObjectQuery("Select * from Win32_VideoController");
            searcher = new ManagementObjectSearcher(query);
            results = searcher.Get();
            foreach (ManagementObject result in results)
            {
                GpuNameTxt.Text = Convert.ToString(result["Name"]);
            }
            GpuUsageBar.Value = (long)GetGPUUsage();

            //Get Drive Info
            var x = 1;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Label match = panel3.Controls["DriveSpaceTxt" + Convert.ToString(x)] as Label;
                    Label match2 = panel3.Controls["DriveNameTxt" + Convert.ToString(x)] as Label;

                    double Size = drive.TotalSize / (1024 * 1024 * 1024);
                    double Available = drive.AvailableFreeSpace / (1024 * 1024 * 1024);
                    string SizeType;

                    if (Size < 1024)
                    {
                        SizeType = " GB";
                    }
                    else
                    {
                        SizeType = " TB";
                        Size = Math.Round(Size / 1024, 2);
                        Available = Math.Round(Available / 1024, 2);
                    }

                    match.Text = Convert.ToString(Size - Available) + SizeType + " / " + Convert.ToString(Size) + SizeType;
                    match2.Text = drive.Name;

                    match.Visible = true;
                    match2.Visible = true;
                }
                x += 1;
            }
        }

        //Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            Thread worker = new Thread(new ThreadStart(UpdateInfo));
            worker.Name = "Doer";
            worker.IsBackground = true;
            worker.Start();
        }

        private void UpdateInfo()
        {
            //Update CPU Info
            var CpuPercent = (long)(Math.Round(cpuCounter.NextValue(), 0));
            CpuUsageBar.Value = CpuPercent;

            var cpuSpeed = (uint)(cpuManagement["CurrentClockSpeed"]);
            CpuSpeedTxt.Text = Convert.ToString(cpuSpeed);

            //Update Memory Info
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                double TotalMem = Math.Round((res / (1024 * 1024)), 2);

                res2 = Convert.ToDouble(result["FreePhysicalMemory"]);
                double FreeMem = Math.Round((res2 / (1024 * 1024)), 2);

                double UsedMem = TotalMem - FreeMem;

                double MemPercent = Math.Round((UsedMem / TotalMem) * 100, 0);

                this.Invoke(new MethodInvoker(delegate
                {
                    RamUsageBar.Value = (long)(MemPercent);
                    RamUseTxt.Text = Convert.ToString(UsedMem);
                }));
            }

            //Update GPU Info
            GpuUsageBar.Value = (long)GetGPUUsage();
        }

        //Get GPU Usage
        public static float GetGPUUsage()
        {
            try
            {
                var category = new PerformanceCounterCategory("GPU Engine");
                var counterNames = category.GetInstanceNames();
                var gpuCounters = new List<PerformanceCounter>();
                var result = 0f;

                foreach (string counterName in counterNames)
                {
                    if (counterName.EndsWith("engtype_3D"))
                    {
                        foreach (PerformanceCounter counter in category.GetCounters(counterName))
                        {
                            if (counter.CounterName == "Utilization Percentage")
                            {
                                gpuCounters.Add(counter);
                            }
                        }
                    }
                }

                gpuCounters.ForEach(x =>
                {
                    _ = x.NextValue();
                });

                gpuCounters.ForEach(x =>
                {
                    result += x.NextValue();
                });

                return result;
            }
            catch
            {
                return 0f;
            }
        }

        //Drag Borderless Window
        protected override void WndProc(ref Message m)
        {
                switch (m.Msg)
                {
                    case 0x84:
                        base.WndProc(ref m);
                        if ((int)m.Result == 0x1)
                            m.Result = (IntPtr)0x2;
                        return;
                }

                base.WndProc(ref m);
        }

        //Form stuff
        private void ToolStripMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ToolStripClose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }

    public class CircularProgressBar : Control
    {
        #region Enums

        public enum _ProgressShape
        {
            Round,
            Flat
        }

        public enum _TextMode
        {
            None,
            Value,
            Percentage,
            Custom
        }

        #endregion

        #region Private Variables

        private long _Value;
        private long _Maximum = 100;
        private int _LineWitdh = 1;
        private float _BarWidth = 14f;

        private Color _ProgressColor1 = Color.Orange;
        private Color _ProgressColor2 = Color.Orange;
        private Color _LineColor = Color.Silver;
        private LinearGradientMode _GradientMode = LinearGradientMode.ForwardDiagonal;
        private _ProgressShape ProgressShapeVal;
        private _TextMode ProgressTextMode;

        #endregion

        #region Contructor

        public CircularProgressBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = SystemColors.Control;
            this.ForeColor = Color.DimGray;

            this.Size = new Size(130, 130);
            this.Font = new Font("Segoe UI", 15);
            this.MinimumSize = new Size(100, 100);
            this.DoubleBuffered = true;

            this.LineWidth = 1;
            this.LineColor = Color.DimGray;

            Value = 57;
            ProgressShape = _ProgressShape.Flat;
            TextMode = _TextMode.Percentage;
        }

        #endregion

        #region Public Custom Properties

        [Description("Integer value that determines the position of the progress bar"), Category("Behavior")]
        public long Value
        {
            get { return _Value; }
            set
            {
                if (value > _Maximum)
                    value = _Maximum;
                _Value = value;
                Invalidate();
            }
        }

        [Description("Gets or sets the maximum value of the progress bar"), Category("Behavior")]
        public long Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value < 1)
                    value = 1;
                _Maximum = value;
                Invalidate();
            }
        }

        [Description("Initial color of the progress bar"), Category("Appearance")]
        public Color BarColor1
        {
            get { return _ProgressColor1; }
            set
            {
                _ProgressColor1 = value;
                Invalidate();
            }
        }

        [Description("Final color of the progress bar"), Category("Appearance")]
        public Color BarColor2
        {
            get { return _ProgressColor2; }
            set
            {
                _ProgressColor2 = value;
                Invalidate();
            }
        }

        [Description("Progress bar width"), Category("Appearance")]
        public float BarWidth
        {
            get { return _BarWidth; }
            set
            {
                _BarWidth = value;
                Invalidate();
            }
        }

        [Description("Color gradient mode"), Category("Appearance")]
        public LinearGradientMode GradientMode
        {
            get { return _GradientMode; }
            set
            {
                _GradientMode = value;
                Invalidate();
            }
        }

        [Description("Line Color"), Category("Appearance")]
        public Color LineColor
        {
            get { return _LineColor; }
            set
            {
                _LineColor = value;
                Invalidate();
            }
        }

        [Description("Line Width"), Category("Appearance")]
        public int LineWidth
        {
            get { return _LineWitdh; }
            set
            {
                _LineWitdh = value;
                Invalidate();
            }
        }

        [Description("Progress bar shape"), Category("Appearance")]
        public _ProgressShape ProgressShape
        {
            get { return ProgressShapeVal; }
            set
            {
                ProgressShapeVal = value;
                Invalidate();
            }
        }

        [Description("Text displayed in progress bar"), Category("Behavior")]
        public _TextMode TextMode
        {
            get { return ProgressTextMode; }
            set
            {
                ProgressTextMode = value;
                Invalidate();
            }
        }

        [Description("Text displayed inside control"), Category("Behavior")]
        public override string Text { get; set; }

        #endregion

        #region EventArgs

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetStandardSize();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetStandardSize();
        }

        protected override void OnPaintBackground(PaintEventArgs p)
        {
            base.OnPaintBackground(p);
        }

        #endregion

        #region Methods

        private void SetStandardSize()
        {
            int _Size = Math.Max(Width, Height);
            Size = new Size(_Size, _Size);
        }

        public void Increment(int Val)
        {
            this._Value += Val;
            Invalidate();
        }

        public void Decrement(int Val)
        {
            this._Value -= Val;
            Invalidate();
        }
        #endregion

        #region Events

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    //graphics.Clear(Color.Transparent); //<-- this.BackColor, SystemColors.Control, Color.Transparent

                    PaintTransparentBackground(this, e);

                    //Draw inner white circle:
                    using (Brush mBackColor = new SolidBrush(this.BackColor))
                    {
                        graphics.FillEllipse(mBackColor,
                                18, 18,
                                (this.Width - 0x30) + 12,
                                (this.Height - 0x30) + 12);
                    }
                    // Draw thin line in the middle:
                    using (Pen pen2 = new Pen(LineColor, this.LineWidth))
                    {
                        graphics.DrawEllipse(pen2,
                            18, 18,
                          (this.Width - 0x30) + 12,
                          (this.Height - 0x30) + 12);
                    }

                    //Draw the progress bar
                    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                        this._ProgressColor1, this._ProgressColor2, this.GradientMode))
                    {
                        using (Pen pen = new Pen(brush, this.BarWidth))
                        {
                            switch (this.ProgressShapeVal)
                            {
                                case _ProgressShape.Round:
                                    pen.StartCap = LineCap.Round;
                                    pen.EndCap = LineCap.Round;
                                    break;

                                case _ProgressShape.Flat:
                                    pen.StartCap = LineCap.Flat;
                                    pen.EndCap = LineCap.Flat;
                                    break;
                            }

                            //Progress bar drawn here
                            graphics.DrawArc(pen,
                                0x12, 0x12,
                                (this.Width - 0x23) - 2,
                                (this.Height - 0x23) - 2,
                                -90,
                                (int)Math.Round((double)((360.0 / ((double)this._Maximum)) * this._Value)));
                        }
                    }

                    #region Draw the progress bar text

                    switch (this.TextMode)
                    {
                        case _TextMode.None:
                            this.Text = string.Empty;
                            break;

                        case _TextMode.Value:
                            this.Text = _Value.ToString();
                            break;

                        case _TextMode.Percentage:
                            this.Text = Convert.ToString(Convert.ToInt32((100 / _Maximum) * _Value));
                            break;

                        default:
                            break;
                    }

                    if (this.Text != string.Empty)
                    {
                        using (Brush FontColor = new SolidBrush(this.ForeColor))
                        {
                            int ShadowOffset = 2;
                            SizeF MS = graphics.MeasureString(this.Text, this.Font);
                            SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, this.ForeColor));

                            //Text Shadow:
                            graphics.DrawString(this.Text, this.Font, shadowBrush,
                                Convert.ToInt32(Width / 2 - MS.Width / 2) + ShadowOffset,
                                Convert.ToInt32(Height / 2 - MS.Height / 2) + ShadowOffset
                            );

                            //Control Text:
                            graphics.DrawString(this.Text, this.Font, FontColor,
                                Convert.ToInt32(Width / 2 - MS.Width / 2),
                                Convert.ToInt32(Height / 2 - MS.Height / 2));
                        }
                    }

                    #endregion

                    //Control is drawn:
                    e.Graphics.DrawImage(bitmap, 0, 0);
                    graphics.Dispose();
                    bitmap.Dispose();
                }
            }
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        /// <summary>Draw color filled circle.</summary>
        /// <param name="g">'Canvas' of the object where it will be drawn</param>
        /// <param name="brush">Fill color and style</param>
        /// <param name="centerX">Center of the circle on the X axis</param>
        /// <param name="centerY">Center of the circle on the Y axis</param>
        /// <param name="radius">Radio del Circulo</param>
        private void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
            {
                g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
            }
        }

        #endregion
    }
}