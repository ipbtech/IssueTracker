using IssueTracker.DAL.Contracts;
using IssueTracker.DAL.Impl;
using IssueTracker.DAL.Impl.Repositories.Concrete;
using IssueTracker.Entities;
using IssueTracker.WebApp.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContextPool<IssueTrackerDbContext>(opt => opt.UseSqlite(connString));

builder.Services.AddIdentity<User, IdentityRole<int>>(opt => 
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequiredLength = 4;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireDigit = false;
}).AddEntityFrameworkStores<IssueTrackerDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";
});

builder.Services.AddAutoMapper(opt => opt.AddProfile<MappingProfile>());
builder.Services.AddScoped<IIssueRepository, IssueRepository>();
builder.Services.AddScoped<IRepository<Status>, StatusRepository>();
builder.Services.AddScoped<IRepository<Comment>, CommentRepository>();




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
