namespace ConsumptionCalculator.Forms {
	partial class MainForm {
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent() {
			this.ProcessorManufacturer_ComboBox = new System.Windows.Forms.ComboBox();
			this.Socket_ComboBox = new System.Windows.Forms.ComboBox();
			this.ProcessorModel_ComboBox = new System.Windows.Forms.ComboBox();
			this.VideoCardManufacturer_ComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.VideoCardModel_ComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.Calculate_Button = new System.Windows.Forms.Button();
			this.VideoCardQuantity_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.VideoCardQuantity_NumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// ProcessorManufacturer_ComboBox
			// 
			this.ProcessorManufacturer_ComboBox.FormattingEnabled = true;
			this.ProcessorManufacturer_ComboBox.Location = new System.Drawing.Point(145, 93);
			this.ProcessorManufacturer_ComboBox.Name = "ProcessorManufacturer_ComboBox";
			this.ProcessorManufacturer_ComboBox.Size = new System.Drawing.Size(121, 32);
			this.ProcessorManufacturer_ComboBox.TabIndex = 0;
			this.ProcessorManufacturer_ComboBox.Text = "Выбрать";
			this.ProcessorManufacturer_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ProcessorManufacturer_ComboBox_SelectedIndexChanged);
			// 
			// Socket_ComboBox
			// 
			this.Socket_ComboBox.FormattingEnabled = true;
			this.Socket_ComboBox.Location = new System.Drawing.Point(290, 93);
			this.Socket_ComboBox.Name = "Socket_ComboBox";
			this.Socket_ComboBox.Size = new System.Drawing.Size(121, 32);
			this.Socket_ComboBox.TabIndex = 1;
			this.Socket_ComboBox.Text = "Выбрать";
			this.Socket_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Socket_ComboBox_SelectedIndexChanged);
			// 
			// ProcessorModel_ComboBox
			// 
			this.ProcessorModel_ComboBox.FormattingEnabled = true;
			this.ProcessorModel_ComboBox.Location = new System.Drawing.Point(433, 93);
			this.ProcessorModel_ComboBox.Name = "ProcessorModel_ComboBox";
			this.ProcessorModel_ComboBox.Size = new System.Drawing.Size(121, 32);
			this.ProcessorModel_ComboBox.TabIndex = 2;
			this.ProcessorModel_ComboBox.Text = "Выбрать";
			// 
			// VideoCardManufacturer_ComboBox
			// 
			this.VideoCardManufacturer_ComboBox.FormattingEnabled = true;
			this.VideoCardManufacturer_ComboBox.Location = new System.Drawing.Point(145, 189);
			this.VideoCardManufacturer_ComboBox.Name = "VideoCardManufacturer_ComboBox";
			this.VideoCardManufacturer_ComboBox.Size = new System.Drawing.Size(121, 32);
			this.VideoCardManufacturer_ComboBox.TabIndex = 3;
			this.VideoCardManufacturer_ComboBox.Text = "Выбрать";
			this.VideoCardManufacturer_ComboBox.SelectedIndexChanged += new System.EventHandler(this.VideoCardManufacturer_ComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(141, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Производитель";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(294, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Сокет";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(429, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Модель";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(294, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Количество";
			// 
			// VideoCardModel_ComboBox
			// 
			this.VideoCardModel_ComboBox.FormattingEnabled = true;
			this.VideoCardModel_ComboBox.Location = new System.Drawing.Point(433, 189);
			this.VideoCardModel_ComboBox.Name = "VideoCardModel_ComboBox";
			this.VideoCardModel_ComboBox.Size = new System.Drawing.Size(121, 32);
			this.VideoCardModel_ComboBox.TabIndex = 10;
			this.VideoCardModel_ComboBox.Text = "Выбрать";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(141, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "Производитель";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(429, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Модель";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 24);
			this.label7.TabIndex = 13;
			this.label7.Text = "Процессор";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 24);
			this.label8.TabIndex = 14;
			this.label8.Text = "Видеокарта";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 289);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 24);
			this.label9.TabIndex = 15;
			this.label9.Text = "Система";
			// 
			// comboBox7
			// 
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(145, 286);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(121, 32);
			this.comboBox7.TabIndex = 16;
			this.comboBox7.Text = "0х";
			// 
			// comboBox8
			// 
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(290, 286);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(121, 32);
			this.comboBox8.TabIndex = 17;
			this.comboBox8.Text = "0х";
			// 
			// comboBox9
			// 
			this.comboBox9.FormattingEnabled = true;
			this.comboBox9.Location = new System.Drawing.Point(145, 380);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(121, 32);
			this.comboBox9.TabIndex = 18;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(141, 259);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 24);
			this.label10.TabIndex = 19;
			this.label10.Text = "S-ATA";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(294, 259);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 24);
			this.label11.TabIndex = 20;
			this.label11.Text = "RAM";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 383);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(125, 24);
			this.label13.TabIndex = 22;
			this.label13.Text = "Охлаждение";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(141, 353);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(130, 24);
			this.label14.TabIndex = 23;
			this.label14.Text = "Вентиляторы";
			// 
			// Calculate_Button
			// 
			this.Calculate_Button.Location = new System.Drawing.Point(629, 400);
			this.Calculate_Button.Name = "Calculate_Button";
			this.Calculate_Button.Size = new System.Drawing.Size(196, 57);
			this.Calculate_Button.TabIndex = 24;
			this.Calculate_Button.Text = "Рассчитать";
			this.Calculate_Button.UseVisualStyleBackColor = true;
			this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
			// 
			// VideoCardQuantity_NumericUpDown
			// 
			this.VideoCardQuantity_NumericUpDown.Location = new System.Drawing.Point(290, 190);
			this.VideoCardQuantity_NumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.VideoCardQuantity_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.VideoCardQuantity_NumericUpDown.Name = "VideoCardQuantity_NumericUpDown";
			this.VideoCardQuantity_NumericUpDown.Size = new System.Drawing.Size(121, 29);
			this.VideoCardQuantity_NumericUpDown.TabIndex = 25;
			this.VideoCardQuantity_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 479);
			this.Controls.Add(this.VideoCardQuantity_NumericUpDown);
			this.Controls.Add(this.Calculate_Button);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBox9);
			this.Controls.Add(this.comboBox8);
			this.Controls.Add(this.comboBox7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.VideoCardModel_ComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VideoCardManufacturer_ComboBox);
			this.Controls.Add(this.ProcessorModel_ComboBox);
			this.Controls.Add(this.Socket_ComboBox);
			this.Controls.Add(this.ProcessorManufacturer_ComboBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.VideoCardQuantity_NumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ComboBox ProcessorManufacturer_ComboBox;
		private System.Windows.Forms.ComboBox Socket_ComboBox;
		private System.Windows.Forms.ComboBox ProcessorModel_ComboBox;
		private System.Windows.Forms.ComboBox VideoCardManufacturer_ComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox VideoCardModel_ComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button Calculate_Button;
		private System.Windows.Forms.NumericUpDown VideoCardQuantity_NumericUpDown;
	}
}
