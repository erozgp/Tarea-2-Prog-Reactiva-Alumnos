using System;

namespace Tarea_2_Prog_Reactiva_Alumnos
{
    internal class Tracking
    {

        public event EventHandler<Alumno> ObserverEvent;
        public event EventHandler<Alumno> ObserverEventRmv;

        private List<Alumno> alumnos = new List<Alumno>();

        public Tracking()
        {
            
        }

        public void AddTracking(Alumno alumnos)
        {
            this.alumnos.Add(alumnos);
            ObserverEvent?.Invoke(this, alumnos);
        }

        public void RemoveTracking(Alumno alumnos)
        {
            this.alumnos.Remove(alumnos);
            ObserverEventRmv?.Invoke(this, alumnos);
        }

        public List<Alumno> GetTracked()
        {
            return this.alumnos;
        }

        public void ShowTrackeds()
        {
            alumnos.ForEach((n) =>
            {
                Console.WriteLine(n.Name);
            });
        }

    }
}