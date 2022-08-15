using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using IgniteUI.Blazor.Controls;
using HolyGrailGridsLocalEndPoint;
using HolyGrailGridsLocalEndPoint.NortwindSwagger;
using HolyGrailGridsLocalEndPoint.Northwind;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

builder.Services.AddScoped<NortwindSwaggerService>();
builder.Services.AddScoped<NorthwindService>();

RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
        typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
        typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
        typeof(IgniteUI.Blazor.Controls.IgbDataGridModule)
    );
}

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
