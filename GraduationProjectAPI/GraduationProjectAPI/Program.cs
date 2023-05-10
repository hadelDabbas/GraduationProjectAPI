using GraduationProjectAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using GraduationProjectAPI.Data;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;
using GraduationProjectAPI.Helper;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers().AddJsonOptions(config => {
    config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    config.JsonSerializerOptions.Converters.Add(new ByteArrayConvertercs());
    config.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

//for migration
builder.Services.AddDbContext<GraduationProjectDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sqlServer")));
builder.Services.AddTransient<IBook, BookRepo>();
builder.Services.AddTransient<IBookLibrarycs, BookLibraryRepo>();
builder.Services.AddTransient<IBookType, BookTypeRepo>();
builder.Services.AddTransient<IBookWriter, BookWriterRepo>();
builder.Services.AddTransient<IBuybook, BuybookRepo>();
builder.Services.AddTransient<IComment, CommentRepo>();
builder.Services.AddTransient<IComplaint, ComplaintRepo>();
builder.Services.AddTransient<IFollow, FollowRepo>();
builder.Services.AddTransient<IGame, GameRepo>();
builder.Services.AddTransient<IGameUser, GameUserRepo>();
builder.Services.AddTransient<IGroup, GroupRepo>();
builder.Services.AddTransient<ILibrary, LibraryRepo>();
builder.Services.AddTransient<IPost, PostRepo>();
builder.Services.AddTransient<IReference, ReferenceRepo>();
builder.Services.AddTransient<ITest, TestRepo>();
builder.Services.AddTransient<IType, TypeRepo>();
builder.Services.AddTransient<IUserPost, UserPostRepo>();
builder.Services.AddTransient<IUserReference, UserReferenceRepo>();
builder.Services.AddTransient<IUser, UserRepo>();
builder.Services.AddTransient<IWriter, WriterRepo>();
//for the swagger
builder.Services.AddSignalR().AddJsonProtocol(x => x.PayloadSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseCors(builder =>
    builder
        .WithOrigins("https://localhost:7252/")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed(_ => true)
        .AllowCredentials());
app.MapControllers();
//app.UseEndpoints(endpoints => {
//    endpoints.MapControllerRoute(
  //     name: "default",
    //   pattern: "{controller=Home}/{action=Index}/{id?}");
   // endpoints.MapHub<ManagementHub>("/management-hub");
//});
//end swagger
app.Run();
