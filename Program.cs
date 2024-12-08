using Microsoft.EntityFrameworkCore;
using PetAsp.Data;

internal class Program
{
    /**
     * Jó helyre írom a IServiceCollection.AddControllers-t?
     * VS2022 says: Please add all the required services by calling 'IServiceCollection.AddControllers' inside the call to 'ConfigureServices(...)' in the application startup code.'
    */

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Adds services to the container.
        builder.Services.AddControllers();
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<PetContext>(options =>
            options.UseSqlite("Data Source=pets.db"));
        builder.Services.AddAuthorization();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();

    }
}