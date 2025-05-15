using FristExersiceZhenic.Context;
using FristExersiceZhenic.Repository.Implimentation;
using FristExersiceZhenic.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
string? connection = builder.Configuration.GetConnectionString("MyZhenicConnection");
builder.Services.AddDbContext<MyZhenicDbContext>(option =>
option.UseSqlServer(connection));
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
//app.MapControllerRoute(name: "areas",    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "Paging", pattern: "{controller=home}/{action=Index}/{page?}");

app.Run();
