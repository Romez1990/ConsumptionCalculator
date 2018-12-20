namespace ConsumptionCalculator.Form {
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
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.Calculate_Button = new System.Windows.Forms.Button();
			this.VideoCardQuantity_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.S_ATA_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.RAM_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Ventilator_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Response_Label = new System.Windows.Forms.Label();
			this.PowerSupply_LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.PowerSupply_LinkLabel2 = new System.Windows.Forms.LinkLabel();
			this.PowerSupply_LinkLabel3 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.VideoCardQuantity_NumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.S_ATA_NumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RAM_NumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ventilator_NumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// ProcessorManufacturer_ComboBox
			// 
			this.ProcessorManufacturer_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProcessorManufacturer_ComboBox.FormattingEnabled = true;
			this.ProcessorManufacturer_ComboBox.Location = new System.Drawing.Point(145, 42);
			this.ProcessorManufacturer_ComboBox.Name = "ProcessorManufacturer_ComboBox";
			this.ProcessorManufacturer_ComboBox.Size = new System.Drawing.Size(149, 32);
			this.ProcessorManufacturer_ComboBox.TabIndex = 0;
			this.ProcessorManufacturer_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ProcessorManufacturer_ComboBox_SelectedIndexChanged);
			// 
			// Socket_ComboBox
			// 
			this.Socket_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Socket_ComboBox.FormattingEnabled = true;
			this.Socket_ComboBox.Location = new System.Drawing.Point(311, 42);
			this.Socket_ComboBox.Name = "Socket_ComboBox";
			this.Socket_ComboBox.Size = new System.Drawing.Size(157, 32);
			this.Socket_ComboBox.TabIndex = 1;
			this.Socket_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Socket_ComboBox_SelectedIndexChanged);
			// 
			// ProcessorModel_ComboBox
			// 
			this.ProcessorModel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProcessorModel_ComboBox.FormattingEnabled = true;
			this.ProcessorModel_ComboBox.Location = new System.Drawing.Point(488, 42);
			this.ProcessorModel_ComboBox.Name = "ProcessorModel_ComboBox";
			this.ProcessorModel_ComboBox.Size = new System.Drawing.Size(195, 32);
			this.ProcessorModel_ComboBox.TabIndex = 2;
			// 
			// VideoCardManufacturer_ComboBox
			// 
			this.VideoCardManufacturer_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoCardManufacturer_ComboBox.FormattingEnabled = true;
			this.VideoCardManufacturer_ComboBox.Location = new System.Drawing.Point(145, 138);
			this.VideoCardManufacturer_ComboBox.Name = "VideoCardManufacturer_ComboBox";
			this.VideoCardManufacturer_ComboBox.Size = new System.Drawing.Size(149, 32);
			this.VideoCardManufacturer_ComboBox.TabIndex = 3;
			this.VideoCardManufacturer_ComboBox.SelectedIndexChanged += new System.EventHandler(this.VideoCardManufacturer_ComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(142, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Производитель";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Сокет";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(486, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Модель";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(311, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Количество";
			// 
			// VideoCardModel_ComboBox
			// 
			this.VideoCardModel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoCardModel_ComboBox.FormattingEnabled = true;
			this.VideoCardModel_ComboBox.Location = new System.Drawing.Point(488, 138);
			this.VideoCardModel_ComboBox.Name = "VideoCardModel_ComboBox";
			this.VideoCardModel_ComboBox.Size = new System.Drawing.Size(195, 32);
			this.VideoCardModel_ComboBox.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(142, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "Производитель";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(486, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Модель";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 24);
			this.label7.TabIndex = 13;
			this.label7.Text = "Процессор";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 24);
			this.label8.TabIndex = 14;
			this.label8.Text = "Видеокарта";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 238);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 24);
			this.label9.TabIndex = 15;
			this.label9.Text = "Система";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(142, 208);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 24);
			this.label10.TabIndex = 19;
			this.label10.Text = "S-ATA";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(315, 208);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 24);
			this.label11.TabIndex = 20;
			this.label11.Text = "RAM";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 332);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(125, 24);
			this.label13.TabIndex = 22;
			this.label13.Text = "Охлаждение";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(142, 302);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(130, 24);
			this.label14.TabIndex = 23;
			this.label14.Text = "Вентиляторы";
			// 
			// Calculate_Button
			// 
			this.Calculate_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Calculate_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Calculate_Button.Location = new System.Drawing.Point(493, 302);
			this.Calculate_Button.Name = "Calculate_Button";
			this.Calculate_Button.Size = new System.Drawing.Size(196, 57);
			this.Calculate_Button.TabIndex = 24;
			this.Calculate_Button.Text = "Рассчитать";
			this.Calculate_Button.UseVisualStyleBackColor = true;
			this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
			// 
			// VideoCardQuantity_NumericUpDown
			// 
			this.VideoCardQuantity_NumericUpDown.Location = new System.Drawing.Point(311, 139);
			this.VideoCardQuantity_NumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.VideoCardQuantity_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.VideoCardQuantity_NumericUpDown.Name = "VideoCardQuantity_NumericUpDown";
			this.VideoCardQuantity_NumericUpDown.Size = new System.Drawing.Size(157, 29);
			this.VideoCardQuantity_NumericUpDown.TabIndex = 25;
			this.VideoCardQuantity_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// S_ATA_NumericUpDown
			// 
			this.S_ATA_NumericUpDown.Location = new System.Drawing.Point(145, 236);
			this.S_ATA_NumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.S_ATA_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.S_ATA_NumericUpDown.Name = "S_ATA_NumericUpDown";
			this.S_ATA_NumericUpDown.Size = new System.Drawing.Size(149, 29);
			this.S_ATA_NumericUpDown.TabIndex = 26;
			this.S_ATA_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// RAM_NumericUpDown
			// 
			this.RAM_NumericUpDown.Location = new System.Drawing.Point(311, 236);
			this.RAM_NumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.RAM_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.RAM_NumericUpDown.Name = "RAM_NumericUpDown";
			this.RAM_NumericUpDown.Size = new System.Drawing.Size(157, 29);
			this.RAM_NumericUpDown.TabIndex = 27;
			this.RAM_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Ventilator_NumericUpDown
			// 
			this.Ventilator_NumericUpDown.Location = new System.Drawing.Point(145, 330);
			this.Ventilator_NumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.Ventilator_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Ventilator_NumericUpDown.Name = "Ventilator_NumericUpDown";
			this.Ventilator_NumericUpDown.Size = new System.Drawing.Size(149, 29);
			this.Ventilator_NumericUpDown.TabIndex = 28;
			this.Ventilator_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Response_Label
			// 
			this.Response_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Response_Label.Location = new System.Drawing.Point(709, 42);
			this.Response_Label.Name = "Response_Label";
			this.Response_Label.Size = new System.Drawing.Size(397, 100);
			this.Response_Label.TabIndex = 29;
			this.Response_Label.Text = "Общее энергопотребление - 450 Вт.\r\nВ соответствии с этим мы подобрали для Вас бло" +
    "к питания необходимой мощности в нескольких магазинах:";
			// 
			// PowerSupply_LinkLabel1
			// 
			this.PowerSupply_LinkLabel1.AutoSize = true;
			this.PowerSupply_LinkLabel1.Location = new System.Drawing.Point(713, 142);
			this.PowerSupply_LinkLabel1.Name = "PowerSupply_LinkLabel1";
			this.PowerSupply_LinkLabel1.Size = new System.Drawing.Size(102, 24);
			this.PowerSupply_LinkLabel1.TabIndex = 30;
			this.PowerSupply_LinkLabel1.TabStop = true;
			this.PowerSupply_LinkLabel1.Text = "Магазин 1";
			this.PowerSupply_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PowerSupply_LinkLabel_LinkClicked);
			// 
			// PowerSupply_LinkLabel2
			// 
			this.PowerSupply_LinkLabel2.AutoSize = true;
			this.PowerSupply_LinkLabel2.Location = new System.Drawing.Point(713, 173);
			this.PowerSupply_LinkLabel2.Name = "PowerSupply_LinkLabel2";
			this.PowerSupply_LinkLabel2.Size = new System.Drawing.Size(102, 24);
			this.PowerSupply_LinkLabel2.TabIndex = 31;
			this.PowerSupply_LinkLabel2.TabStop = true;
			this.PowerSupply_LinkLabel2.Text = "Магазин 2";
			this.PowerSupply_LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PowerSupply_LinkLabel_LinkClicked);
			// 
			// PowerSupply_LinkLabel3
			// 
			this.PowerSupply_LinkLabel3.AutoSize = true;
			this.PowerSupply_LinkLabel3.Location = new System.Drawing.Point(713, 206);
			this.PowerSupply_LinkLabel3.Name = "PowerSupply_LinkLabel3";
			this.PowerSupply_LinkLabel3.Size = new System.Drawing.Size(102, 24);
			this.PowerSupply_LinkLabel3.TabIndex = 32;
			this.PowerSupply_LinkLabel3.TabStop = true;
			this.PowerSupply_LinkLabel3.Text = "Магазин 3";
			this.PowerSupply_LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PowerSupply_LinkLabel_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 371);
			this.Controls.Add(this.PowerSupply_LinkLabel3);
			this.Controls.Add(this.PowerSupply_LinkLabel2);
			this.Controls.Add(this.PowerSupply_LinkLabel1);
			this.Controls.Add(this.Response_Label);
			this.Controls.Add(this.Ventilator_NumericUpDown);
			this.Controls.Add(this.RAM_NumericUpDown);
			this.Controls.Add(this.S_ATA_NumericUpDown);
			this.Controls.Add(this.VideoCardQuantity_NumericUpDown);
			this.Controls.Add(this.Calculate_Button);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consumption Calculator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.VideoCardQuantity_NumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.S_ATA_NumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RAM_NumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ventilator_NumericUpDown)).EndInit();
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
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button Calculate_Button;
		private System.Windows.Forms.NumericUpDown VideoCardQuantity_NumericUpDown;
		private System.Windows.Forms.NumericUpDown S_ATA_NumericUpDown;
		private System.Windows.Forms.NumericUpDown RAM_NumericUpDown;
		private System.Windows.Forms.NumericUpDown Ventilator_NumericUpDown;
		private System.Windows.Forms.Label Response_Label;
		private System.Windows.Forms.LinkLabel PowerSupply_LinkLabel1;
		private System.Windows.Forms.LinkLabel PowerSupply_LinkLabel2;
		private System.Windows.Forms.LinkLabel PowerSupply_LinkLabel3;
	}
}
