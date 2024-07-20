namespace TrafficLights
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.ctrTrafficLights1 = new TrafficLights.ctrTrafficLights();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(13, 243);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(131, 243);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // ctrTrafficLights1
            // 
            this.ctrTrafficLights1.CurrentLight = TrafficLights.ctrTrafficLights.LightEnum.Red;
            this.ctrTrafficLights1.GreenTime = 7;
            this.ctrTrafficLights1.Location = new System.Drawing.Point(84, 12);
            this.ctrTrafficLights1.Name = "ctrTrafficLights1";
            this.ctrTrafficLights1.OrangeTime = 3;
            this.ctrTrafficLights1.RedTime = 7;
            this.ctrTrafficLights1.Size = new System.Drawing.Size(57, 200);
            this.ctrTrafficLights1.TabIndex = 0;
            this.ctrTrafficLights1.Orang_On += new System.EventHandler<TrafficLights.ctrTrafficLights.EventTrafficLight>(this.OrangMessage);
            this.ctrTrafficLights1.Green_On += new System.EventHandler<TrafficLights.ctrTrafficLights.EventTrafficLight>(this.ctrTrafficLights1_Green_On);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 279);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.ctrTrafficLights1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Traffic Lights";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrTrafficLights ctrTrafficLights1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
    }
}

