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

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // React app's URL
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors("AllowFrontend");


// Serve React static files
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//redirecting to the swagger page. Making that the "homepage"
app.MapGet("/", context => Task.Run(() => context.Response.Redirect("/swagger")));

//app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
