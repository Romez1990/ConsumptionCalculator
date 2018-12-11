﻿using ConsumptionCalculator.Properties;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ConsumptionCalculator.Forms {
	public partial class MainForm : Form {

		public MainForm() {
			InitializeComponent();

			ReadDatabase();

			ReadProcessors();
			SetProcessorManufacturers();

			ReadVideoCards();
			SetVideoCardManufacturers();

			ReadPowerSupplies();
		}

		#region Read database

		private ExcelPackage ExcelPackage;

		private void ReadDatabase() {
			ExcelPackage = new ExcelPackage(new FileInfo("Database.xlsx"));
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
					Worksheet.Cells[i, 1].Value.ToString(),
					Worksheet.Cells[i, 2].Value.ToString(),
					Worksheet.Cells[i, 3].Value.ToString(),
					int.Parse(Worksheet.Cells[i, 4].Value.ToString())
				));
			}
		}

		private void SetProcessorManufacturers() {
			foreach (Processor Processor in Processors)
				if (!ProcessorManufacturer_ComboBox.Items.Contains(Processor.Manufacturer))
					ProcessorManufacturer_ComboBox.Items.Add(Processor.Manufacturer);
		}

		private void ProcessorManufacturer_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ProcessorModel_ComboBox.Text = Resources.MainForm_ComboBox_DefaultValue;
			ProcessorModel_ComboBox.Items.Clear();
			Socket_ComboBox.Text = Resources.MainForm_ComboBox_DefaultValue;
			Socket_ComboBox.Items.Clear();
			foreach (Processor Processor in Processors)
				if (ProcessorManufacturer_ComboBox.Text == Processor.Manufacturer)
					if (!Socket_ComboBox.Items.Contains(Processor.Socket))
						Socket_ComboBox.Items.Add(Processor.Socket);
		}

		private void Socket_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ProcessorModel_ComboBox.Text = Resources.MainForm_ComboBox_DefaultValue;
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
					Worksheet.Cells[i, 1].Value.ToString(),
					Worksheet.Cells[i, 2].Value.ToString(),
					int.Parse(Worksheet.Cells[i, 3].Value.ToString())
				));
			}
		}

		private void SetVideoCardManufacturers() {
			foreach (VideoCard VideoCard in VideoCards)
				if (!VideoCardManufacturer_ComboBox.Items.Contains(VideoCard.Manufacturer))
					VideoCardManufacturer_ComboBox.Items.Add(VideoCard.Manufacturer);
		}

		private void VideoCardManufacturer_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			VideoCardModel_ComboBox.Text = Resources.MainForm_ComboBox_DefaultValue;
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
					Worksheet.Cells[i, 2].Value.ToString()
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
					PowerSupply_LinkLabel.Text = "Ссылка на блок питания";
					PowerSupply_LinkLabel.Links.Add(new LinkLabel.Link { LinkData = PowerSupply.Link });
					break;
				}
			}

			Response_Label.Text = $"Общее энергопотребление - {TotalConsumption} Вт.\n" +
				"В соответствии с этим мы подобрали для Вас блок питания необходимой мощности:";
		}

		#endregion

		private void PowerSupply_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			if (e.Link.LinkData is string link)
				Process.Start(link);
		}

	}
}
