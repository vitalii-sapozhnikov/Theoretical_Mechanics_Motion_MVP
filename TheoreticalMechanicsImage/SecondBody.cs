using System;
using System.Drawing;

namespace TheoreticalMechanicsImage
{
    class SecondBody
    {
        public Point Center { get; set; }
        public int SmallRadius { get; set; }
        public int BigRadius { get; set; }
        public float Angle { get; set; } = 0;

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);

            // Circle r2
            Rectangle rectangle = new Rectangle(Center.X-SmallRadius, Center.Y - SmallRadius, SmallRadius * 2, SmallRadius * 2);
            graphics.DrawEllipse(pen, rectangle);
            // Circle R2
            rectangle = new Rectangle(Center.X - BigRadius, Center.Y - BigRadius, BigRadius * 2, BigRadius * 2);
            graphics.DrawEllipse(pen, rectangle);

            // Horizontal diameter
            Point A = new Point(Center.X - (int)Math.Round(BigRadius * Math.Cos(Angle)), Center.Y + (int)Math.Round(BigRadius * Math.Sin(Angle)));
            Point B = new Point(Center.X + (int)Math.Round(BigRadius * Math.Cos(Angle)), Center.Y - (int)Math.Round(BigRadius * Math.Sin(Angle)));

            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(pen, A, B);

            // Vertical diameter
            A = new Point(Center.X - (int)Math.Round(BigRadius * Math.Cos(Angle + Math.PI / 2)), Center.Y + (int)Math.Round(BigRadius * Math.Sin(Angle + Math.PI / 2)));
            B = new Point(Center.X + (int)Math.Round(BigRadius * Math.Cos(Angle + Math.PI / 2)), Center.Y - (int)Math.Round(BigRadius * Math.Sin(Angle + Math.PI / 2)));
            graphics.DrawLine(pen, A, B);

            pen.Dispose();
        }
    }
}
