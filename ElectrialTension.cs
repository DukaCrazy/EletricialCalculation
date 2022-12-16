namespace ElectrianCalculation {
    internal class ElectrialTension
    {

        public double Volts;
        public double Ampere;
        public double Ohm;

        public double Tension(double ampere, double ohm)
        {
            return Volts = ampere * ohm;
        }

        public double Curret(double volts, double ohm)
        {
            return Ampere = volts / ohm;
        }

        public double Resistance(double volts, double ampere)
        {
            return Ohm = volts / ampere;
        }
    }
}
    