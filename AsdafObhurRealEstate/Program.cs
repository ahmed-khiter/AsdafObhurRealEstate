using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using AsdafObhurRealEstate.Services.AccountManagement;
using AsdafObhurRealEstate.Services.Clients;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Net;
using System.Security.Claims;
using Wkhtmltopdf.NetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ClientService>();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);



builder.Services.AddDbContext<AsdafObhurContext>(options =>
{
    //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    //options.UseMySql(connectionString,
    //    ServerVersion.AutoDetect(connectionString));
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddHttpContextAccessor();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.ClaimsIdentity.UserIdClaimType = ClaimTypes.NameIdentifier;
    options.ClaimsIdentity.RoleClaimType = ClaimTypes.Role;
    options.ClaimsIdentity.EmailClaimType = ClaimTypes.Email;

}) ;

builder.Services.AddWkhtmltopdf();

builder.Services.AddIdentity<BaseUser, IdentityRole>(
              options =>
              {
                  options.Password.RequireDigit = false;
                  options.Password.RequireUppercase = false;
                  options.Password.RequiredUniqueChars = 0;
                  options.Password.RequireLowercase = false;
                  options.Password.RequireNonAlphanumeric = false;
              }).AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<AsdafObhurContext>();

builder.Services.AddScoped<AccountService>();

builder.Services.AddSingleton(typeof(FileManager));
builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped<WhatsAppsSender>();



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");



app.Run();
