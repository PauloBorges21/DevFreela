namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime createAt, string status)
        {
            Id = id;
            Title = title;
            CreateAt = createAt;
            Status = status;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateAt { get; set; }
        public string Status { get; set; }
    }
}