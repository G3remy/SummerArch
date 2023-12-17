using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Class
{
    public abstract class MiembroDeLaComunidad
    {
        public string Id { get; set; }
        public string Sex { get; set; }
        public string Genre { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public virtual void Sleep()
        {
            Console.WriteLine("Sleep action has started.");
        }
        public void WakeUp()
        {
            Console.WriteLine("Waked up.");
        }
        public void Eat()
        {
            Console.WriteLine("Eating food...");
        }
    }
}
