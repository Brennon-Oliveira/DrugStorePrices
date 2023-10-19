using DrugStorePrices.Domain;
using DrugStorePrices.Infra.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


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
NativeInjectorBootstrapper.RegisterServices(builder.Services);

var app = builder.Build();

app.MapControllers();

#region App Swagger configuration

app.UseSwagger();
app.UseSwaggerUI();

#endregion

#region Error handling configuration

app.UseExceptionHandler("/error");
app.UseStatusCodePagesWithReExecute("/error/{0}");

#endregion

app.Run();
