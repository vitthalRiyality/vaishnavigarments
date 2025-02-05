using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vaishnavi_Garment.CustomStyles
{
    public class RoundedButton : Button
    {
        private int _borderRadius;
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; Invalidate(); } // Ensure repaint on change
        }

        public RoundedButton()
        {
            BorderRadius = 20; // ✅ Set default radius
            BackColor = Color.DeepSkyBlue; // Default color
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0; // Hide default border
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle path
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();

                // Set the button region to rounded shape
                this.Region = new Region(path);

                // Fill button background
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw button text
                TextRenderer.DrawText(g, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
