using FluentAssertions.Common;
using INSFIT.Controllers;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
//OptionsBuilder.UseSqlServer(connectionString: @"Server=tcp:insfit.database.windows.net,1433;Initial Catalog=INSFIT;Persist Security Info=False;User ID=adm_insfit;Password={Semestre02@};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
