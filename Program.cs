
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Persistence.Repositores;
using GestionBiblioteca.Aplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(options =>
{
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "GestionBiblioteca.xml"), includeControllerXmlComments: true);
    options.EnableAnnotations();
});

builder.Services.AddScoped<IRepositoryBooks, BookRepositoryInMemory>();
builder.Services.AddScoped<IRepositoryLoans, LoanRepositoryInMemory>();
builder.Services.AddScoped<IRepositoryProfessors, ProfessorRepositoryInMemory>();
builder.Services.AddScoped<IRepositoryStudents, StudentRepositoryInMemory>();

// Associated Services
builder.Services.AddScoped<CreateProfessorService>();
builder.Services.AddScoped<CreateStudentService>();
builder.Services.AddScoped<DeleteProfessorService>();
builder.Services.AddScoped<DeleteStudentService>();
builder.Services.AddScoped<SearchProfessorService>();
builder.Services.AddScoped<SearchStudentService>();
builder.Services.AddScoped<UpdateProfessorService>();
builder.Services.AddScoped<UpdateStudentService>();

// Book Services
builder.Services.AddScoped<CreateBookService>();
builder.Services.AddScoped<DeleteBookService>();
builder.Services.AddScoped<SearchBookService>();
builder.Services.AddScoped<UpdateBookService>();

// Loan Services
builder.Services.AddScoped<LendBookToProfessorService>();
builder.Services.AddScoped<LendBookToStudentService>();
builder.Services.AddScoped<ReturnBookService>();
builder.Services.AddScoped<SearchLoanService>();

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

// Manejo global de excepciones
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = 500;
        context.Response.ContentType = "application/json";
        
        var exceptionHandlerPathFeature = context.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerPathFeature>();
        var exception = exceptionHandlerPathFeature?.Error;
        
        var response = new 
        { 
            error = exception?.Message ?? "Error interno del servidor",
            details = app.Environment.IsDevelopment() ? exception?.StackTrace : null
        };
        
        await context.Response.WriteAsJsonAsync(response);
    });
});

//app.UseHttpsRedirection();

app.MapControllers();

app.Run();
