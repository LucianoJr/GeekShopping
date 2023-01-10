using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using GeekShopping.Web.Services.IServices;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IProductService, IProductService>(
    c => c.BaseAddress = new Uri(builder.Configuration["ServicesUrls:ProductAPI"])
);


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
