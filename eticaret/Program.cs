using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// CORS Politikasý Ekle
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

// Controllerlarý ve Swagger'ý ekle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Bu satýr hata veriyordu, paket yükleyerek çözdük.

var app = builder.Build();

// Swagger Middleware Ekle
if (app.Environment.IsDevelopment()) // Sadece geliþtirme ortamýnda çalýþsýn
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyAllowSpecificOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
