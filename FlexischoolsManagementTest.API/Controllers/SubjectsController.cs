using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlexischoolsManagement.Application.Contract;
using FlexischoolsManagement.Application.DTOs;

namespace FlexischoolsManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IService _services;

        public SubjectsController(IService services) => _services = services;

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _services.SubjectService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _services.SubjectService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SubjectAdditionDto SubjectForAdditionDto, CancellationToken cancellationToken)
        {
            var response = await _services.SubjectService.AddAsync(SubjectForAdditionDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }

        [HttpGet("GetByStudentId")]
        public async Task<IActionResult> GetByStudentId(int studentId, CancellationToken cancellationToken)
        {
            var response = await _services.SubjectService.RetrieveAsync(studentId, cancellationToken);

            return Ok(response);
        }

        [HttpPost("enrollStudent")]
        public async Task<IActionResult> Enroll([FromBody] EnrollmentStudentDto EnrollStudentDto, CancellationToken cancellationToken)
        {
            await _services.SubjectService.EnrollAsync(EnrollStudentDto, cancellationToken);

            return Ok();
        }
    }
}
