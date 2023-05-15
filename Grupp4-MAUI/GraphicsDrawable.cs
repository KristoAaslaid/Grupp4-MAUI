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
        // Class for drawing graphics, not used, but keeping it as a reminder
        private const float ArrowLength = 40f;
        private const float ArrowWidth = 80f;
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            // Drawing code goes here
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 6;
            canvas.DrawEllipse(10, 50, 300, 300);
            // Draw compass text using Drawstring
            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 2;
            canvas.FontSize = 24;
            canvas.DrawString("N", 130, 60, 60, 60, HorizontalAlignment.Center, VerticalAlignment.Top); //N ja S on fine aga W ja E on sus
            canvas.DrawString("S", 130, 310, 60, 60, HorizontalAlignment.Center, VerticalAlignment.Top);
            canvas.DrawString("W", 10, 190, 60, 60, HorizontalAlignment.Center, VerticalAlignment.Top);
            canvas.DrawString("E", 250, 190, 60, 60, HorizontalAlignment.Center, VerticalAlignment.Top);
            // Draw compass needle using DrawLine
            canvas.StrokeColor = Colors.Blue;
            canvas.StrokeSize = 4;
            canvas.DrawLine(160, 160, 160, 40);
            canvas.DrawLine(160, 160, 160, 280);
            canvas.DrawLine(160, 160, 40, 160);
            canvas.DrawLine(160, 160, 280, 160);
            // Compass arrow is pointed at where value is read from sensor

        }

	}
}