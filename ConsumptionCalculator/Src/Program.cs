using System;
using System.Windows.Forms;
using ConsumptionCalculator.Form;

namespace ConsumptionCalculator {
	static class Program {
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
