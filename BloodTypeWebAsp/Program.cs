using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BloodTypeWeb.Data; 
using System;
using BloodTypeWeb.Areas.Identity.Data;
using BloodTypeWeb.Interfaces;
using BloodTypeWeb.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BloodTypeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BloodTypeDbContextConnection") ?? throw new InvalidOperationException("Connection string 'BloodTypeDbContextConnection' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IBloodTypeCalculator, BloodTypeCalculator>();
builder.Services.AddScoped<ICalculateRhFactor, CalculateRhFactor>();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount=false)
    .AddEntityFrameworkStores<BloodTypeDbContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

