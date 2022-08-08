using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public int WheelCount { get; set; }
        public int SeatCount { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name}  is now driving forward");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"GetType().Name) is now in park");
                HasChangedGears = false;
            }
        }

        public void ChangeGears(bool hasChanged)
        {
            HasChangedGears = true;
        }
    }
}

