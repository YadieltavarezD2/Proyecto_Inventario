using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AltoControls
{
    public class AltoTextBox : Control
    {
        private TextBox box = new TextBox();
        private int radius = 10;

        private Color backgroundColor = Color.White;

        private string placeholder = "Escribe aquí...";
        private Color placeholderColor = Color.Gray;
        private bool isPlaceholderActive = true;

        public AltoTextBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.Selectable, true);

            Size = new Size(150, 35);
            Font = new Font("Segoe UI", 10);
            TabStop = true;

            // TextBox interno
            box.BorderStyle = BorderStyle.None;
            box.Font = Font;
            box.BackColor = backgroundColor;
            box.ForeColor = placeholderColor;
            box.TabStop = false;

            Controls.Add(box);

            // Eventos
            box.Enter += RemovePlaceholder;
            box.Leave += SetPlaceholder;
            box.TextChanged += (s, e) =>
            {
                if (!isPlaceholderActive)
                    base.Text = box.Text;
            };

            this.Enter += (s, e) => box.Focus();

            // 🔥 Inicializar placeholder correctamente
            SetPlaceholder(null, null);
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                isPlaceholderActive = false;
                box.Text = "";
                box.ForeColor = ForeColor;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                isPlaceholderActive = true;
                box.Text = placeholder;
                box.ForeColor = placeholderColor;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int padding = 10;
            box.Location = new Point(padding, (Height - box.Height) / 2);
            box.Width = Width - (padding * 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);

            using (GraphicsPath path = GetRoundedRect(rect, radius))
            {
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                    e.Graphics.FillPath(brush, path);

                // 🔥 SIN BORDE → no pixelado
                // e.Graphics.DrawPath(...)

                this.Region = new Region(path);
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
        public override string Text
        {
            get => isPlaceholderActive ? "" : box.Text;
            set
            {
                isPlaceholderActive = false;
                box.Text = value;
                box.ForeColor = ForeColor;
            }
        }

        [Browsable(true)]
        [Category("Alto Controls")]
        public string Placeholder
        {
            get => placeholder;
            set
            {
                placeholder = value;

                if (isPlaceholderActive)
                {
                    box.Text = value;
                    box.ForeColor = placeholderColor;
                }

                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Alto Controls")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;

                if (isPlaceholderActive)
                    box.ForeColor = value;
            }
        }

        [Browsable(true)]
        [Category("Alto Controls")]
        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                box.BackColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Alto Controls")]
        public int Radius
        {
            get => radius;
            set { radius = value; Invalidate(); }
        }
    }
}