var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// 🔹 Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

var app = builder.Build();
app.UseHttpsRedirection();

// 🔹 Use CORS
app.UseCors("AllowAngular");

app.MapControllers();

app.Run();
    