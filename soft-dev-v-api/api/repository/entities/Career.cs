
public class Career : IEntityBase
{
  public Guid Id { get; set; }
  public string Name { get; set; } = "";
  public int Code { get; set; }
  public IList<Student> Students { get; set; }
}
