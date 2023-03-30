using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovies.Data;
using RazorPagesMovies.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesMoviesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMoviesContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesMoviesContext' not found.")));


var app = builder.Build();

// Context Manager Creates Default Data for Empty User
using(IServiceScope Scope = app.Services.CreateScope())
{
    IServiceProvider services = Scope.ServiceProvider;
    DefaultData.Init(services);
}
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
