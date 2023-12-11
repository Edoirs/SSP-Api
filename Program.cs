
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SelfPortalAPi.NewTables;
using SelfPortalAPi;
using SelfPortalAPi.UnitOfWork;
using SelfPortalAPi.ErasModel;
using SelfPortalAPi.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string? conn = builder.Configuration.GetConnectionString("DefaultConnection");
string? connII = builder.Configuration.GetConnectionString("EirsContext");
string? connIII = builder.Configuration.GetConnectionString("ERASContext");


IConfiguration config = builder.Configuration;
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthentication(opt => {
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration.GetSection("JWT:ValidIssuer").Value,
            ValidAudience = builder.Configuration.GetSection("JWT:ValidAudience").Value,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT:Secret").Value))
    };
});
builder.Services.AddDbContext<ErasContext>(opt => opt.UseSqlServer(connIII));
builder.Services.AddDbContext<ApiDbContext>(opt => opt.UseSqlServer(connII));
builder.Services.AddDbContextPool<PayeeContext>(opt => opt.UseSqlServer(conn));
builder.Services.AddDbContext<EirsContext>(opt => opt.UseSqlServer(connIII));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IValidator<TokenRequest>, TokenRequestValidator>();
builder.Services.AddScoped<IIndividualRepository, IndividualRepository>();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IUtilityRepository, UtilityRepository>();
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("V1", new OpenApiInfo {
        Version = "V1",
            Title = "Self Service API",
            Description = "WebAPI"
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
        Scheme = "Bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Name = "Authorization",
            Description = "Bearer Authentication with JWT Token",
            Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                }
            },
            new List < string > ()
        }
    });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "Product WebAPI");
    });
}
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
