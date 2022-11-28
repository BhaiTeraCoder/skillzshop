using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using skillzshop.Data;
using Microsoft.AspNetCore.Identity;
using skillzshop.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("DefaultConnectionString"));
var connectionStringAuth = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("skillzshopUserDbContextConnection"));

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString.ConnectionString));

builder.Services.AddDbContext<skillzshopUserDbContext>(options => options.UseSqlServer(connectionStringAuth.ConnectionString));
builder.Services.AddDefaultIdentity<skillzshopUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<skillzshopUserDbContext>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

//Seed Database
AppDbInitializer.Seed(app);
app.Run();
