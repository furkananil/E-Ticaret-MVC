using Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RepositoryContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"), b => b.MigrationsAssembly("ETicaretApp"));
});

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
