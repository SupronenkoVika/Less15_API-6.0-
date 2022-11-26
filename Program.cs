using Less15_API_6._0_;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ServerSettings>(builder.Configuration.GetSection("GeneralSettings"));
builder.Services.AddHealthChecks();
builder.Services.AddTransient<RoomService>();

var app = builder.Build();

app.MapGet("/", (RoomService service) => service.GetDescription());
app.Run();
