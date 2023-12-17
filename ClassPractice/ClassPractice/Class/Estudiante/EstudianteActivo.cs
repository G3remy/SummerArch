using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice.Class.Estudiante
{
    internal class EstudianteActivo : BaseEstudiante
    {
        public string Class { get; set; }

        public void MakeHomework()
        {
            Console.WriteLine("Making homework.");
        }

    }
}
