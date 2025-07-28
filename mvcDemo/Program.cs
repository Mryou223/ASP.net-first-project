
 // Update this namespace to match your project structure
using Microsoft.EntityFrameworkCore;
using mvcDemo.Models;

// Remove or update the following using directive to fix CS0246:
// Update the using directive to match the actual namespace where ClinicContext is defined.
// For example, if ClinicContext is in the 'mvcDemo.Clinic' namespace, use:


// Remove or update the following using directive to fix CS0246:
// using ConsoleApp1.Clinic;
// using ConsoleApp1.Clinic;

// If your DbContext is defined in a different namespace, update the using directive accordingly.
// For example, if your context is in 'mvcDemo.Clinic', use:
// using mvcDemo.Clinic;

// If you are unsure of the correct namespace, please provide the file and namespace where 'ClinicContext' is defined.
var builder = WebApplication.CreateBuilder(args);


var connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ClinicContext>(options => options.UseSqlServer(connString));

// Add services to the container.
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

app.Run();