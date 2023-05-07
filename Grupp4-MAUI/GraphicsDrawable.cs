using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Microsoft.Maui.Graphics;

namespace Grupp4_MAUI
{
	public class GraphicsDrawable : IDrawable
	{
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            // Drawing code goes here
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 6;
            canvas.DrawEllipse(10, 50, 300, 300);
        }

	}
}