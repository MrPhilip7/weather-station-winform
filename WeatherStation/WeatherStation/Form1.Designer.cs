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
            detail_textBox = new TextBox();
            label2 = new Label();
            sunrise_textBox = new TextBox();
            label3 = new Label();
            pressure_textBox = new TextBox();
            label4 = new Label();
            windspeed_textBox = new TextBox();
            label6 = new Label();
            conditions_textBox = new TextBox();
            label7 = new Label();
            city_textBox = new TextBox();
            data_button = new Button();
            label5 = new Label();
            sunset_textBox = new TextBox();
            picWeather = new PictureBox();
            btnPressurePlus = new Button();
            btnWindPlus = new Button();
            btnPressureMin = new Button();
            btnWindMin = new Button();
            label9 = new Label();
            temp_textBox = new TextBox();
            btnTempPlus = new Button();
            btnTempMin = new Button();
            ((System.ComponentModel.ISupportInitialize)picWeather).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 189);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Detail";
            // 
            // detail_textBox
            // 
            detail_textBox.Location = new Point(647, 186);
            detail_textBox.Name = "detail_textBox";
            detail_textBox.Size = new Size(86, 23);
            detail_textBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 238);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Sunrise";
            // 
            // sunrise_textBox
            // 
            sunrise_textBox.Location = new Point(618, 235);
            sunrise_textBox.Name = "sunrise_textBox";
            sunrise_textBox.Size = new Size(115, 23);
            sunrise_textBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 68);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Pressure";
            // 
            // pressure_textBox
            // 
            pressure_textBox.Location = new Point(647, 65);
            pressure_textBox.Name = "pressure_textBox";
            pressure_textBox.Size = new Size(86, 23);
            pressure_textBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 108);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Wind Speed";
            // 
            // windspeed_textBox
            // 
            windspeed_textBox.Location = new Point(647, 105);
            windspeed_textBox.Name = "windspeed_textBox";
            windspeed_textBox.Size = new Size(86, 23);
            windspeed_textBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 146);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 10;
            label6.Text = "Conditions";
            // 
            // conditions_textBox
            // 
            conditions_textBox.Location = new Point(647, 143);
            conditions_textBox.Name = "conditions_textBox";
            conditions_textBox.Size = new Size(86, 23);
            conditions_textBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 165);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 12;
            label7.Text = "City";
            // 
            // city_textBox
            // 
            city_textBox.Location = new Point(203, 162);
            city_textBox.Name = "city_textBox";
            city_textBox.Size = new Size(120, 23);
            city_textBox.TabIndex = 13;
            // 
            // data_button
            // 
            data_button.BackColor = SystemColors.InactiveBorder;
            data_button.Location = new Point(329, 152);
            data_button.Name = "data_button";
            data_button.Size = new Size(120, 40);
            data_button.TabIndex = 14;
            data_button.Text = "Check weather";
            data_button.UseVisualStyleBackColor = false;
            data_button.Click += data_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 285);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 16;
            label5.Text = "Sunset";
            // 
            // sunset_textBox
            // 
            sunset_textBox.Location = new Point(618, 282);
            sunset_textBox.Name = "sunset_textBox";
            sunset_textBox.Size = new Size(115, 23);
            sunset_textBox.TabIndex = 17;
            // 
            // picWeather
            // 
            picWeather.BackColor = Color.Transparent;
            picWeather.Location = new Point(634, 360);
            picWeather.Name = "picWeather";
            picWeather.Size = new Size(100, 50);
            picWeather.TabIndex = 18;
            picWeather.TabStop = false;
            // 
            // btnPressurePlus
            // 
            btnPressurePlus.BackColor = Color.FromArgb(128, 255, 128);
            btnPressurePlus.Location = new Point(739, 65);
            btnPressurePlus.Name = "btnPressurePlus";
            btnPressurePlus.Size = new Size(23, 24);
            btnPressurePlus.TabIndex = 23;
            btnPressurePlus.Text = "+";
            btnPressurePlus.UseVisualStyleBackColor = false;
            btnPressurePlus.Click += btnPressurePlus_Click;
            // 
            // btnWindPlus
            // 
            btnWindPlus.BackColor = Color.FromArgb(128, 255, 128);
            btnWindPlus.Location = new Point(739, 105);
            btnWindPlus.Name = "btnWindPlus";
            btnWindPlus.Size = new Size(23, 24);
            btnWindPlus.TabIndex = 24;
            btnWindPlus.Text = "+";
            btnWindPlus.UseVisualStyleBackColor = false;
            btnWindPlus.Click += btnWindPlus_Click;
            // 
            // btnPressureMin
            // 
            btnPressureMin.BackColor = Color.FromArgb(255, 128, 128);
            btnPressureMin.Location = new Point(618, 65);
            btnPressureMin.Name = "btnPressureMin";
            btnPressureMin.Size = new Size(23, 24);
            btnPressureMin.TabIndex = 25;
            btnPressureMin.Text = "-";
            btnPressureMin.UseVisualStyleBackColor = false;
            btnPressureMin.Click += btnPressureMin_Click;
            // 
            // btnWindMin
            // 
            btnWindMin.BackColor = Color.FromArgb(255, 128, 128);
            btnWindMin.Location = new Point(618, 105);
            btnWindMin.Name = "btnWindMin";
            btnWindMin.Size = new Size(23, 24);
            btnWindMin.TabIndex = 26;
            btnWindMin.Text = "-";
            btnWindMin.UseVisualStyleBackColor = false;
            btnWindMin.Click += btnWindMin_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 28);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 27;
            label9.Text = "Temp(rand) °C";
            // 
            // temp_textBox
            // 
            temp_textBox.Location = new Point(647, 25);
            temp_textBox.Name = "temp_textBox";
            temp_textBox.Size = new Size(86, 23);
            temp_textBox.TabIndex = 28;
            temp_textBox.TextChanged += temp_textBox_TextChanged;
            // 
            // btnTempPlus
            // 
            btnTempPlus.BackColor = Color.FromArgb(128, 255, 128);
            btnTempPlus.Location = new Point(739, 24);
            btnTempPlus.Name = "btnTempPlus";
            btnTempPlus.Size = new Size(23, 24);
            btnTempPlus.TabIndex = 29;
            btnTempPlus.Text = "+";
            btnTempPlus.UseVisualStyleBackColor = false;
            btnTempPlus.Click += btnTempPlus_Click;
            // 
            // btnTempMin
            // 
            btnTempMin.BackColor = Color.FromArgb(255, 128, 128);
            btnTempMin.Location = new Point(618, 23);
            btnTempMin.Name = "btnTempMin";
            btnTempMin.Size = new Size(23, 24);
            btnTempMin.TabIndex = 30;
            btnTempMin.Text = "-";
            btnTempMin.UseVisualStyleBackColor = false;
            btnTempMin.Click += btnTempMin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.pexels_eberhard_grossgasteiger_844297;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTempMin);
            Controls.Add(btnTempPlus);
            Controls.Add(temp_textBox);
            Controls.Add(label9);
            Controls.Add(btnWindMin);
            Controls.Add(btnPressureMin);
            Controls.Add(btnWindPlus);
            Controls.Add(btnPressurePlus);
            Controls.Add(picWeather);
            Controls.Add(sunset_textBox);
            Controls.Add(label5);
            Controls.Add(data_button);
            Controls.Add(city_textBox);
            Controls.Add(label7);
            Controls.Add(conditions_textBox);
            Controls.Add(label6);
            Controls.Add(windspeed_textBox);
            Controls.Add(label4);
            Controls.Add(pressure_textBox);
            Controls.Add(label3);
            Controls.Add(sunrise_textBox);
            Controls.Add(label2);
            Controls.Add(detail_textBox);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picWeather).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox detail_textBox;
        private Label label2;
        private TextBox sunrise_textBox;
        private Label label3;
        private TextBox pressure_textBox;
        private Label label4;
        private TextBox windspeed_textBox;
        private Label label6;
        private TextBox conditions_textBox;
        private Label label7;
        private TextBox city_textBox;
        private Button data_button;
        private Label label5;
        private TextBox sunset_textBox;
        private PictureBox picWeather;
        private Button btnPressurePlus;
        private Button btnWindPlus;
        private Button btnPressureMin;
        private Button btnWindMin;
        private Label label9;
        private TextBox temp_textBox;
        private Button btnTempPlus;
        private Button btnTempMin;
    }
}