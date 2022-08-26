using BookStoreApi.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("BookStoreAppDBConnection");


builder.Services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(connString));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//Middle-ware section
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseSerilog((ctx,lc)=>lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
builder.Services.AddCors(optons => {
    optons.AddPolicy("AllowAll",b=>
    b.AllowAnyMethod()
    .AllowAnyHeader()
    .AllowAnyOrigin());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
