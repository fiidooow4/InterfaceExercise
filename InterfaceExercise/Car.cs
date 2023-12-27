﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; } = 4;
        public int Speed { get; set; } = 260;
        public bool HasEngine { get; set; } = true;  
        public bool IsRunning { get; set; } = true;
        public string Logo { get; set; } = "KIA";
        public string Name { get; set; } = "Kia Rio";
        public bool HasTrunk { get; set; } = true;
        public bool IsChangedGears { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} Now driving Forward...");
        }

        public void Reverse()
        {
            if (IsChangedGears)
            {
                Console.WriteLine($"{GetType().Name} Now reversing ..");
                IsChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't Reverse Until we change gears.");
            }
        }

        public void Park()
        {
            if (IsChangedGears)
            {
                Console.WriteLine($"{GetType().Name} Now in Park ..");
                IsChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't Park Until we change gears.");
            }
        }

        public void ChangeGears(bool isChangedGears)
        {
            IsChangedGears = isChangedGears;
        }
    }
}
