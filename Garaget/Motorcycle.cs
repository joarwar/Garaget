namespace Garaget
{
    class Motorcycle : Vehicle
    {
        public decimal Price { get; set; }

        public uint Cylinder { get; set; }
        public Motorcycle(uint tires, string registerNumber, string color, uint space, string brand, decimal price, uint cylinder) : base(tires, registerNumber, color, space, brand)
        {
            Price = price;
            Cylinder = cylinder;
            ObjType = 3;
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nCost: " + Price +
                "\nCylinders: " + Cylinder;
        }
    }
}
