using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Vaishnavi_Garment.CustomStyles
{
    public class GradientPanel : Panel
    {
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }

        public GradientPanel()
        {
            StartColor = Color.Blue;
            EndColor = Color.Purple;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Ensure the panel is repainted
            this.Invalidate();

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, StartColor, EndColor, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
