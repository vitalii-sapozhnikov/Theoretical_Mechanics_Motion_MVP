using System;
using System.Timers;
using System.Drawing;
using TheoreticalMechanicsImage;


namespace Theoretical_Mechanics_Motion_MVP
{
    delegate void ImageRefreshHandler(Parameters parameters);
    class Model
    {
        private Point center = new Point(0, 0);
        private Parameters parameters;
        private Timer timer;
        private double modelTime = 0;
        private double refreshFrequencySeconds = 0.01;

        public double Omega { private get; set; } = 2;
        public int BigRadius { private get; set; } = 80;
        public int SmallRadius { private get; set; } = 40;
        public bool PointA { private get; set; } = false;
        public bool PointB { private get; set; } = false;


        public event ImageRefreshHandler RefreshImg;
        public event EventHandler ResetImg;

        public Model()
        {
            timer = new Timer(refreshFrequencySeconds * 1000);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            modelTime += refreshFrequencySeconds;
            DrawImage();
        }
        public void StartMotion()
        {
            if (modelTime == 0)
                ResetImg?.Invoke(this, EventArgs.Empty);
            timer.Enabled = true;
        }
        public void StopMotion() => timer.Enabled = false;
        public void DrawImage()
        {
            parameters = new Parameters
            {
                SecondBodyPosition = center,
                SecondBodySmallRadius = SmallRadius,
                SecondBodyBigRadius = BigRadius,
                ThirdBodyPosition = new Point(center.X + (BigRadius - SmallRadius) / 2, center.Y + 400 - ThirdBodyDeltaY(parameters)),
                SecondBodyAngle = (float)(Omega * modelTime),
                ThirdBodyAngle = (float)(Omega * modelTime),

                FirstBodyPosition = new Point(center.X - BigRadius, center.Y + BigRadius +
                (int)Math.Round(BigRadius * 0.1 + 35) + FirstBodyDeltaY(parameters)),

                PointA = this.PointA,
                PointB = this.PointB
            };
            if (parameters.SecondBodySmallRadius > parameters.SecondBodyBigRadius)
                throw new Exception("r2 bigger than R2 exception!");
            RefreshImg?.Invoke(parameters);
        }
        private int FirstBodyDeltaY(Parameters par) =>
            (int)Math.Round(Omega * parameters.SecondBodyBigRadius * modelTime);
        private int ThirdBodyDeltaY(Parameters par) =>
            (int)Math.Round(Omega * (parameters.SecondBodyBigRadius - parameters.SecondBodySmallRadius) / 2 * modelTime);
        public void Reset()
        {
            modelTime = 0;
            ResetImg?.Invoke(this, EventArgs.Empty);
        }
    }
}
