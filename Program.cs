using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge10;
using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge8;
using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_1;
using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_2;
using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_3;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniCh8Service, MiniCh8Service>();
builder.Services.AddScoped<IMiniCh9_1Service, MiniCh9_1Service>();
builder.Services.AddScoped<IMiniCh9_2Service, MiniCh9_2Service>();
builder.Services.AddScoped<IMiniCh9_3Service, MiniCh9_3Service>();
builder.Services.AddScoped<IMiniCh10Service, MiniCh10Service>();

var app = builder.Build();

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
