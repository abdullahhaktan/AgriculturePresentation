using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();

builder.Services.AddScoped<ITeamService, TeamManager>();
builder.Services.AddScoped<ITeamDal, EfTeamDal>();

builder.Services.AddScoped<IAddressService, AddressManager>();
builder.Services.AddScoped<IAddressDal, EfAddressDal>();

builder.Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
builder.Services.AddScoped<IAnnouncementService, AnnouncementManager>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<INavbarSlideService, NavbarSlideManager>();
builder.Services.AddScoped<INavbarSlideDal, EfNavbarSlideDal>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImageDal, EfImageDal>();

builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IAdminDal, EfAdminDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = "/Login/Index";
});

builder.Services.AddDbContext<AgricultureContext>();

builder.Services.AddIdentity<AppUser,AppRole>(opt=>
{
    opt.User.RequireUniqueEmail = true;

}).AddEntityFrameworkStores<AgricultureContext>();

builder.Services.AddControllersWithViews(opt =>
{
    opt.Filters.Add(new AuthorizeFilter());
});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
