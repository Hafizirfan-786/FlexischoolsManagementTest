using Microsoft.AspNetCore.Mvc;
using FlexischoolsManagement.Application.Contract;
using FlexischoolsManagement.Application.DTOs;

namespace FlexischoolsManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IService _services;

        public StudentsController(IService services) => _services = services;

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _services.StudentService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _services.StudentService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpGet("GetBySubjectId")]
        public async Task<IActionResult> Retrieve(int subjectId, CancellationToken cancellationToken)
        {
            var response = await _services.StudentService.RetrieveAsync(subjectId, cancellationToken);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] StudentAdditionDto studentAdditionDto, CancellationToken cancellationToken)
        {
            var response = await _services.StudentService.AddAsync(studentAdditionDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}
