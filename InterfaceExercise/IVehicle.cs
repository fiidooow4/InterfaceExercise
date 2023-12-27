using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        int NumberOfWheels { get; set; }
        int Speed { get; set; }
        bool HasEngine { get; set; }
        bool IsRunning { get; set; }
        bool IsChangedGears { get; set; }

        void Drive();
        void Reverse();
        void Park();
        void ChangeGears(bool isChangedGears);
    }
}
