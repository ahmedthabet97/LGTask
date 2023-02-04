using LinkedGatesTask.Services;
using Microsoft.EntityFrameworkCore;
using TaskDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<Context>(options => 
{
    options.UseLazyLoadingProxies()
        .UseSqlServer(builder.Configuration.GetConnectionString("DBKey"));
});
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddScoped<IPropertService, PropertyService>();


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
