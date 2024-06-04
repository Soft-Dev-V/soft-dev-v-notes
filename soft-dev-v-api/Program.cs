using System.Text.Json.Serialization;
using Handlers;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => 
{
	options.Filters.Add<ErrorHandler>();
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BaseContext>(options 
	=> options.UseNpgsql(builder.Configuration.GetConnectionString("UniversityDb")));

builder.Logging.AddLog4Net("log.config");
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddSingleton<ILogHandler, LogHandler>();

builder.Services.AddControllers()
								.AddJsonOptions(x 
										=> x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

// builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// builder.Services.AddMediatR(typeof(UniversityProfile).Assembly);
// builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UniversityProfile).Assembly));

builder.Services.AddAutoMapper(typeof(UniversityProfile).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<BaseContext>();
	context.Database.Migrate();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
