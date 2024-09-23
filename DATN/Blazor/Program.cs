using Blazor;
using Blazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
<<<<<<< HEAD

builder.Services.AddScoped(option => new HttpClient { BaseAddress = new Uri("https://localhost:7170") });

=======
builder.Services.AddScoped(sp =>
new HttpClient { BaseAddress = new Uri("https://localhost:7170") });
>>>>>>> ff411c3dac364bb192d52cae239ca95ed8a3cc3b
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
