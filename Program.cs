using Dapper;
using HRWebAPI.Services; //Entity yerine dapper kullan?yoruz

var builder = WebApplication.CreateBuilder(args);
DefaultTypeMap.MatchNamesWithUnderscores = true;

builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IUsersInformationService, UsersInformationService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// CORS policy ismi
var myCorsPolicy = "MyCorsPolicy";

// CORS politikas?n? ekle
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myCorsPolicy,
                      policy =>
                      {
                          policy.WithOrigins("https://ik-basvuru.fabitech.com.tr/")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
