using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Class.Empleado
{
    public class Maestro : Docente
    {
        public string Subject { get; set; }
        public List<string> Sections { get; set; }

        public void Teach()
        {
            Console.WriteLine("Teaching.");
        }
    }
}
