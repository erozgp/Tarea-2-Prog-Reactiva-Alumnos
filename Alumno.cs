using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_Prog_Reactiva_Alumnos
{
    internal class Alumno
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Alumno(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
