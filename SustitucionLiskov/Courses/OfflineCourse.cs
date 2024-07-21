using SustitucionLiskov.Base;

namespace SustitucionLiskov.Courses
{
    public class OfflineCourse : Course
    {
        public override string CourseDetails()
        {
            return $"Offline Course: {Title} - ID: {CourseId}";
        }

        public override void Subscribe(Student std)
        {
            // METODO PARA REGISTRARSE AL OFFLINE COURSE
        }
    }
}
