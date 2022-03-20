using System.Drawing;

namespace TheoreticalMechanicsImage
{
    class FirstBody
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Center { get; set; }

        public void Draw(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(Center.X - Width / 2, Center.Y - Height / 2, Width, Height);
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, rectangle);
            pen.Dispose();
        }
    }
}
