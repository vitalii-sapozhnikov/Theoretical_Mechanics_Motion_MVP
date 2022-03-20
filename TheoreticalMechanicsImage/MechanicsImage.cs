using System.Drawing;
using System;

namespace TheoreticalMechanicsImage
{
    public class MechanicsImage
    {
        Parameters parameters;
        public MechanicsImage(Parameters parameters)
        {
            this.parameters = parameters;
        }

        public static void Reset() => ThirdBody.Reset();
        public static void HidePString() => ThirdBody.PointsShow = false;
        public static void ShowPString() => ThirdBody.PointsShow = true;

        public void DrawImage(Graphics graphics)
        {
            Point Center = parameters.SecondBodyPosition;
            Bearing bearing = new Bearing(Center);
            bearing.Draw(graphics);

            SecondBody second = new SecondBody
            {
                Center = parameters.SecondBodyPosition,
                SmallRadius = parameters.SecondBodySmallRadius,
                BigRadius = parameters.SecondBodyBigRadius,
                Angle = parameters.SecondBodyAngle
            };
            second.Draw(graphics);

            Pen pen = new Pen(Color.Black);
            {
                int radius = (parameters.SecondBodyBigRadius + parameters.SecondBodySmallRadius) / 2;
                ThirdBody third = new ThirdBody
                {
                    Center = parameters.ThirdBodyPosition,
                    Angle = parameters.ThirdBodyAngle,
                    Radius = radius,
                    PointATrajectory = parameters.PointA,
                    PointBTrajectory = parameters.PointB
                };
                graphics.DrawLine(pen, Center.X - parameters.SecondBodySmallRadius, Center.Y, Center.X - parameters.SecondBodySmallRadius, parameters.ThirdBodyPosition.Y);
                graphics.DrawLine(pen, Center.X + parameters.SecondBodyBigRadius, Center.Y, Center.X + parameters.SecondBodyBigRadius, parameters.ThirdBodyPosition.Y);
                third.Draw(graphics);
            }
            {                
                FirstBody first = new FirstBody
                {
                    Center = parameters.FirstBodyPosition,
                    Width = (parameters.SecondBodyBigRadius - parameters.SecondBodySmallRadius) *0.85 > 40 ? 40 :
                    (int)Math.Round((parameters.SecondBodyBigRadius - parameters.SecondBodySmallRadius) * 0.85),
                    Height = 70
                };
                int centerX = parameters.FirstBodyPosition.X;
                int centerY = parameters.FirstBodyPosition.Y;
                graphics.DrawLine(pen, centerX, Center.Y, centerX, centerY - first.Height/2);
                first.Draw(graphics);
            }            
        }
    }
}
