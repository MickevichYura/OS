using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4
{
    class BorderedPictureBox : PictureBox
    {
        public static Color DefaultBorderColor = Color.White;
        public static float DefaultBorderWidth = 2f;

        private Pen _BorderPen = new Pen(DefaultBorderColor, DefaultBorderWidth);
        /// <summary>
        /// Задает или возвращает цвет рамки
        /// </summary>
        public Color BorderColor { get { return _BorderPen.Color; } set { _BorderPen.Color = value; } }

        /// <summary>
        /// Задает или возвращает толщину рамки
        /// </summary>
        public float BorderWidth
        {
            get { return _BorderPen.Width; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _BorderPen.Width = value;
            }
        }

        private bool _drawBorder = true;
        /// <summary>
        /// Определяет, будет ли отрисована рамка
        /// </summary>
        public bool DrawBorder { get { return _drawBorder; } set { _drawBorder = value; } }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawRectangle(_BorderPen, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Right - 1, ClientRectangle.Bottom - 1);

        }
    }
}
