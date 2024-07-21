using AbiertoCerrado.Interfaces;
using AbiertoCerrado.Subscribe;
namespace AbiertoCerrado.Course
{
    public class OfflineCourse : ICourse
    {
        private readonly ISubscribeService subscribeService;

        public OfflineCourse()
        {
            subscribeService = new SubscribeOffline();
        }
        public int CourseId { get; set; }
        public string Title { get; set; }

        public void Subscribe(Student std)
        {
            subscribeService.Subscribe(std);
        }
    }
}
