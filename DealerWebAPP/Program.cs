using DealerWebApp.DealertWeb.Aplication.Data.DDBB;
using DealerWebApp.DealertWeb.Aplication.Data.Repository;
using DealerWebApp.DealertWeb.Aplication.Interfaces.Services;
using DealerWebApp.DealertWeb.Aplication.IoC;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

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
    pattern: "{controller=Portada}/{action=Index}/{id?}");

app.Run();


builder.Services.AddScoped(typeof(IContactosService), typeof(ContactosService));

//builder.Services.AddDealerServices(); //Llamada al IoCExtension para utilizar los servicio

builder.Services.AddRazorPages();

builder.Services.AddMvcCore();

builder.Services.AddControllers();

builder.Services.AddHttpContextAccessor();

builder.Services.AddMvc();




//builder.Services.AddTransient(typeof(IContactosService), typeof(ContactosService));

