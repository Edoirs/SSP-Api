using SelfPortalAPi.NewTables;
using SelfPortalAPi;
using SelfPortalAPi.UnitOfWork;
using SelfPortalAPi.ErasModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string? conn = builder.Configuration.GetConnectionString("DefaultConnection");
string? connII = builder.Configuration.GetConnectionString("EirsContext");
string? connIII = builder.Configuration.GetConnectionString("ERASContext");

IConfiguration config = builder.Configuration;
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ErasContext>(opt => opt.UseSqlServer(connIII));
builder.Services.AddDbContext<ApiDbContext>(opt => opt.UseSqlServer(connII));
builder.Services.AddDbContextPool<PayeeContext>(opt => opt.UseSqlServer(conn));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IValidator<TokenRequest>, TokenRequestValidator>();
builder.Services.AddScoped<IIndividualRepository, IndividualRepository>();
builder.Services.AddScoped<IUtilityRepository, UtilityRepository>();
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseCors(options =>
options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
