var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

// Routing - Minimal API
// app.MapGet("/shirts", () =>
// {
//     return "Reading all the shirts";
// });

// app.MapGet("/shirts/{id}", (int id) =>
// {
//     return $"Reading shirt: {id}";
// });

// app.MapPost("/shirts", () =>
// {
//     return "Creating a shirt";
// });

// app.MapPut("/shirts/{id}", (int id) =>
// {
//     return $"Updating shirt with ID: {id}";
// });

// app.MapDelete("/shirts/{id}", (int id) =>
// {
//     return $"Deleting shirt with ID: {id}";
// });

app.Run();