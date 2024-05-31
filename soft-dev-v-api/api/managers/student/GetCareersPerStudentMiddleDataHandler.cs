using MediatR;

public class GetCareersPerStudentMiddleDataHandler : IRequestHandler<GetCareersPerStudentMiddleData, IList<Career>>
{
  private readonly IStudentRepository _studentRepository;

  public GetCareersPerStudentMiddleDataHandler(IStudentRepository studentRepository)
  {
    _studentRepository = studentRepository;
  }

  public async Task<IList<Career>> Handle(GetCareersPerStudentMiddleData request, CancellationToken cancellationToken)
  {
    var careers = await _studentRepository.GetCareers(request.IdStudent);
    
    return careers;
  }
}
