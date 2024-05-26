using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlexischoolsManagement.Application.Contract;
using FlexischoolsManagement.Application.DTOs;

namespace FlexischoolsManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureTheatresController : ControllerBase
    {
        private readonly IService _services;

        public LectureTheatresController(IService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _services.LectureTheatreService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _services.LectureTheatreService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] LectureTheatreAdditionDto lectureTheatreAdditionDto, CancellationToken cancellationToken)
        {
            var response = await _services.LectureTheatreService.AddAsync(lectureTheatreAdditionDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}
