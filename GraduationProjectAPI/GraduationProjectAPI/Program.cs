using Microsoft.EntityFrameworkCore;
using GraduationProjectAPI.Data;

var builder = WebApplication.CreateBuilder(args);
//for migration
builder.Services.AddDbContext<GraduationProjectDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sqlServer")));
//for the swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.MapControllers();
//end swagger
app.Run();
