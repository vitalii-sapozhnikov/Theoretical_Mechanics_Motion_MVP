using System.Drawing;
using System.Drawing.Drawing2D;

namespace TheoreticalMechanicsImage
{
    class Bearing
    {
        public int Radius { get; set; } = 4;
        public Point Center { get; set; }
        public Bearing(Point center)
        {
            Center = center;
        }
        public void Draw(Graphics graphics)
        {
            SolidBrush solid = new SolidBrush(Color.Black);
            Pen pen = new Pen(solid);

            // Triangle
            Point[] points = new Point[]
            {
                Center,
                new Point(Center.X - 6, Center.Y + 12),
                new Point(Center.X + 6, Center.Y + 12)
            };
            graphics.DrawPolygon(pen, points);

            // Circle
            Rectangle rectangle = new Rectangle(Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            solid.Color = Color.White;
            graphics.FillEllipse(solid, rectangle);
            graphics.DrawEllipse(pen, rectangle);
            
            // Rectangle
            rectangle = new Rectangle(Center.X - 15, Center.Y + 12, 30, 12);
            HatchBrush hatch = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Black, Color.White);
            graphics.FillRectangle(hatch, rectangle);
            graphics.DrawLine(pen, Center.X - 15, Center.Y + 12, Center.X + 15, Center.Y + 12);

            solid.Dispose();
            pen.Dispose();
        }
    }
}
