using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RCA_Asigurari.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy =>
   policy.RequireRole("Admin"));
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RCA_AsigurariContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RCA_AsigurariContext") ?? throw new InvalidOperationException("Connection string 'RCA_AsigurariContext' not found.")));


builder.Services.AddDbContext<LibraryIdentityContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("RCA_AsigurariContext") ?? throw new InvalidOperationException("Connection string 'RCA_AsigurariContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
options.SignIn.RequireConfirmedAccount = true)
     .AddRoles<IdentityRole>()

 .AddEntityFrameworkStores<LibraryIdentityContext>();




//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<LibraryIdentityContext>();

//builder.Services.AddDbContext<LibraryIdentityContext>(options =>
// options.UseSqlServer(builder.Configuration.GetConnectionString("RCA_AsigurariContext") ?? throw new InvalidOperationException("Connection string 'RCA_AsigurariContext' not found.")));

//builder.Services.AddDefaultIdentity<IdentityUser>(options =>
//options.SignIn.RequireConfirmedAccount = true)
//    .AddRoles<IdentityRole>()
// .AddEntityFrameworkStores<LibraryIdentityContext>();



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
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();