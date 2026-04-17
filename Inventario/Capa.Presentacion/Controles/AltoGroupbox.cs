using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AltoControls
{
    public class AltoGroupBox : ContainerControl
    {
        private int radius = 15;
        private Color backgroundColor = Color.White;
        private Color titleColor = Color.Black;

        public AltoGroupBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            BackColor = Color.White;
            Size = new Size(200, 150);
            Font = new Font("Segoe UI", 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);

            using (GraphicsPath path = GetRoundedRect(rect, radius))
            {
                // Fondo (tipo card)
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                    e.Graphics.FillPath(brush, path);

                // 🔥 SIN BORDE → limpio

                // Forma real redondeada
                this.Region = new Region(path);
            }

            // 🔥 TEXTO (opcional)
            if (!string.IsNullOrEmpty(Text))
            {
                using (SolidBrush textBrush = new SolidBrush(titleColor))
                {
                    e.Graphics.DrawString(Text, Font, textBrush, 10, 10);
                }
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }

        // 🔥 PROPIEDADES

        [Browsable(true)]
        [Category("Alto Controls")]
        public int Radius
        {
            get => radius;
            set { radius = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Alto Controls")]
        public Color BackgroundColor
        {
            get => backgroundColor;
            set { backgroundColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Alto Controls")]
        public Color TitleColor
        {
            get => titleColor;
            set { titleColor = value; Invalidate(); }
        }
    }
}