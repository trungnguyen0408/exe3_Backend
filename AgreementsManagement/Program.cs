using AgreementsManagement.Business.Service;
using AgreementsManagement.Data.EF;
using AgreementsManagement.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAgreementService, AgreementService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAgreementRepository, AgreementRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddDbContext<AgreementsManagementDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AgreementsManagementDb")));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
