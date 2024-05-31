using MediatR;

public class GetStudentMiddleDataHandler : IRequestHandler<GetStudentMiddleData, Student>
{
  private readonly IStudentRepository _repository;

  public GetStudentMiddleDataHandler(IStudentRepository repository)
  {
    _repository = repository;
  }

  public async Task<Student> Handle(GetStudentMiddleData request, CancellationToken cancellationToken)
  {
    return await _repository.GetById(request.IdStudent);
  }
}
