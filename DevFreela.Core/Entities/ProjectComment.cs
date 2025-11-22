namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, int projectId, int userId)
        {
            Content = content;
            ProjectId = projectId;
            UserId = userId;
            CreatedAt = DateTime.Now;
            UpdateAt = null;
            Active = true;
        }

        public string Content { get; private set; }
        public int ProjectId { get; private set; }
        public int UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdateAt { get; private set; }
        public bool Active { get; private set; }
    }
}