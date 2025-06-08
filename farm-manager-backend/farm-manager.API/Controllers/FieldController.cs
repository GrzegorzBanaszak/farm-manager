using farm_manager.Application.Features.Fields.Commands.CreateField;
using farm_manager.Application.Features.Fields.Queries.GetAllFields;
using farm_manager.Application.Features.Fields.Queries.GetFieldById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace farm_manager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FieldController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetFields()
        {
            var query = new GetAllFieldsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFieldById(Guid id)
        {
            var query = new GetFieldByIdQuery(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateField([FromBody] CreateFieldCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid field data.");
            }
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetFieldById), new { id = result }, result);
        }
    }
}
