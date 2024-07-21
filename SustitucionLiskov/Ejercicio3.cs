
using SustitucionLiskov.Base;

namespace SustitucionLiskov
{
    public class Ejercicio3
    {
        // LSP establece que; Los objetos de una clase derivada deben
        // poder ser sustituidos por objetos de la clase base sin alterar el correcto funcionamiento del programa
        public abstract class Course
        {
            public int CourseId { get; set; }
            public string Title { get; set; }

            public abstract void Subscribe(Student std);
        }

        public class OnlineCourse : Course
        {
            public override void Subscribe(Student std)
            {
                // write code to subscribe to an online course
            }
        }

        public class OfflineCourse : Course
        {
            public override void Subscribe(Student std)
            {
                // write code to subscribe to an offline course
            }
        }

    }
}
