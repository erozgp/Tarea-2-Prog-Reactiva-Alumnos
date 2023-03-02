using System.Reflection;
using System.Runtime.InteropServices;

namespace Tarea_2_Prog_Reactiva_Alumnos
{
    internal class PrincipalFuntion
    {

        static void Main(string[] args)
        {
            //Definicion de observador
            Tracking trackings = new Tracking();

            //Creación del mensaje a lanzar durante el evento de agregación
            trackings.ObserverEvent += (sender, alumno) =>
            {
                Console.WriteLine($"Se agrego {alumno.Name}, que tiene {alumno.Age} años y su mail {alumno.Email}");
            };

            //Definición del alumno
            Alumno alumno;

            //Creación de los alumnos en tracking
            for (int i = 0; i < 5; i++)
            {
                trackings.AddTracking(
                    new Alumno(
                        "Alumno " + i,
                        17 + i,
                        "correo" + i + "@gmail.com"
                    ));
            }

            //Obtención de la lista actual de alumnos trackeados
            List<Alumno> AlumnoList = trackings.GetTracked();

            //Creación del mensaje a lanzar durante el evento de eliminación
            trackings.ObserverEventRmv += (sender, alumno) =>
            {
                Console.WriteLine($"Se elimino {alumno.Name}");
            };

            //Eliminación del alumno
            if ( AlumnoList.Count > 0 )
            {
                trackings.RemoveTracking(AlumnoList[3]);
            }
            
            //Muestra los alumnos actualmente trackeados
            trackings.ShowTrackeds();
        }

    }
}
