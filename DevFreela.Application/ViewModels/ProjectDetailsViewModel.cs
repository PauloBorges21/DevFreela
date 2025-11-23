using DevFreela.Core.Enums;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int projectId, string title, string description, decimal totalCost, DateTime? startedAt, DateTime? finishedAt, ProjectStatusEnum status)
        {
            ProjectId = projectId;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            Status = status;
        }

        public int ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
    }
}