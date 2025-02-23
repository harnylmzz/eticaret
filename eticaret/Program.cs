using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// CORS Politikas� Ekle
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000") // Frontend URL
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                      });
});

// Controllerlar� ve Swagger'� ekle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Bu sat�r hata veriyordu, paket y�kleyerek ��zd�k.

var app = builder.Build();

// Swagger Middleware Ekle
if (app.Environment.IsDevelopment()) // Sadece geli�tirme ortam�nda �al��s�n
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyAllowSpecificOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
