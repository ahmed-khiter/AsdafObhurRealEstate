using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Wkhtmltopdf.NetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AsdafObhurContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.Configure<IdentityOptions>(options =>
    options.ClaimsIdentity.UserIdClaimType = ClaimTypes.NameIdentifier);

builder.Services.AddWkhtmltopdf();

builder.Services.AddIdentity<BaseUser, IdentityRole>(
              options =>
              {
                  options.Password.RequireDigit = false;
                  options.Password.RequireUppercase = false;
                  options.Password.RequiredUniqueChars = 0;
                  options.Password.RequireLowercase = false;
                  options.Password.RequireNonAlphanumeric = false;
              })
              .AddEntityFrameworkStores<AsdafObhurContext>()
              .AddDefaultTokenProviders();

builder.Services.AddScoped<IUserClaimsPrincipalFactory<BaseUser>, ApplicationClaimsIdentityFactory>();
builder.Services.AddSingleton(typeof(FileManager));



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
