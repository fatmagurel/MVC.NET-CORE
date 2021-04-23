using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                ProjectContext context = serviceScope.ServiceProvider.GetService<ProjectContext>();
                //Proje her çalıştırıldığında bekleyen migrationlara göre DB yi güncelleyecek...
                context.Database.Migrate();
                //products ta herhangi bir şey yoksa
                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product() { ProductName = "Vişne", Price = 19, Category = "Meyveler" },
                        new Product() { ProductName = "Kiraz", Price = 12, Category = "Meyveler" },
                        new Product() { ProductName = "Ispanak", Price = 5, Category = "Sebzeler" },
                        new Product() { ProductName = "Havuç", Price = 3, Category = "Sebzeler" },
                        new Product() { ProductName = "Leblebi", Price = 16, Category = "Kuruyemişler" },
                        new Product() { ProductName = "Fındık", Price = 76, Category = "Kuruyemişler" }
                        );
                }
                context.SaveChanges();
            }
        }
    }
}
