using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillViewModel>> GetAll()
        {
            var skills = _dbContext.Skills;

            //skills.ToList();

            //return skills
            //    .Select(s => new SkillViewModel
            //    {
            //        Id = s.Id,
            //        Description = s.Description
            //    })
            //    .ToList();
            return skills
                .Select(s => new SkillViewModel(s.Id, s.Description))
                .ToList();
        }
    }
}
