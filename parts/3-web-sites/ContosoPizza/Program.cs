using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// "Data Source=localhost;Database=ContosoPizza;Integrated Security=false;User ID=sa;Password=P@ssw0rd;"
builder.Services.AddDbContext<ContosoPizzaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContosoPizza")));

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
app.UseAuthorization();
app.MapRazorPages();
app.Run();
