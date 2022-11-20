using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using skillzshop.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("DefaultConnectionString"));

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString.ConnectionString));
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//Seed Database
AppDbInitializer.Seed(app);
app.Run();
