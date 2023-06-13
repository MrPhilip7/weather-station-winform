namespace WeatherStation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            temperature_textBox = new TextBox();
            label2 = new Label();
            humidity_textBox = new TextBox();
            label3 = new Label();
            pressure_textBox = new TextBox();
            label4 = new Label();
            windspeed_textBox = new TextBox();
            label5 = new Label();
            winddirection_textBox = new TextBox();
            label6 = new Label();
            cloudiness_textBox = new TextBox();
            label7 = new Label();
            city_textBox = new TextBox();
            data_button = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperature";
            // 
            // temperature_textBox
            // 
            temperature_textBox.Location = new Point(675, 39);
            temperature_textBox.Name = "temperature_textBox";
            temperature_textBox.Size = new Size(86, 23);
            temperature_textBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Humidity";
            // 
            // humidity_textBox
            // 
            humidity_textBox.Location = new Point(675, 88);
            humidity_textBox.Name = "humidity_textBox";
            humidity_textBox.Size = new Size(86, 23);
            humidity_textBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 139);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Pressure";
            // 
            // pressure_textBox
            // 
            pressure_textBox.Location = new Point(675, 136);
            pressure_textBox.Name = "pressure_textBox";
            pressure_textBox.Size = new Size(86, 23);
            pressure_textBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 185);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Wind Speed";
            // 
            // windspeed_textBox
            // 
            windspeed_textBox.Location = new Point(675, 182);
            windspeed_textBox.Name = "windspeed_textBox";
            windspeed_textBox.Size = new Size(86, 23);
            windspeed_textBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(582, 231);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Wind Direction";
            // 
            // winddirection_textBox
            // 
            winddirection_textBox.Location = new Point(674, 228);
            winddirection_textBox.Name = "winddirection_textBox";
            winddirection_textBox.Size = new Size(86, 23);
            winddirection_textBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 278);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 10;
            label6.Text = "Cloudiness";
            // 
            // cloudiness_textBox
            // 
            cloudiness_textBox.Location = new Point(674, 275);
            cloudiness_textBox.Name = "cloudiness_textBox";
            cloudiness_textBox.Size = new Size(86, 23);
            cloudiness_textBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 144);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 12;
            label7.Text = "City";
            // 
            // city_textBox
            // 
            city_textBox.Location = new Point(292, 162);
            city_textBox.Name = "city_textBox";
            city_textBox.Size = new Size(120, 23);
            city_textBox.TabIndex = 13;
            // 
            // data_button
            // 
            data_button.Location = new Point(292, 191);
            data_button.Name = "data_button";
            data_button.Size = new Size(120, 35);
            data_button.TabIndex = 14;
            data_button.Text = "Check weather";
            data_button.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(135, 28);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 15;
            label8.Text = "WEATHER STATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(data_button);
            Controls.Add(city_textBox);
            Controls.Add(label7);
            Controls.Add(cloudiness_textBox);
            Controls.Add(label6);
            Controls.Add(winddirection_textBox);
            Controls.Add(label5);
            Controls.Add(windspeed_textBox);
            Controls.Add(label4);
            Controls.Add(pressure_textBox);
            Controls.Add(label3);
            Controls.Add(humidity_textBox);
            Controls.Add(label2);
            Controls.Add(temperature_textBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox temperature_textBox;
        private Label label2;
        private TextBox humidity_textBox;
        private Label label3;
        private TextBox pressure_textBox;
        private Label label4;
        private TextBox windspeed_textBox;
        private Label label5;
        private TextBox winddirection_textBox;
        private Label label6;
        private TextBox cloudiness_textBox;
        private Label label7;
        private TextBox city_textBox;
        private Button data_button;
        private Label label8;
    }
}