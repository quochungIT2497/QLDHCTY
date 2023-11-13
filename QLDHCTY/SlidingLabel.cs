using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace QLDHCTY
{
    public class SlidingLabel : Control // con của class control
    {
        private Timer timer = new Timer();
        private bool slide;
        private int position;
        private bool art = false;

        public SlidingLabel()
        {
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint, true); //Đặt style
            this.AutoSize = false;
            base.Width = 60;
            base.Height = 30;
            this.position = 0;
            this.timer.Tick += new EventHandler(this.timer_Tick);
            this.slide = false;
            this.timer.Enabled = false;
        }

        protected override void Dispose(bool disposing)
        {
            this.timer.Stop();
            base.Dispose(disposing);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnBackColorChanged(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnForeColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush;
            using (brush = (Brush)new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(brush, base.ClientRectangle);
            }
            Size size = TextRenderer.MeasureText(this.Text, this.Font);
            int num = (base.Height / 2) - (size.Height / 2);
            //using (StringFormat sf = new StringFormat())
            //{
                using (brush = (Brush)new SolidBrush(this.ForeColor))
                {
                   //sf.Alignment = StringAlignment.Center;
                   //sf.LineAlignment = StringAlignment.Center;
                   e.Graphics.DrawString(this.Text, this.Font, brush, (float)this.position, (float)num);
                }
            //}
            base.OnPaint(e);
        }
        /*
        private ContentAlignment _TextAlign = ContentAlignment.MiddleCenter;

        [Description("The alignment of the text that will be displayed on the control.")]
        [DefaultValue(typeof(ContentAlignment), "MiddleCenter")]
        public ContentAlignment TextAlign
        {
            get { return _TextAlign; }
            set { _TextAlign = value; }
        }*/

        protected override void OnResize(EventArgs e)
        {
            this.timer.Enabled = true;
            base.OnResize(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(this.Text, this.Font);
            if (size.Width >= base.Width)
            {
                this.timer.Stop();
                this.position = 1;
                base.Invalidate();
            }
            else
            {
                int num = (size.Width >= base.Width) ? (size.Width - base.Width) : 0;
                if (this.position >= 1)
                {
                    this.art = false;
                }
                if (-this.position >= (num + this.Font.Height))
                {
                    this.art = true;
                }
                this.position = this.art ? (this.position + 1) : (this.position - 1);
                base.Invalidate();
            }
        }

        public int SlideTime
        {
            get => this.timer.Interval;
            set
            {
                this.timer.Interval = value;
                base.Invalidate();
            }
        }

        public bool Slide
        {
            get => this.slide;
            set
            {
                this.slide = true;
                this.timer.Enabled = this.slide;
                if (!this.slide)
                {
                    this.position = 0;
                    base.Invalidate();
                }
            }
        }

        public override string Text 
        { 
            get => base.Text;
            set
            {
                base.Text = value;
                this.timer.Start();
            }
        }
    }

}
