namespace Garaget
{
    class Truck : Vehicle
    {
        public bool IsPickup { get; set; }
        public int ModelYear { get; set; }
        public Truck(uint tires, string registerNumber, string color, uint space, string brand, bool isPickup, int modelYear) : base(tires,registerNumber,color,space,brand)
        {

            IsPickup = isPickup;
            ModelYear = modelYear;
            ObjType = 5;
        }

        public override string ToString()
        {
            return base.ToString() +
               "\n" + (IsPickup ? "Is pickup":"Is not a pickup") +
               "\nYear made: " + ModelYear;
        }
    }
}
