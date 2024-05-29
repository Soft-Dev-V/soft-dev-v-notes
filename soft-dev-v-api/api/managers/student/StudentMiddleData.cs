using MediatR;

public class StudentMiddleData : IRequest<Student> 
{
  public Guid IdStudent{ get; set; }
  public StudentMiddleData(Guid id)
  {
    IdStudent = id;
  }
}
