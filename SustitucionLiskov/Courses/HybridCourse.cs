
using SustitucionLiskov.Base;

namespace SustitucionLiskov.Courses
{
    public class HybridCourse : Course
    {
        public override string CourseDetails()
        {
            return $"Hybrid Course: {Title} - ID: {CourseId}";
        }

        public override void Subscribe(Student std)
        {
            // METODO PARA REGISTRARSE AL HYBRID COURSE
        }
    }
}
