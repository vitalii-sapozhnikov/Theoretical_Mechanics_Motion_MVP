namespace Theoretical_Mechanics_Motion_MVP
{
    class Presenter
    {
        Model model;
        IView view;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            model.RefreshImg += (par) => view.DrawImage(par);
            model.ResetImg += (s, e) => view.ResetImage();
            model.Omega = 2;
            view.OnDrawClick += (s, e) => model.DrawImage();
            view.OnStartMotionClick += (s, e) => model.StartMotion();
            view.OnStopMotionClick += (s, e) => model.StopMotion();
            view.Reset += (s, e) => model.Reset();
            view.ParameterChanged += (s, e) =>
            {
                model.BigRadius = view.BigRadius;
                model.SmallRadius = view.SmallRadius;
                model.Omega = view.Omega;
                
            };
            view.TrajectoryParamChanged += (s, e) =>
            {
                model.PointA = view.PointA;
                model.PointB = view.PointB;
            };
        }
        public void Run()
        {
            view.Run();
        }
    }
}
