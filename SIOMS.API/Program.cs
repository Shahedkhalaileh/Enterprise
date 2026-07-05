using SIOMS.Application.Features.Products.Commands;
using SIOMS.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<CreateProductHandler>();
builder.Services.AddPersistence(builder.Configuration);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Map Controllers
app.MapControllers();

app.Run();
