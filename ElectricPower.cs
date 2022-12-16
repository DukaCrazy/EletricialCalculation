namespace ElectrianCalculation {
    public static class ElectricPower  {

        public static double Watts;
        public static double Volts;
        public static double Ampere;

        public static double Power(double volts, double ampere)  {
            return Watts = volts * ampere;
        }

        public static double Tension(double power, double ampere) {
            return Volts = power / ampere;
        }

        public static double Current(double power, double tension)
        {
            return Ampere = power / tension;
        }
    }
}
