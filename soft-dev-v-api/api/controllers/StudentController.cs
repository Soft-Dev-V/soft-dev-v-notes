using System.ComponentModel.DataAnnotations;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
  private readonly IMediator _mediator;
  private readonly IMapper _mapper;

  public StudentController(IMediator mediator, IMapper mapper)
  {
    _mediator = mediator;
    _mapper = mapper;
  }

  [HttpGet("idStudent")]
  public async Task<IActionResult> Get([Required] Guid idStudent)
  {
    var contract = new GetStudentMiddleData(idStudent);
    var middleResponse = await _mediator.Send(contract);
    var student = _mapper.Map<StudentDTO>(middleResponse);

    return Ok(student);
  }

  [HttpGet, Route("careers/idStudent")]
  public async Task<IActionResult> GetCareersPerStudent([Required] Guid idStudent)
  {
    var contract = new GetCareersPerStudentMiddleData(idStudent);
    var middleResponse = await _mediator.Send(contract);
    var careers = _mapper.Map<IList<CareerDTO>>(middleResponse);

    return Ok(careers);
  }

  [HttpPost, Route("subscribe")]
  public async Task<IActionResult> Post([Required] Guid idCareer, Student student)
  {

    return Ok();
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
