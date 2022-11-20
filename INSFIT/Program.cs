using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using INSFIT.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.IIS;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<INSFITContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("INSFITContext") ?? throw new InvalidOperationException("Connection string 'INSFITContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

 void ConfigureServices(IServiceCollection services) {

    services.Configure<CookiePolicyOptions>(options =>
    {
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
    });

    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
        {
            options.AccessDeniedPath = "/Cadastro/AccessDenied";
            options.LoginPath = "/Cadastro/Login";
        });
    services.AddControllersWithViews();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthorization();
app.UseAuthentication();


app.UseCookiePolicy();

app.UseAuthentication();

app.UseCookiePolicy();  

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
