using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Custom
{
    public class ButtonCustom : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("BogdanPhoenix")]
        public int BorderSize {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }
        [Category("BogdanPhoenix")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set 
            {
                if (value <= Height)
                    borderRadius = value;
                else
                    borderRadius = Height;
                Invalidate(); }
        }
        [Category("BogdanPhoenix")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }
        [Category("BogdanPhoenix")]
        public Color BackgroundColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }
        [Category("BogdanPhoenix")]
        public Color TextColor
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        //Constructor
        public ButtonCustom()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sebder, EventArgs e)
        {
            if (borderRadius > Height)
                BorderRadius = Height;
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = new Rectangle(0, 0, Width, Height);
            Rectangle rectBorder = new Rectangle(1, 1, Width - 1, Height - 1);

            if(borderRadius > 2) //rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                    using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                    using (Pen penSurface = new Pen(Parent.BackColor, 2))
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button surface
                    Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border
                    if(borderSize >= 1)
                    {
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Normal button
            {
                Region = new Region(rectSurface);
                if(borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        protected void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                Invalidate();
        }
    }
}
