using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public int Speed { get; set; }
        public bool HasEngine { get; set; }
        public bool IsRunning { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forward.");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is now reversing.");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is now parked.");
        }

        public void ChangeGears(bool isChangedGears)
        {
            Console.WriteLine($"{GetType().Name} has {(isChangedGears ? "changed" : "not changed")} gears.");
        }
    }
}