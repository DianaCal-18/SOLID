
namespace AbiertoCerrado
{
    // Open/Close quiere decir que debe de estar abierto a extensiones pero no a modificaciones, es decir
    // que se puede extender el comportamiento de un metodo sin alterar o modificar comportamiento (el codigo) original
    public class Ejercicio2
    {
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
                //write code to subscribe to an online course
            }
        }

        public class OfflineCourse : Course
        {
            public override void Subscribe(Student std)
            {
                //write code to subscribe to an offline course
            }
        }

    }
}
