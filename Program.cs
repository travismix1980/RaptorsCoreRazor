using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RaptorsCoreRazor.Data;
namespace RaptorsCoreRazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<RaptorsCoreRazorContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RaptorsCoreRazorContext") ?? throw new InvalidOperationException("Connection string 'RaptorsCoreRazorContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}