using EmployeeRateCard.Lib.Infrastucture;
using EmployeeRating.Lib.Core;
using EmployeeRating.Lib.Domain.Repositories.Implementaton;
using EmployeeRating.Lib.Domain.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSingleton<SqlDapperContext>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IRatecardRepository, RatecardRepository>();
builder.Services.AddScoped<ITimecardReposiory, TimecardReposiory>();
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
