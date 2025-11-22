namespace DevFreela.API.Models
{
    public class CreateProjectCommetInputModel
    {
        public string Comment { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
