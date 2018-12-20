using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ConsumptionCalculator.Form {
	public partial class MainForm : System.Windows.Forms.Form {

		public MainForm() {
			InitializeComponent();
			Response_Label.Text = string.Empty;
			PowerSupply_LinkLabel1.Text = string.Empty;
			PowerSupply_LinkLabel2.Text = string.Empty;
			PowerSupply_LinkLabel3.Text = string.Empty;
		}

		#region Read database

		private void MainForm_Load(object sender, EventArgs e) {
			if (!ReadDatabase("Database.xlsx")) {
				Application.Exit();
				return;
			}

			ReadProcessors();
			SetProcessorManufacturers();

			ReadVideoCards();
			SetVideoCardManufacturers();

			ReadPowerSupplies();
			}

		private ExcelPackage ExcelPackage;

		private bool ReadDatabase(string DatabaseText) {
			FileInfo FileInfo = new FileInfo(DatabaseText);
			if (FileInfo.Exists) {
				ExcelPackage = new ExcelPackage(FileInfo);
				return true;
			}

			MessageBox.Show("Файл Database.xlsx не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		#endregion

		#region Processors

		private readonly List<Processor> Processors = new List<Processor>();

		private void ReadProcessors() {
			ExcelWorksheet Worksheet = ExcelPackage.Workbook.Worksheets[1];
			for (int i = 2; i < Worksheet.Cells.Rows; ++i) {
				if (Worksheet.Cells[i, 1].Value == null)
					break;

				Processors.Add(new Processor(
					Worksheet.Cells[i, 1].Value?.ToString(),
					Worksheet.Cells[i, 2].Value?.ToString(),
					Worksheet.Cells[i, 3].Value?.ToString(),
					int.Parse(Worksheet.Cells[i, 4].Value?.ToString())
				));
			}
		}

		private void SetProcessorManufacturers() {
			foreach (Processor Processor in Processors)
				if (!ProcessorManufacturer_ComboBox.Items.Contains(Processor.Manufacturer))
					ProcessorManufacturer_ComboBox.Items.Add(Processor.Manufacturer);
		}

		private void ProcessorManufacturer_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ProcessorModel_ComboBox.SelectedIndex = -1;
			ProcessorModel_ComboBox.Items.Clear();
			Socket_ComboBox.SelectedIndex = -1;
			Socket_ComboBox.Items.Clear();
			foreach (Processor Processor in Processors)
				if (ProcessorManufacturer_ComboBox.Text == Processor.Manufacturer)
					if (!Socket_ComboBox.Items.Contains(Processor.Socket))
						Socket_ComboBox.Items.Add(Processor.Socket);
		}

		private void Socket_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ProcessorModel_ComboBox.SelectedIndex = -1;
			ProcessorModel_ComboBox.Items.Clear();
			foreach (Processor Processor in Processors)
				if (Socket_ComboBox.Text == Processor.Socket)
					if (!ProcessorModel_ComboBox.Items.Contains(Processor.Model))
						ProcessorModel_ComboBox.Items.Add(Processor.Model);
		}

		#endregion

		#region Video cards

		private readonly List<VideoCard> VideoCards = new List<VideoCard>();

		private void ReadVideoCards() {
			ExcelWorksheet Worksheet = ExcelPackage.Workbook.Worksheets[2];
			for (int i = 2; i < Worksheet.Cells.Rows; ++i) {
				if (Worksheet.Cells[i, 1].Value == null)
					break;

				VideoCards.Add(new VideoCard(
					Worksheet.Cells[i, 1].Value?.ToString(),
					Worksheet.Cells[i, 2].Value?.ToString(),
					int.Parse(Worksheet.Cells[i, 3].Value?.ToString())
				));
			}
		}

		private void SetVideoCardManufacturers() {
			foreach (VideoCard VideoCard in VideoCards)
				if (!VideoCardManufacturer_ComboBox.Items.Contains(VideoCard.Manufacturer))
					VideoCardManufacturer_ComboBox.Items.Add(VideoCard.Manufacturer);
		}

		private void VideoCardManufacturer_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			VideoCardModel_ComboBox.SelectedIndex = -1;
			VideoCardModel_ComboBox.Items.Clear();
			foreach (VideoCard VideoCard in VideoCards)
				if (VideoCardManufacturer_ComboBox.Text == VideoCard.Manufacturer)
					if (!VideoCardModel_ComboBox.Items.Contains(VideoCard.Model))
						VideoCardModel_ComboBox.Items.Add(VideoCard.Model);
		}

		#endregion

		#region Power supplies

		private readonly List<PowerSupply> PowerSupplies = new List<PowerSupply>();

		private void ReadPowerSupplies() {
			ExcelWorksheet Worksheet = ExcelPackage.Workbook.Worksheets[3];
			for (int i = 2; i < Worksheet.Cells.Rows; ++i) {
				if (Worksheet.Cells[i, 1].Value == null)
					break;

				PowerSupplies.Add(new PowerSupply(
					int.Parse(Worksheet.Cells[i, 1].Value.ToString()),
					Worksheet.Cells[i, 2].Value?.ToString(),
					Worksheet.Cells[i, 3].Value?.ToString(),
					Worksheet.Cells[i, 4].Value?.ToString()
				));
			}
		}

		#endregion

		#region Calculating

		private void Calculate_Button_Click(object sender, EventArgs e) {
			Action<string> Warning = Element => { MessageBox.Show($"Вы не выбрали {Element}", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); };

			if (ProcessorModel_ComboBox.SelectedIndex < 0) {
				Warning("процессор");
				return;
			}
			int ProcessorConsumption = 0;
			foreach (Processor Processor in Processors) {
				if (ProcessorModel_ComboBox.Text == Processor.Model) {
					ProcessorConsumption = Processor.Consumption;
				}
			}

			if (VideoCardModel_ComboBox.SelectedIndex < 0) {
				Warning("видеокарту");
				return;
			}
			int VideoCardConsumption = 0;
			foreach (VideoCard VideoCard in VideoCards) {
				if (VideoCardModel_ComboBox.Text == VideoCard.Model) {
					VideoCardConsumption = VideoCard.Consumption * (int)VideoCardQuantity_NumericUpDown.Value;
				}
			}

			int TotalConsumption = ProcessorConsumption +
										  VideoCardConsumption +
										  (int)S_ATA_NumericUpDown.Value * 15 +
										  (int)RAM_NumericUpDown.Value * 4 +
										  (int)Ventilator_NumericUpDown.Value * 15;

			foreach (PowerSupply PowerSupply in PowerSupplies) {
				if (TotalConsumption < PowerSupply.MaxPower) {
					PowerSupply_LinkLabel1.Links[0].LinkData = PowerSupply.Links[0];
					PowerSupply_LinkLabel1.Text = "Магазин 1";
					PowerSupply_LinkLabel2.Links[0].LinkData = PowerSupply.Links[1];
					PowerSupply_LinkLabel2.Text = "Магазин 2";
					PowerSupply_LinkLabel3.Links[0].LinkData = PowerSupply.Links[2];
					PowerSupply_LinkLabel3.Text = "Магазин 3";
					break;
				}
			}

			Response_Label.Text = $"Общее энергопотребление - {TotalConsumption} Вт.\n" +
				"В соответствии с этим мы подобрали для Вас блок питания необходимой мощности:";
		}

		#endregion

		private void PowerSupply_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			string Link = e.Link.LinkData as string;
			if (Link != null)
				Process.Start(Link);
		}

	}
}
