using Microsoft.EntityFrameworkCore;
using prototype.Persistence.Data;
using prototype.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var options = new DbContextOptionsBuilder<AppDbContext>().UseNpgsql("Host=localhost;Port=5433;Database=musictest;Username=postgres;Password=1234").Options;
builder.Services.AddPersistence(options);


var app = builder.Build();


DbInitializer
.Initialize(builder.Services.BuildServiceProvider())
.Wait();


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

app.Run();

