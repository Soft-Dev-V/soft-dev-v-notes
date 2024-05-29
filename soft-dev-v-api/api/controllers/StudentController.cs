using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
  private readonly IMediator _mediator;

  public StudentController(IMediator mediator)
  {
    _mediator = mediator;
  }

  [HttpGet("IdStudent")]
  public async Task<IActionResult> Get([Required] Guid idStudent)
  {
    var middle = new StudentMiddleData(idStudent);
    var student = await _mediator.Send(middle);

    return Ok(student);
  }

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] Student student)
  {
    return Ok();
  }

  [HttpPut]
  public async Task<IActionResult> Put([FromBody] Student student)
  {
    return Ok();
  }

  [HttpDelete("{Id}")]
  public async Task<IActionResult> Delete([Required] Guid id)
  {
    return Ok();
  }
}
