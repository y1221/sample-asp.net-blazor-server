using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SampleBlazorApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(); // Razor Pages�@�\�ǉ�
builder.Services.AddServerSideBlazor(); // Blazor Server�@�\�ǉ�
builder.Services.AddSingleton<WeatherForecastService>();

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

// Blazor�̃��[�e�B���O�֌W���Z�b�g�A�b�v
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
