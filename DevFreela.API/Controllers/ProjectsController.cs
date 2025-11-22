using DevFreela.API.Models;
using DevFreela.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/project")]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _costConfig;
        private readonly IConfigService _configService;
        public ProjectsController(
            IOptions<FreelanceTotalCostConfig> options,
            IConfigService configService
            )
        {
            _costConfig = options.Value;
            _configService = configService;
        }

        [HttpGet("search/{search}")]
        public IActionResult Get(string search ="")
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            if (model.TotalCost < _costConfig.Minimum || model.TotalCost > _costConfig.Maximum )
            {
                return BadRequest("Valor fora dos limites");
            }

            return CreatedAtAction(nameof(GetById), new { id = 1 }, model); // CreatedAtAction posso consultar no GetById e passar o id para buscar e retornar o objeto
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommetInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model); // CreatedAtAction posso consultar no GetById e passar o id para buscar e retornar o objeto
        } 

    }
}
