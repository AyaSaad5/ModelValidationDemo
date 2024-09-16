using FluentValidation;
using FluentValidation.AspNetCore;
using ModelValidation.Models;
using ModelValidation.Services;
using ModelValidation.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//

//another way
builder.Services.AddControllers()
    .AddFluentValidationValidators();

//register fluent validation
builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<StoreRequestModelValidator>());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add FluentValidation validator
builder.Services.AddTransient<IValidator<StoreRequestModel>, StoreRequestModelValidator>();

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
