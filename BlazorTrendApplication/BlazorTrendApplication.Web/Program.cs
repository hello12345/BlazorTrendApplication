using BlazorTrendApplication.Web.Data;
using BlazorTrendApplication.Web.Interfaces;
using BlazorTrendApplication.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddSingleton<Mapper>();
builder.Services.AddScoped<GlobalService>();
builder.Services.AddHttpClient<ITrendService, TrendService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BaseURL"]);
});

builder.Services.AddHttpClient<IUserMasterService, UserMasterService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BaseURL"]);
});
builder.Services.AddBlazorise(options => {
    options.ChangeSliderOnHold = true;
}).AddBootstrapProviders().AddFontAwesomeIcons();

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
app.UseAuthentication();
app.UseAuthorization();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
