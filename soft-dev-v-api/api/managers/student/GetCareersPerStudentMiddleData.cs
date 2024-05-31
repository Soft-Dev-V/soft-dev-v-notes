using MediatR;

public class GetCareersPerStudentMiddleData : IRequest<IList<Career>> 
{
  public Guid IdStudent { get; set; }

  public GetCareersPerStudentMiddleData(Guid idStudent)
  {
    IdStudent = idStudent;
  }
}
