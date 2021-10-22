using FluentValidation.AspNetCore;
using NET6.CrossCutting.IoC;
using NET6.WEbapi2.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ModelsValidationFilter>();
builder.Services.AddControllers(e =>
{
    e.Filters.Add<ModelsValidationFilter>();
}).AddFluentValidation(e => e.RegisterValidatorsFromAssemblyContaining<ModelsValidationFilter>());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDomain();
builder.Services.AddInfra();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
