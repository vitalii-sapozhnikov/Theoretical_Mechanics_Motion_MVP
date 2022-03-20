using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theoretical_Mechanics_Motion_MVP
{
    public partial class AnimatedButton : Button
    {
        private bool MouseEntered = false;
        private bool MouseClicked = false;
        private bool firstInitImg = true;
        private Image bgImage;
        private bool invisible = false;

        Animation CurtainButtonAnim = new Animation();
        Animation RippleButtonAnim = new Animation();

        Point ClickLockation = new Point();
        public AnimatedButton()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (firstInitImg)
            {
                bgImage = this.Image;
                firstInitImg = false;
            }

            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


            // Шторка
            if (Enabled)
            {
                if (invisible)
                {
                    this.Image = bgImage;
                    invisible = false;
                }

                Rectangle rectCurtain = new Rectangle(0, 0, (int)CurtainButtonAnim.Value, Height - 1);
                graphics.DrawRectangle(new Pen(Color.FromArgb(40, Color.White)), rectCurtain);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(40, Color.White)), rectCurtain);
            }
            else
            {
                if (!invisible)
                {
                    BackColor = Parent.BackColor;
                    BackgroundImage = null;
                    this.Image = SetImageOpacity(bgImage, 0.7f);
                    invisible = true;
                }
            }

            // Ripple Effect
            if(RippleButtonAnim.Value > 0 && RippleButtonAnim.Value < RippleButtonAnim.TargetValue)
            {
                Rectangle rectRipple = new Rectangle(
                    ClickLockation.X - (int)RippleButtonAnim.Value / 2,
                    ClickLockation.Y - (int)RippleButtonAnim.Value / 2,
                    (int)RippleButtonAnim.Value,
                    (int)RippleButtonAnim.Value
                    );
                graphics.DrawEllipse(new Pen(Color.FromArgb(30, Color.Black)), rectRipple);
                graphics.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.Black)), rectRipple);
            }
            else if (RippleButtonAnim.Value == RippleButtonAnim.TargetValue)
                RippleButtonAnim.Value = 0;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            ButtonCurtainAction();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            ButtonCurtainAction();
        }
        private void ButtonCurtainAction()
        {
            if (MouseEntered)
            {
                CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, Width - 1);
            }
            else
            {
                CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, 0);
            }
            CurtainButtonAnim.StepDivider = 8;
            Animator.Request(CurtainButtonAnim, true);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            MouseClicked = true;
            CurtainButtonAnim.Value = CurtainButtonAnim.TargetValue;
            ClickLockation = mevent.Location;
            ButtonRippleAction();
        }


        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            MouseClicked = false;
        }
        private void ButtonRippleAction()
        {
            RippleButtonAnim = new Animation("ButtonRipple_" + Handle, Invalidate, 0, Width);
            Animator.Request(RippleButtonAnim);
        }
        private Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity
                };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
    }
}
