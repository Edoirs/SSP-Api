
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//string? conn = builder.Configuration.GetConnectionString("DefaultConnection");
//string? connII = builder.Configuration.GetConnectionString("EirsContext");
//string? connIII = builder.Configuration.GetConnectionString("ERASContext");
AllFunction all = new();
all.ConfigureServices(builder);
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/V1/swagger.json", "Self Service Portal WebAPI");
});

app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(options =>
options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowedToAllowWildcardSubdomains());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
