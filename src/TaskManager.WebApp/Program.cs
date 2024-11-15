using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManager.DAL.Impl;
using TaskManager.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContextPool<TaskManagerDbContext>(opt => opt.UseSqlite(connString));

builder.Services.AddIdentity<User, IdentityRole<int>>(opt => { })
    .AddEntityFrameworkStores<TaskManagerDbContext>();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";
});






var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<TaskManagerDbContext>();
}


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
