using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace MvcCake.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCakeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCakeContext>>()))
            {
                // Look for any movies.
                if (context.Cake.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cake.AddRange(
                    new Cake
                    {
                        ProductName = "Birthday1 Cake",
                        ProductionDate = DateTime.Parse("2021-10-10"),
                        Comment = "Chocolate cake with chocolate mouse",
                        Weight = 5,
                        Price = 7.99M
                    },

                    new Cake
                    {
                        ProductName = "Wedding Cake",
                        ProductionDate = DateTime.Parse("2021-2-12"),
                        Comment = "3 tires Chocolate cake with chocolate mouse",
                        Weight = 2,
                        Price = 20
                    },

                    new Cake
                    {
                        ProductName = "Halloween Cookie",
                        ProductionDate = DateTime.Parse("2021-09-12"),
                        Comment = "Vanilla Cookie",
                        Weight = 1,
                        Price =300
                    },

                    new Cake
                    {
                        ProductName = "birthday2 Cake",
                        ProductionDate = DateTime.Parse("2021-10-01"),
                        Comment = "vanilla cake",
                        Weight = 5,
                        Price = 380
                    },

                    new Cake
                    {
                        ProductName = "wedding2 Cake",
                        ProductionDate = DateTime.Parse("2021-10-01"),
                        Comment = "chocolate cake",
                        Weight = 1,
                        Price = 200
                    },


                    new Cake
                    {
                        ProductName = "birthday3 Cake",
                        ProductionDate = DateTime.Parse("2021-10-01"),
                        Comment = "vanilla cake",
                        Weight = 2,
                        Price = 290
                    },


                    new Cake
                    {
                        ProductName = "breakfast1 Cake",
                        ProductionDate = DateTime.Parse("2021-10-01"),
                        Comment = "carret cake",
                        Weight = 5,
                        Price = 278
                    },


                    new Cake
                    {
                        ProductName = "breakfast2 Cake",
                        ProductionDate = DateTime.Parse("2021-10-01"),
                        Comment = "chocolate cake",
                        Weight = 5,
                        Price = 380
                    },


                    new Cake
                    {
                        ProductName = "breakfast3 Cake",
                        ProductionDate = DateTime.Parse("2021-10-01"),
                        Comment = "vanilla cake",
                        Weight = 1,
                        Price = 380
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
