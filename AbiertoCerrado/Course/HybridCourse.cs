
using AbiertoCerrado.Interfaces;
using AbiertoCerrado.Subscribe;

namespace AbiertoCerrado.Course
{
    public class HybridCourse : ICourse
    {
        private readonly ISubscribeService subscribeService;

        public HybridCourse()
        {
            subscribeService = new SubscribeHybrid();
        }
        public int CourseId { get; set ; }
        public string Title { get; set; }

        public void Subscribe(Student std)
        {
            subscribeService.Subscribe(std);
        }
    }
}
