using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using xeroxFacil.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new() { Title = "XeroxFacil", Version = "v1" });
});

ConfigureMvc(builder);
ConfigureServices(builder);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();

static void ConfigureMvc(WebApplicationBuilder builder)
{
    builder.Services.AddControllers().ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; }).AddJsonOptions(x =>
    {
        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
    });
}

static void ConfigureServices(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<AppDataContext>(options => options.UseSqlServer(connectionString));
}