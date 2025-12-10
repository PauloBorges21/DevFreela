using DevFreela.Application.Services.Interfaces;
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

        public async Task<SkillViewModel> GetAll()
        {
            var skills = _dbContext.Skills;
        }
    }
}
