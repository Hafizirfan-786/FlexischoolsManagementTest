using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlexischoolsManagement.Application.Contract;
using FlexischoolsManagement.Application.DTOs;

namespace FlexischoolsManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturesController : ControllerBase
    {
        private readonly IService _services;

        public LecturesController(IService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _services.LectureService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _services.LectureService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] LectureAdditionDto lectureAdditionDto, CancellationToken cancellationToken)
        {
            var response = await _services.LectureService.AddAsync(lectureAdditionDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}
