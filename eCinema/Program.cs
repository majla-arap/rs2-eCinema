using eCinema.Services.Database;
using eCinema.Services;
using eCinema.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using eCinema;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
    x.Filters.Add<ErrorFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<eCinemaContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IUlogaService, UlogaService>();
builder.Services.AddTransient<IKorisnikService, KorisnikService>();
builder.Services.AddTransient<IKorisnikUlogeService, KorisnikUlogeService>();
builder.Services.AddTransient<IGlumacService, GlumacService>();
builder.Services.AddTransient<IObavijestKategorijaService, ObavijestKategorijaService>();
builder.Services.AddTransient<IObavijestService, ObavijestService>();
builder.Services.AddTransient<IZanrService, ZanrService>();
builder.Services.AddTransient<ICinemaService, CinemaService>();
builder.Services.AddTransient<IDvoranaService, DvoranaService>();
builder.Services.AddTransient<IFilmService, FilmService>();
builder.Services.AddTransient<IFilmZanrService, FilmZanrService>();
builder.Services.AddTransient<IFilmGlumacService, FilmGlumacService>();
builder.Services.AddTransient<ITerminService, TerminService>();
builder.Services.AddTransient<IKartaService, KartaService>();
builder.Services.AddTransient<IKupovinaService, KupovinaService>();

builder.Services.AddTransient<StripeService>();

builder.Services.AddAutoMapper(typeof(IAuthService));
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    string? connection = app.Configuration.GetConnectionString("DefaultConnection");
    var dataContext = scope.ServiceProvider.GetRequiredService<eCinemaContext>();
    dataContext.Database.Migrate();
}

app.Run();

