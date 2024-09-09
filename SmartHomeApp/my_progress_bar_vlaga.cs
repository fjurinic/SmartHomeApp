using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHomeApp
{
    public class my_progress_bar_vlaga : ProgressBar
    {
        public Brush brush;
        public my_progress_bar_vlaga()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            brush = Brushes.Orange;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Rectangle rectangle = e.ClipRectangle;
            rectangle.Width = (int)(rectangle.Width * ((double)Value / Maximum)) - 4;
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rectangle.Height = Height - 4;
            e.Graphics.FillRectangle(brush, 2, 2, rectangle.Width, rectangle.Height);
        }
    }
}
