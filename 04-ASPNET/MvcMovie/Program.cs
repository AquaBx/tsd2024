using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRecipe.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MvcRecipeContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcRecipeContext") ?? throw new InvalidOperationException("Connection string 'MvcRecipeContext' not found.")));
builder.Services.AddDbContext<MvcRecipeContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcRecipeContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MvcRecipeContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MvcRecipeContext")));
}
else
{
    builder.Services.AddDbContext<MvcRecipeContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMvcRecipeContext")));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
