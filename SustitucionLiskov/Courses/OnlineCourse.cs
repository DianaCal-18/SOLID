using SustitucionLiskov.Base;

namespace SustitucionLiskov.Courses
{
    public class OnlineCourse : Course
    {
        public override string CourseDetails()
        {
            return $"Online Course: {Title} - ID: {CourseId}";
        }

        public override void Subscribe(Student std)
        {
            // METODO PARA REGISTRARSE AL ONLINE COURSE;
        }
    }
}
