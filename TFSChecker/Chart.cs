/*
   PACKAGE:    TFS Checker application
   FILE:       Chart.cs
   ABSTRACT:   Chart form which displays the results of TFS stats tool
   AUTHOR:     Jens Fiedler
*/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TFS2010
{
    public partial class ChartForm : Form
    {
        public string File = "";
        public string Comment = "";
        private readonly Form1 _parent;

        public ChartForm(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            chart1.MouseWheel += chart_MouseWheel;
            SetupSeries();
        }

        private void SetupSeries()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";

            foreach (var pair in _parent.Checkins)
            {
                var ser = chart1.Series.Add(pair.Key);
                ser.ChartType = SeriesChartType.FastLine;
                ser.XValueType = ChartValueType.DateTime;
                ser.BorderWidth = 2;
                ser.EmptyPointStyle.Color = Color.Gray;
                ser.EmptyPointStyle.BorderWidth = 0;
                ser.EmptyPointStyle.MarkerStyle = MarkerStyle.None;
                ser.EmptyPointStyle.MarkerSize = 7;
                ser.EmptyPointStyle.MarkerBorderColor = Color.Black;
                ser.EmptyPointStyle.MarkerColor = Color.LightGray;
                ser.XValueType = ChartValueType.DateTime;
                var i = 0;
                var dic = pair.Value.OrderBy(key => key.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var time in dic)
                {
                    //i += time.Value; //use this to display the number of checked in files (instead of i++)
                    i++;
                    ser.Points.AddXY(time.Key.ToOADate(), i);
                }
            }
        }

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                SetupSeries();
                var xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                var xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;

                if (e.Delta < 0)
                {
                    var posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin);
                    var posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin);

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }
                else if (e.Delta > 0)
                {
                    var posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                var i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = "Name: " + e.HitTestResult.Series.Name + "\nDate: " + (DateTime.FromOADate(dp.XValue).ToShortDateString() +
                                                                                "\nValue: " + dp.YValues[0].ToString(CultureInfo.InvariantCulture));
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            zoomOutToolStripMenuItem.Enabled = chart1.ChartAreas[0].AxisX.ScaleView.IsZoomed;
        }
    }
}