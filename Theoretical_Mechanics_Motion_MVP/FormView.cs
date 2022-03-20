using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;
using Theoretical_Mechanics_Motion_MVP.Properties;
using TheoreticalMechanicsImage;

namespace Theoretical_Mechanics_Motion_MVP
{
    public partial class FormView : Form, IView
    {
        #region --Fields--
        private Parameters param;
        private bool blank = true;
        #endregion

        #region --Properties--
        public double Omega => (double)OmegaNumericUpDown.Value;

        public int SmallRadius => (int)SmallRaduisNumericUpDown.Value;

        public int BigRadius => (int)BigRadiusNumericUpDown.Value;

        public bool PointA => PointACheckBox.Checked;

        public bool PointB => PointBCheckBox.Checked;
        #endregion

        #region --Events--
        public event EventHandler OnDrawClick;
        public event EventHandler OnStartMotionClick;
        public event EventHandler OnStopMotionClick;
        public event EventHandler Reset;
        public event EventHandler ParameterChanged;
        public event EventHandler TrajectoryParamChanged;
        #endregion

        public FormView()
        {
            InitializeComponent();
            Animator.Start();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            pictureBoxMain.Location = new Point(ClientRectangle.X + panel.Width, ClientRectangle.Y);
            pictureBoxMain.Width = ClientRectangle.Width - panel.Width;
            pictureBoxMain.Height = ClientRectangle.Height;
            DoubleBuffered = true;
            pictureBoxMain.Paint += (s, paintEvent) =>
            {
                paintEvent.Graphics.Clear(Color.White);
                if (!blank)
                {
                    MechanicsImage image = new MechanicsImage(param);
                    image.DrawImage(paintEvent.Graphics);
                }
            };

            #region --ToolTip Initialization-- 
            ToolTip toolTip1 = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };
            toolTip1.SetToolTip(BigRadiusNumericUpDown, "Устанавливает значение большого радиуса второго тела:\nот " +
                $"{BigRadiusNumericUpDown.Minimum} до {BigRadiusNumericUpDown.Maximum}");
            toolTip1.SetToolTip(SmallRaduisNumericUpDown, "Устанавливает значение малого радиуса второго тела:\nот " +
                $"{SmallRaduisNumericUpDown.Minimum} до {SmallRaduisNumericUpDown.Maximum}");
            toolTip1.SetToolTip(OmegaNumericUpDown, "Устанавливает значение угловой скорости второго тела:\nот " +
                $"{OmegaNumericUpDown.Minimum} до {OmegaNumericUpDown.Maximum}");
            #endregion
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            blank = false;

            #region --Enabling and Disabling Buttons--
            StartButton.Enabled = true;
            DrawButton.Enabled = false;
            ClearButton.Enabled = true;
            MechanicsImage.ShowPString();
            #endregion

            OnDrawClick?.Invoke(this, EventArgs.Empty);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            blank = true;

            #region --Enabling and Disabling Buttons--
            StartButton.Enabled = false;
            StopButton.Enabled = false;
            DrawButton.Enabled = true;
            ClearButton.Enabled = false;
            groupBox1.Enabled = true;
            groupBoxCinematicParameters.Enabled = true;
            animatedButton1.Enabled = true;
            #endregion

            Graphics graphics = pictureBoxMain.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.Dispose();
            Reset?.Invoke(this, EventArgs.Empty);
            OnStopMotionClick?.Invoke(this, EventArgs.Empty);
        }

        public void DrawImage(Parameters parameters)
        {
            param = parameters;
            param.ParallelTransfer(pictureBoxMain.Width / 2, param.SecondBodyBigRadius + 20);
            if (param.FirstBodyPosition.Y > ClientRectangle.Height - 80)
            {
                StopButton_Click(this, EventArgs.Empty);
                StartButton.Enabled = false;
            }
            pictureBoxMain.Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            #region --Enabling and Disabling buttons--
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            groupBox1.Enabled = false;
            groupBoxCinematicParameters.Enabled = false;
            animatedButton1.Enabled = false;

            MechanicsImage.HidePString();
            #endregion

            OnStartMotionClick?.Invoke(this, EventArgs.Empty);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            #region --Enabling and Disabling buttons--
            StopButton.Enabled = false;
            StartButton.Enabled = true;
            groupBox1.Enabled = true;
            groupBoxCinematicParameters.Enabled = true;
            animatedButton1.Enabled = true;
            #endregion

            OnStopMotionClick?.Invoke(this, EventArgs.Empty);

        }
        private void ParameterValueChanged(object sender, EventArgs e)
        {
            ParameterChanged?.Invoke(this, EventArgs.Empty);
            Reset?.Invoke(this, EventArgs.Empty);
            DrawButton_Click(sender, e);
        }
        private void TrajectoryChanged(object sender, EventArgs e)
        {
            TrajectoryParamChanged?.Invoke(this, EventArgs.Empty);
            OnDrawClick?.Invoke(this, EventArgs.Empty);
        }
        public void Run()
        {
            Application.Run(this);
        }

        public void ResetImage()
        {
            MechanicsImage.Reset();
        }
    }
}
