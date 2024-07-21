namespace AbiertoCerrado.Interfaces
{
    public interface ICourse
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public void Subscribe(Student std);

    }

}
