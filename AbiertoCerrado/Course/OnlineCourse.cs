using AbiertoCerrado.Interfaces;
using AbiertoCerrado.Subscribe;

namespace AbiertoCerrado.Course
{
    public class OnlineCourse : ICourse
    {


        private readonly ISubscribeService subscribeService;

        public OnlineCourse()
        {
            subscribeService = new SubscribeOnline();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }

        public void Subscribe(Student std)
        {
            subscribeService.Subscribe(std);
        }
    }
}

