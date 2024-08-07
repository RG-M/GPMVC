using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ParcInformatique.Data;
using ParcInformatiqueWeb.IServices;
using ParcInformatiqueWeb.Service.cs;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Use Identity with roles (Custom AppUser to add more attributes to the user table)
builder.Services.AddIdentity<ApplicationContext, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUtilisateurService, UtilisateurService>();

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
