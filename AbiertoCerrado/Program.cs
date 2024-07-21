using AbiertoCerrado.Course;
using AbiertoCerrado.Interfaces;

namespace AbiertoCerrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { StudentId = 2022-1021, Name = "Diana Calderon" };

            ICourse onlineCourse = new OnlineCourse { CourseId = 1011, Title = "Online Course 1011" };
            ICourse offlineCourse = new OfflineCourse { CourseId = 1012, Title = "Offline Course 1012" };
            ICourse hybridCourse = new HybridCourse { CourseId = 1013, Title = "Hybrid Course 1013" };

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);
            hybridCourse.Subscribe(student);

            Console.WriteLine("\n***Suscripciones completadas***");
            Console.WriteLine($"\nCurso En linea = {onlineCourse.Title}");
            Console.WriteLine($"Curso Presencial = {offlineCourse.Title}");
            Console.WriteLine($"Curso Hibrido = {hybridCourse.Title}");
   
        }
    }
}