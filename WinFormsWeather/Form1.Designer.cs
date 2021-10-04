
namespace WinFormsWeather {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.labelCity = new System.Windows.Forms.Label();
			this.labelHumidity = new System.Windows.Forms.Label();
			this.labelTemperature = new System.Windows.Forms.Label();
			this.labelWeather = new System.Windows.Forms.Label();
			this.labelWind = new System.Windows.Forms.Label();
			this.labelLocalTime = new System.Windows.Forms.Label();
			this.comboBoxCities = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(62, 53);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(28, 15);
			this.labelCity.TabIndex = 0;
			this.labelCity.Text = "City";
			// 
			// labelHumidity
			// 
			this.labelHumidity.AutoSize = true;
			this.labelHumidity.Location = new System.Drawing.Point(29, 83);
			this.labelHumidity.Name = "labelHumidity";
			this.labelHumidity.Size = new System.Drawing.Size(57, 15);
			this.labelHumidity.TabIndex = 1;
			this.labelHumidity.Text = "Humidity";
			// 
			// labelTemperature
			// 
			this.labelTemperature.AutoSize = true;
			this.labelTemperature.Location = new System.Drawing.Point(29, 113);
			this.labelTemperature.Name = "labelTemperature";
			this.labelTemperature.Size = new System.Drawing.Size(73, 15);
			this.labelTemperature.TabIndex = 2;
			this.labelTemperature.Text = "Temperature";
			// 
			// labelWeather
			// 
			this.labelWeather.AutoSize = true;
			this.labelWeather.Location = new System.Drawing.Point(29, 146);
			this.labelWeather.Name = "labelWeather";
			this.labelWeather.Size = new System.Drawing.Size(51, 15);
			this.labelWeather.TabIndex = 3;
			this.labelWeather.Text = "Weather";
			// 
			// labelWind
			// 
			this.labelWind.AutoSize = true;
			this.labelWind.Location = new System.Drawing.Point(29, 179);
			this.labelWind.Name = "labelWind";
			this.labelWind.Size = new System.Drawing.Size(35, 15);
			this.labelWind.TabIndex = 4;
			this.labelWind.Text = "Wind";
			// 
			// labelLocalTime
			// 
			this.labelLocalTime.AutoSize = true;
			this.labelLocalTime.Location = new System.Drawing.Point(29, 211);
			this.labelLocalTime.Name = "labelLocalTime";
			this.labelLocalTime.Size = new System.Drawing.Size(62, 15);
			this.labelLocalTime.TabIndex = 5;
			this.labelLocalTime.Text = "Local time";
			// 
			// comboBoxCities
			// 
			this.comboBoxCities.FormattingEnabled = true;
			this.comboBoxCities.Items.AddRange(new object[] {
            "Ostrava",
            "Bruntal",
            "Stockholm",
            "Athens",
            "London"});
			this.comboBoxCities.Location = new System.Drawing.Point(13, 13);
			this.comboBoxCities.Name = "comboBoxCities";
			this.comboBoxCities.Size = new System.Drawing.Size(121, 23);
			this.comboBoxCities.TabIndex = 6;
			this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(190, 266);
			this.Controls.Add(this.comboBoxCities);
			this.Controls.Add(this.labelLocalTime);
			this.Controls.Add(this.labelWind);
			this.Controls.Add(this.labelWeather);
			this.Controls.Add(this.labelTemperature);
			this.Controls.Add(this.labelHumidity);
			this.Controls.Add(this.labelCity);
			this.Name = "Form1";
			this.Text = "Počasí";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelHumidity;
		private System.Windows.Forms.Label labelTemperature;
		private System.Windows.Forms.Label labelWeather;
		private System.Windows.Forms.Label labelWind;
		private System.Windows.Forms.Label labelLocalTime;
		private System.Windows.Forms.ComboBox comboBoxCities;
	}
}

