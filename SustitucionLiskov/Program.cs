using SustitucionLiskov.Base;
using SustitucionLiskov.Courses;

namespace SustitucionLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { StudentId = 2022 - 1921, Name = "Diana Calderon" };

            Course onlineCourse = new OnlineCourse { CourseId = 1014, Title = "Curso de C# Basico Virtual" };
            Course offlineCourse = new OfflineCourse { CourseId = 1015, Title = "Curso de C# Intermedio Presencial" };
            Course hybridCourse = new HybridCourse { CourseId = 1016, Title = "Curso de C# Avanzado Semipresencial" };

            Console.WriteLine("***CURSOS REGISTRADOS***");
            Console.WriteLine($"\nOnline Course = {onlineCourse.Title} ");
            Console.WriteLine($"Offline Course = {offlineCourse.Title} ");
            Console.WriteLine($"Hybrid Course = {hybridCourse.Title} ");
        }
    }
}