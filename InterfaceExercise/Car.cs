using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public int WheelCount { get; set; }
        public int SeatCount  { get; set; }
        public string Model   { get; set; }
        public string Make { get; set; }
        public string Name    { get; set; }
        public string Logo    { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
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
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park");
                HasChangedGears = false;
            }
        }

        public void ChangeGears(bool hasChanged)
        {
            HasChangedGears = true;
        }
    }
}

