namespace DevFreela.API.Models
{
    public class CreateProjectCommetInputModel
    {
        string Comment { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
