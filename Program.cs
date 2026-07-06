using Microsoft.Extensions.WebEncoders.Testing;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Persistence.Repositores;
using GestionBiblioteca.Aplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositoryBooks, BookRepositoryInMemowy>();
builder.Services.AddScoped<IRepositoryLoans, LoanRepositryInMemory>();
builder.Services.AddScoped<IRepositoryProfessors, ProfessorRepositoryInMemory>();
builder.Services.AddScoped<IRepositoryStudents, StudentRepositoryInMemory>();
builder.Services.AddScoped<CreateProfessorService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
