
public class Student : IEntityBase
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Lastname { get; set; } = "";
    public DateTime Birthdate { get; set; }
}
