using AutoMapper;

public class UniversityProfile : Profile
{
  public UniversityProfile()
  {
    CreateMap<Student, StudentDTO>();
		CreateMap<Career, CareerDTO>();
  }
}
