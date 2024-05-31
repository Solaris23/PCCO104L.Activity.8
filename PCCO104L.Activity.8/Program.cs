namespace PCCO104L.Activity._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carFerrari = new Car(80.71, "Ferrari", 80000, "Italy", "Gasoline", 70000);
            carFerrari.globalRating();
            carFerrari.StartEngine();

            ElectricCar teslaCar = new ElectricCar(90.45, "Tesla", 75000, "USA", 300);
            teslaCar.globalRating();
            teslaCar.ChargeVehicle();

            Motorcycle harleyDavidson = new Motorcycle(78.92, "Harley-Davidson", 20000, "USA", "Gasoline", 200);
            harleyDavidson.globalRating();
            harleyDavidson.StartEngine();
            harleyDavidson.TurnOnLights();
        }
    }

    public interface IVehicle
    {
        void globalRating();
        void StartEngine();
    }

    public abstract class Vehicle : IVehicle
    {
        public string Brand { get; set; }
        protected double _Rating { get; set; }
        protected int _Price { get; set; }
        public string Country { get; set; }

        public Vehicle(double rating, string brand, int price, string country)
        {
            _Rating = rating;
            Brand = brand;
            _Price = price;
            Country = country;
        }

        public abstract void globalRating();
        public abstract void StartEngine();
    }

    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        private int _Mileage { get; set; }

        public Car(double rating, string brand, int price, string country, string fuelType, int mileage)
            : base(rating, brand, price, country)
        {
            FuelType = fuelType;
            _Mileage = mileage;
        }

        public override void globalRating()
        {
            Console.WriteLine($"{Brand} - Rating: {_Rating} - Price: {_Price} - Country: {Country} - Fuel Type: {FuelType} - Mileage: {_Mileage}");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }

        public void TurnOnHeadlights()
        {
            Console.WriteLine($"{Brand} headlights turned on.");
        }
    }

    public class ElectricCar : Vehicle, IVehicle
    {
        public int BatteryRange { get; set; }

        public ElectricCar(double rating, string brand, int price, string country, int batteryRange)
            : base(rating, brand, price, country)
        {
            BatteryRange = batteryRange;
        }

        public override void globalRating()
        {
            Console.WriteLine($"{Brand} - Rating: {_Rating} - Price: {_Price} - Country: {Country} - Battery Range: {BatteryRange} miles");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} electric motor started.");
        }

        public void ChargeVehicle()
        {
            Console.WriteLine($"{Brand} is being charged.");
        }
    }

    public class Motorcycle : Vehicle, IVehicle
    {
        public string FuelType { get; set; }
        private int _EngineDisplacement { get; set; }

        public Motorcycle(double rating, string brand, int price, string country, string fuelType, int engineDisplacement)
            : base(rating, brand, price, country)
        {
            FuelType = fuelType;
            _EngineDisplacement = engineDisplacement;
        }

        public override void globalRating()
        {
            Console.WriteLine($"{Brand} - Rating: {_Rating} - Price: {_Price} - Country: {Country} - Fuel Type: {FuelType} - Engine Displacement: {_EngineDisplacement}cc");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }

        public void TurnOnLights()
        {
            Console.WriteLine($"{Brand} lights turned on.");
        }
    }
}