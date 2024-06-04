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
  private readonly ILogHandler _logHandler;

  public StudentController(IMediator mediator, IMapper mapper, ILogHandler logHandler)
  {
    _mediator = mediator;
    _mapper = mapper;
    _logHandler = logHandler;
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
    _logHandler.Log(Handlers.Severity.INFO, "Not Implemented");
    return Ok();
  }

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] StudentDTO student)
  {
    // _logHandler.Log(Handlers.Severity.INFO, "Not Implemented");
    throw new TestingException();
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
