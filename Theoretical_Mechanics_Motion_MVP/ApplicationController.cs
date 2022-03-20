using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theoretical_Mechanics_Motion_MVP
{
    class ApplicationController
    {
        private FormView main;
        private Presenter presenter;

        public ApplicationController()
        {
            Model model = new Model();
            main = new FormView();
            presenter = new Presenter(model, main);
        }
        public void Run()
        {
            presenter.Run();
        }
    }
}
