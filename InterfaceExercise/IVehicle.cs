using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int WheelCount { get; set; }
        public int SeatCount { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);

    }
}

//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */