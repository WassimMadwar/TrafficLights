using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLights.Properties;

namespace TrafficLights
{
    public partial class ctrTrafficLights : UserControl
    {
        //storage 

        public class EventTrafficLight : EventArgs
        {
            public LightEnum CurrentLight { get; }
            public int LightDuration { get; }

            public EventTrafficLight(LightEnum CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }
        }
        public enum LightEnum { Red = 0, Orange = 1, Green = 2 }
        private LightEnum CurrentLight_ = LightEnum.Red;
        //storage 

        public LightEnum CurrentLight
        {
            get
            {
                return CurrentLight_;
            }

            set
            {
                CurrentLight_ = value;

                switch (CurrentLight_)
                {
                    case LightEnum.Red:
                        pbLight.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;

                    case LightEnum.Orange:
                        pbLight.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        break;

                    case LightEnum.Green:
                        pbLight.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        break;

                    default:
                        lblCountDown.ForeColor = Color.Red;
                        break;
                }

            }

        }


        public LightEnum SwitchLight_;
        private int RedTime_ = 10;
        private int OrangeTime_ = 3;
        private int GreenTime_ = 10;
        private int CurrentTimeValue_;


        //
        public int GetCurrentTime()
        {

            switch (CurrentLight_)
            {
                case LightEnum.Orange:
                    return OrangeTime;

                case LightEnum.Green:
                    return GreenTime;

                case LightEnum.Red:
                    return RedTime;

                default:
                    return RedTime;
            }

        }

        public int RedTime
        {
            get
            {
                return RedTime_;
            }
            set
            {
                RedTime_ = value;

            }
        }

        public int OrangeTime
        {
            get
            {
                return OrangeTime_;
            }
            set
            {
                OrangeTime_ = value;
            }
        }

        public int GreenTime
        {
            get
            {
                return GreenTime_;
            }
            set
            {
                GreenTime_ = value;
            }
        }
        //


       

        public ctrTrafficLights()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////

        public event EventHandler<EventTrafficLight> Red_On;
       
        public void RaiseRedLightOn()
        {
            RaiseRed(new EventTrafficLight(LightEnum.Red, RedTime));
        }

        protected virtual void RaiseRed(EventTrafficLight MyE)
        {
            Red_On?.Invoke(this, MyE);
        }

        ////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////

        public event EventHandler<EventTrafficLight> Orang_On;

        public void RaiseOrangLightOn()
        {
            RaiseOrang(new EventTrafficLight(LightEnum.Red, RedTime));
        }

        protected virtual void RaiseOrang(EventTrafficLight MyE)
        {
            Orang_On?.Invoke(this, MyE);
        }

        ////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////

        public event EventHandler<EventTrafficLight> Green_On;

        public void RaiseGreenLightOn()
        {
            RaiseGreen(new EventTrafficLight(LightEnum.Red, RedTime));
        }

        protected virtual void RaiseGreen(EventTrafficLight MyE)
        {
            Green_On?.Invoke(this, MyE);
        }

        ////////////////////////////////////////////////////////////////////
      
        public void StartTimer()
        {
            CurrentTimeValue_ = GetCurrentTime();
            LightTimer.Start();

        }

        public void StopTimer()
        {
            LightTimer.Stop();

        }

        private void ChangeLight_()
        {
            switch (CurrentLight_)
            {
                case LightEnum.Red:
                    SwitchLight_ = LightEnum.Green;
                    CurrentLight = LightEnum.Orange;
                    CurrentTimeValue_ = OrangeTime;
                    lblCountDown.Text = CurrentTimeValue_.ToString();

                    RaiseOrangLightOn();

                    break;

                case LightEnum.Orange:
                    if (SwitchLight_ == LightEnum.Green)
                    {
                        CurrentLight = LightEnum.Green;
                        CurrentTimeValue_ = GreenTime;
                        lblCountDown.Text = CurrentTimeValue_.ToString();

                        RaiseGreenLightOn();

                    }
                    else
                    {
                        CurrentLight = LightEnum.Red;
                        CurrentTimeValue_ = RedTime;
                        lblCountDown.Text = CurrentTimeValue_.ToString();
                        RaiseRedLightOn();

                    }

                    break;

                case LightEnum.Green:
                    SwitchLight_ = LightEnum.Red;
                    CurrentLight = LightEnum.Orange;
                    CurrentTimeValue_ = OrangeTime;
                    lblCountDown.Text = CurrentTimeValue_.ToString();
                    RaiseOrangLightOn();

                    break;

                default:
                    pbLight.Image = Resources.Red;
                    break;
            }


        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            lblCountDown.Text = CurrentTimeValue_.ToString();
            if (CurrentTimeValue_ == 0) 
            {
                ChangeLight_();
            }
            else
            {
                --CurrentTimeValue_;
            }
        }


    }
}
