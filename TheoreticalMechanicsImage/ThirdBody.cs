using System;
using System.Drawing;
using System.Collections.Generic;

namespace TheoreticalMechanicsImage
{
    class ThirdBody
    {
        private static List<Point> pointsListA = new List<Point>();
        private static List<Point> pointsListB = new List<Point>();
        public static bool PointsShow { get; set; } = true;
        public static void Reset()
        {
            pointsListA.Clear();
            pointsListB.Clear();
        }
        public int Radius { get; set; }
        public Point Center { get; set; }
        public float Angle { get; set; }
        public bool PointATrajectory { get; set; }
        public bool PointBTrajectory { get; set; }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);

            // Circle r2
            Rectangle rectangle = new Rectangle(Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            graphics.DrawEllipse(pen, rectangle);

            // Horizontal diameter
            Point A = new Point(Center.X - (int)Math.Round(Radius * Math.Cos(Angle)), Center.Y + (int)Math.Round(Radius * Math.Sin(Angle)));
            Point B = new Point(Center.X + (int)Math.Round(Radius * Math.Cos(Angle)), Center.Y - (int)Math.Round(Radius * Math.Sin(Angle)));

            if (pointsListA.Count == 0)
                pointsListA.Add(A);
            if (pointsListB.Count == 0)
                pointsListB.Add(B);

            pointsListA.Add(A);
            pointsListB.Add(B);

            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(pen, A, B);

            if (PointATrajectory)
            {
                Pen penA = new Pen(Color.FromArgb(255, 17, 187, 12));
                graphics.DrawCurve(penA, pointsListA.ToArray());
                penA.Dispose();
            }
            if (PointBTrajectory)
            {
                Pen penB = new Pen(Color.FromArgb(255, 187, 32, 122));
                graphics.DrawCurve(penB, pointsListB.ToArray());
                penB.Dispose();
            }
            if(PointsShow)
            {
                SolidBrush brush = new SolidBrush(Color.Black);
                graphics.DrawString("A", new Font(FontFamily.GenericMonospace, 14f, FontStyle.Bold), brush, A.X - 25, A.Y - 10);
                graphics.DrawString("B", new Font(FontFamily.GenericMonospace, 14f, FontStyle.Bold), brush, B.X +5, B.Y - 10);
            }


            // Vertical diameter
            A = new Point(Center.X - (int)Math.Round(Radius * Math.Cos(Angle + Math.PI / 2)), Center.Y + (int)Math.Round(Radius * Math.Sin(Angle + Math.PI / 2)));
            B = new Point(Center.X + (int)Math.Round(Radius * Math.Cos(Angle + Math.PI / 2)), Center.Y - (int)Math.Round(Radius * Math.Sin(Angle + Math.PI / 2)));
            graphics.DrawLine(pen, A, B);

            pen.Dispose();
        }
    }
}
