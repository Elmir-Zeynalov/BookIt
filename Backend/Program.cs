using Azure.Identity;
using Backend.Database;
using Backend.Services.BlobStorageServices;
using Backend.Services.ListingServices;
using Backend.Services.PasswordServices;
using Backend.Services.UserServices;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add KeyVault secrets to configuration
var keyVaultName = builder.Configuration["KeyVaultName"];
if(!string.IsNullOrEmpty(keyVaultName))
{
    var keyVaultUri = new Uri($"https://{keyVaultName}.vault.azure.net/");
    builder.Configuration.AddAzureKeyVault(keyVaultUri, new DefaultAzureCredential());
}

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration["DbConnectionString"]!);
});
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IListingServices, ListingServices>();
builder.Services.AddScoped<IBlobImageHandlingServices, BlobImageHandlingServices>();
builder.Services.AddScoped<IBlobStorageService, BlobStorageServices>();


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
