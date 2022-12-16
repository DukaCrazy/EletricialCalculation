namespace ElectrianCalculation {
    public static class ElectrialResistance {
        
        public static double EquivalentResistanceInSerie;
        public static double EquivalentResistanceInParallel;
        public static double ResistanceInSerie(double r1, double r2) {
            return EquivalentResistanceInSerie = r1 + r2;
        }
        public static double ResistanceInParallel(double r1, double r2) {
            double fraction = 1;
            return EquivalentResistanceInParallel = fraction / (fraction / r1 + fraction / r2);
        }
    }
}
