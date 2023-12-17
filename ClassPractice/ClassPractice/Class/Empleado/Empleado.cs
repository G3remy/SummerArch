using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Class.Empleado
{
    public class Empleado : MiembroDeLaComunidad
    {
        DateTime WorkInHour { get; set; }
        DateTime WorkOutHour { get; set; }
        double Salary { get; set; }

        public void GoToWork()
        {
            Console.WriteLine("The work has started.");
        }
        public override void Sleep()
        {
            if (DateTime.Now.Hour > WorkOutHour.Hour && DateTime.Now.DayOfWeek != 0 | (int)DateTime.Now.DayOfWeek != 2)
                Console.WriteLine("Going to sleep.");
            else
                Console.WriteLine("Cannot go to sleep, it's work time");
        }

    }
}
