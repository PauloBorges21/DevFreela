using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Project 1", "Description 1", 1, 2, 1000),
                new Project("Project 2", "Description 2", 2, 3, 2000),
                new Project("Project 3", "Description 3", 1, 3, 3000)
            };
            Users = new List<User>
            {
                new User("Alice Johnson", "paulo@email.com", new DateTime(1990, 5, 24)),
                new User("Bob Smith", "bob@email.com", new DateTime(1985, 8, 15)),
                new User("Charlie Brown", "charlie@email.com", new DateTime(1992, 12, 3))
            };
            Skills = new List<Skill>
            {
                new Skill("C#"),
                new Skill("JavaScript"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
