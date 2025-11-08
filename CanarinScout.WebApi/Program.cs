using CanarinScout.Application.Mapping;
using CanarinScout.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddService(builder.Configuration);
builder.Services.AddRepository(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(JogadorProfile));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowAll");

app.MapControllers();
app.MapGet("/", () => "API rodando no Render com Swagger disponível em /swagger");

var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Urls.Add($"http://0.0.0.0:{port}");

app.Run();
