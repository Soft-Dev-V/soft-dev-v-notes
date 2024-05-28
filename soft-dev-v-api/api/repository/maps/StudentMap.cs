using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StudentMap : IEntityTypeConfiguration<Student>
{
  public void Configure(EntityTypeBuilder<Student> builder)
  {
    builder.ToTable("Student");

    builder.HasIndex(p => p.Id);
    builder.Property(p => p.Id).ValueGeneratedOnAdd();

    builder.Property(p => p.Name);
    builder.Property(p => p.Lastname);
    builder.Property(p => p.Birthdate);
  }
}
