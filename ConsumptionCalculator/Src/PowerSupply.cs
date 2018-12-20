namespace ConsumptionCalculator {
	struct PowerSupply {

		public int MaxPower;
		public string[] Links;

		public PowerSupply(int MaxPower, params string[] Links) {
			this.MaxPower = MaxPower;
			this.Links = Links;
		}

	}
}
