namespace ConsumptionCalculator {
	struct Processor {

		public string Manufacturer;
		public string Socket;
		public string Model;
		public int Consumption;

		public Processor(string Manufacturer, string Socket, string Model, int Consumption) {
			this.Manufacturer = Manufacturer;
			this.Socket = Socket;
			this.Model = Model;
			this.Consumption = Consumption;
		}

	}
}
