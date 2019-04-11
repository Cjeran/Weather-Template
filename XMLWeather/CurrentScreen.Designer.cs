namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.currentPic = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.windDirection = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.precipitation = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 50);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(158, 0);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(158, 50);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentTemp
            // 
            this.currentTemp.BackColor = System.Drawing.Color.Transparent;
            this.currentTemp.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentTemp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.currentTemp.Location = new System.Drawing.Point(62, 272);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(183, 68);
            this.currentTemp.TabIndex = 43;
            this.currentTemp.Text = "23°C";
            this.currentTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentPic
            // 
            this.currentPic.BackColor = System.Drawing.Color.Transparent;
            this.currentPic.Image = global::XMLWeather.Properties.Resources.clear1;
            this.currentPic.Location = new System.Drawing.Point(74, 98);
            this.currentPic.Name = "currentPic";
            this.currentPic.Size = new System.Drawing.Size(223, 171);
            this.currentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentPic.TabIndex = 44;
            this.currentPic.TabStop = false;
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.location.Location = new System.Drawing.Point(55, 60);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(190, 35);
            this.location.TabIndex = 45;
            this.location.Text = "Stratford";
            this.location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(18, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Min Temp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(18, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Max Temp.";
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.Cyan;
            this.min.Location = new System.Drawing.Point(8, 456);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(76, 29);
            this.min.TabIndex = 48;
            this.min.Text = "17°C";
            this.min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.ForeColor = System.Drawing.Color.Firebrick;
            this.max.Location = new System.Drawing.Point(8, 398);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(76, 29);
            this.max.TabIndex = 49;
            this.max.Text = "25°C";
            this.max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Windspeed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Wind Direction";
            // 
            // windspeed
            // 
            this.windspeed.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.ForeColor = System.Drawing.Color.White;
            this.windspeed.Location = new System.Drawing.Point(214, 394);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(102, 37);
            this.windspeed.TabIndex = 52;
            this.windspeed.Text = "27 mps";
            this.windspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirection
            // 
            this.windDirection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDirection.ForeColor = System.Drawing.Color.White;
            this.windDirection.Location = new System.Drawing.Point(219, 456);
            this.windDirection.Name = "windDirection";
            this.windDirection.Size = new System.Drawing.Size(96, 29);
            this.windDirection.TabIndex = 53;
            this.windDirection.Text = "NNW";
            this.windDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Precipitation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Humidity";
            // 
            // precipitation
            // 
            this.precipitation.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitation.ForeColor = System.Drawing.Color.White;
            this.precipitation.Location = new System.Drawing.Point(106, 394);
            this.precipitation.Name = "precipitation";
            this.precipitation.Size = new System.Drawing.Size(102, 37);
            this.precipitation.TabIndex = 56;
            this.precipitation.Text = "22mm";
            this.precipitation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidity
            // 
            this.humidity.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.ForeColor = System.Drawing.Color.White;
            this.humidity.Location = new System.Drawing.Point(106, 452);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(102, 37);
            this.humidity.TabIndex = 57;
            this.humidity.Text = "36%";
            this.humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.Control;
            this.date.Location = new System.Drawing.Point(16, 341);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(149, 29);
            this.date.TabIndex = 58;
            this.date.Text = "07-04-2019";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.Control;
            this.time.Location = new System.Drawing.Point(167, 341);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(149, 29);
            this.time.TabIndex = 59;
            this.time.Text = "07-04-2019";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.precipitation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.windDirection);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.location);
            this.Controls.Add(this.currentPic);
            this.Controls.Add(this.currentTemp);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(315, 500);
            ((System.ComponentModel.ISupportInitialize)(this.currentPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.PictureBox currentPic;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label windDirection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label precipitation;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
    }
}
