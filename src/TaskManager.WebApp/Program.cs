using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManager.DAL.Contracts;
using TaskManager.DAL.Impl;
using TaskManager.DAL.Impl.Repositories;
using TaskManager.Entities;
using TaskManager.WebApp.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContextPool<TaskManagerDbContext>(opt => opt.UseSqlite(connString));

builder.Services.AddIdentity<User, IdentityRole<int>>(opt => 
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequiredLength = 4;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireDigit = false;
})
    .AddEntityFrameworkStores<TaskManagerDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";
});

builder.Services.AddAutoMapper(opt => opt.AddProfile<MappingProfile>());
builder.Services.AddScoped<IWorkTaskRepository, WorkTaskRepository>();
builder.Services.AddScoped<IRepository<WorkTaskStatus>, WorkTaskStatusesRepository>();
builder.Services.AddScoped<IRepository<WorkTaskComment>, WorkTaskCommentRepository>();




var app = builder.Build();

//app.UseExceptionHandler("/Home/Error");
app.UseHsts();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");

app.Run();

public partial class Program { } // for integration tests 
