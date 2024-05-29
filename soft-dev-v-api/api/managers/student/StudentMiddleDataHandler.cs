using MediatR;

public class StudentMiddleDataHandler : IRequestHandler<StudentMiddleData, Student>
{
  private readonly IStudentRepository _repository;

  public StudentMiddleDataHandler(IStudentRepository repository)
  {
    _repository = repository;
  }

  public async Task<Student> Handle(StudentMiddleData request, CancellationToken cancellationToken)
  {
    return await _repository.GetById(request.IdStudent);
  }
}
