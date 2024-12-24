var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Explicitly configure Kestrel to bind to port 8080 on all interfaces
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080); // Bind to all network interfaces
});

var app = builder.Build();

//NEw
// Serve React static files
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//new 
// Fallback route for React
app.MapFallbackToFile("index.html");
app.Run();
