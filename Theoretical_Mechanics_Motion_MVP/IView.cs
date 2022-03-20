using System;
using TheoreticalMechanicsImage;

namespace Theoretical_Mechanics_Motion_MVP
{
    interface IView
    {
        event EventHandler OnDrawClick;
        event EventHandler OnStartMotionClick;
        event EventHandler OnStopMotionClick;
        event EventHandler Reset;
        event EventHandler ParameterChanged;
        event EventHandler TrajectoryParamChanged;
        double Omega { get; }
        int SmallRadius { get; }
        int BigRadius { get; }
        bool PointA { get; }
        bool PointB { get; }
        void DrawImage(Parameters parameters);
        void ResetImage();
        void Run();
    }
}
