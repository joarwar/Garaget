namespace Garaget
{
    public abstract class Vehicle
    {
        public uint Tires { get; set; }
        public string RegisterNumber { get; set; }
        public string Color { get; set; }
        public uint Space { get; set; }
        public string Brand { get; set; }
        public int ObjType { get; set; }

        public Vehicle(uint tires, string registerNumber, string color, uint space, string brand )
        {
            Tires = tires;
            RegisterNumber = registerNumber;
            Color = color;
            Space = space;
            Brand = brand;
        }

        public override string ToString()
        {
            return "Tires: " + Tires +
                "\nRegistration number: " + RegisterNumber +
                "\nColor: " + Color +
                 "\nNumber of seats: " + Space +
                 "\nBrand: " + Brand;

        }
    }
}
