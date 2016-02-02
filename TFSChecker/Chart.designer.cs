namespace TFS2010
{
    partial class ChartForm
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
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // chart1
         // 
         this.chart1.BackColor = System.Drawing.Color.Transparent;
         chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
         chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
         chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
         chartArea1.AxisX.IsLabelAutoFit = false;
         chartArea1.AxisX.LabelStyle.Format = "dd.MM HH:mm";
         chartArea1.AxisX.LabelStyle.Interval = 0D;
         chartArea1.AxisX.LineWidth = 2;
         chartArea1.AxisX.MajorGrid.Enabled = false;
         chartArea1.AxisX.MajorTickMark.LineWidth = 2;
         chartArea1.AxisX.MaximumAutoSize = 90F;
         chartArea1.AxisX.MinorGrid.Interval = 1D;
         chartArea1.AxisX.MinorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
         chartArea1.AxisX.ScaleView.MinSize = 1D;
         chartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
         chartArea1.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
         chartArea1.AxisX.ScaleView.SmallScrollSize = 1D;
         chartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
         chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
         chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
         chartArea1.AxisY.IsLabelAutoFit = false;
         chartArea1.AxisY.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap;
         chartArea1.AxisY.LabelStyle.Format = "0";
         chartArea1.AxisY.LabelStyle.Interval = 0D;
         chartArea1.AxisY.LineWidth = 2;
         chartArea1.AxisY.MajorTickMark.LineWidth = 2;
         chartArea1.AxisY.Title = "Number of Checkins";
         chartArea1.BackColor = System.Drawing.Color.LightGray;
         chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
         chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
         chartArea1.CursorX.IsUserEnabled = true;
         chartArea1.CursorX.IsUserSelectionEnabled = true;
         chartArea1.CursorX.LineColor = System.Drawing.Color.Blue;
         chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
         chartArea1.CursorX.LineWidth = 2;
         chartArea1.IsSameFontSizeForAllAxes = true;
         chartArea1.Name = "Default";
         this.chart1.ChartAreas.Add(chartArea1);
         this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
         legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
         legend1.IsEquallySpacedItems = true;
         legend1.Name = "Legend1";
         this.chart1.Legends.Add(legend1);
         this.chart1.Location = new System.Drawing.Point(0, 0);
         this.chart1.Name = "chart1";
         series1.ChartArea = "Default";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
         series1.Legend = "Legend1";
         series1.MarkerBorderWidth = 2;
         series1.Name = "X";
         series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
         series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         series2.ChartArea = "Default";
         series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
         series2.Legend = "Legend1";
         series2.Name = "Y";
         series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
         series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         series3.ChartArea = "Default";
         series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
         series3.Legend = "Legend1";
         series3.Name = "Z";
         series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
         series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         series4.ChartArea = "Default";
         series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
         series4.Legend = "Legend1";
         series4.Name = "X2";
         series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
         series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         series5.ChartArea = "Default";
         series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
         series5.Legend = "Legend1";
         series5.Name = "Y2";
         series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
         series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         series6.ChartArea = "Default";
         series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
         series6.Legend = "Legend1";
         series6.Name = "Z2";
         series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
         series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         this.chart1.Series.Add(series1);
         this.chart1.Series.Add(series2);
         this.chart1.Series.Add(series3);
         this.chart1.Series.Add(series4);
         this.chart1.Series.Add(series5);
         this.chart1.Series.Add(series6);
         this.chart1.Size = new System.Drawing.Size(576, 436);
         this.chart1.TabIndex = 2;
         this.chart1.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart1_GetToolTipText);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomOutToolStripMenuItem});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(136, 26);
         this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
         // 
         // zoomOutToolStripMenuItem
         // 
         this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
         this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
         this.zoomOutToolStripMenuItem.Text = "Reset zoom";
         this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
         // 
         // ChartForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(576, 436);
         this.Controls.Add(this.chart1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(500, 250);
         this.Name = "ChartForm";
         this.ShowIcon = false;
         this.Text = "Chart";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartForm_FormClosing);
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
    }
}