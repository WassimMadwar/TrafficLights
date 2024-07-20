using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            ctrTrafficLights1.StartTimer();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            ctrTrafficLights1.StopTimer();   
        }

        private void ctrTrafficLights1_Green_On(object sender, ctrTrafficLights.EventTrafficLight e)
        {
            MessageBox.Show("Goooooooo");
        }

        private void OrangMessage(object MySender, ctrTrafficLights.EventTrafficLight Mye)
        {
            if (ctrTrafficLights1.SwitchLight_ != ctrTrafficLights.LightEnum.Red)
            {
                MessageBox.Show("Redayyyyyyyyyyyyyyyyyyyy");
            }
            else
            {
                MessageBox.Show("slow down"); 
            }


        }


    }
}
