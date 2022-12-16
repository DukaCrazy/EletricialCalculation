using System.Globalization;
namespace ElectrianCalculation{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectrialTension lamp;
            lamp = new ElectrialTension();

            lamp.Volts = 127;
            lamp.Ampere = ElectricPower.Current(50, lamp.Volts);
            lamp.Ohm = lamp.Resistance(lamp.Volts, lamp.Ampere);

            Console.WriteLine("The resistance is " + lamp.Ohm.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}