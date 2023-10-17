using DrugStorePrices.Api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

NativeInjectorBootstrapper.RegisterServices(builder.Services);

#region Builder Controllers configuration
builder.Services.AddControllers();
#endregion

#region Builder Database configuration
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=app.db"));
#endregion


#region Builder Swagger configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "DrugStorePrices.Api", Version = "v1" });
});
#endregion

var app = builder.Build();

app.MapControllers();

#region App Swagger configuration
app.UseSwagger();
app.UseSwaggerUI();
#endregion

app.Run();
