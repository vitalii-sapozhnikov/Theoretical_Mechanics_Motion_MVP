using System.Drawing;

namespace TheoreticalMechanicsImage
{
    public struct Parameters
    {
        public Point FirstBodyPosition { get; set; }
        public Point SecondBodyPosition { get; set; }
        public Point ThirdBodyPosition { get; set; }
        public int SecondBodySmallRadius { get; set; }
        public int SecondBodyBigRadius { get; set; }
        public float SecondBodyAngle { get; set; }
        public float ThirdBodyAngle { get; set; }
        public bool PointA { get; set; }
        public bool PointB { get; set; }
        public void ParallelTransfer(int x, int y)
        {
            FirstBodyPosition = new Point(FirstBodyPosition.X + x, FirstBodyPosition.Y + y);
            SecondBodyPosition = new Point(SecondBodyPosition.X + x, SecondBodyPosition.Y + y);
            ThirdBodyPosition = new Point(ThirdBodyPosition.X + x, ThirdBodyPosition.Y + y);
        }
    }
}
