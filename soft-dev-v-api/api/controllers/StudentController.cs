using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
  [HttpGet]
  public async Task<IActionResult> Get()
  {
    // var i = 0;
    // var j = 0;
    // var x = i / j;
    throw new TestingException();
    var students = new List<Student> 
    {
      new Student 
      { 
        Id = Guid.NewGuid(),
        Name = "Mario",
        Lastname = "Carvajal",
        Birthdate = DateTime.Now,
      }
    };
    return Ok(students);
  }
}
