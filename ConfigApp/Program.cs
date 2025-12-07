var builder = WebApplication.CreateBuilder(args);

builder.Configuration.Sources.Clear(); // Clear default configuration sources
builder.Configuration.AddJsonFile("appsettings.json", optional: true); // Add JSON configuration source
var app = builder.Build();

app.MapGet("/", (IConfiguration config) => config.AsEnumerable());

app.Run();

var zoomLevel = builder.Configuration["MapSettings:DefaultZoomLevel"];
var latitude = builder.Configuration["MapSettings:DefaultLocation:Latitude"];

// Alternatively, using GetSection method
var lat = builder.Configuration.GetSection("MapSettings")["DefaultLocation:Latitude"];