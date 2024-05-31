using MediatR;

public class GetStudentMiddleData : IRequest<Student> 
{
  public Guid IdStudent{ get; set; }
  public GetStudentMiddleData(Guid id)
  {
    IdStudent = id;
  }
}
