using skillzshop.Models;

namespace skillzshop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Category
                if (!context.Category.Any())
                {
                    context.Category.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Food",
                            Description = "Share skillset related to Food"
                        },
                        new Category()
                        {
                            Name = "Music",
                            Description = "Share skillset related to Music"
                        },
                        new Category()
                        {
                            Name = "Communication",
                            Description = "Share skillset related to Communication"
                        }

                    });
                    context.SaveChanges();
                }

                //Skills
                if (!context.Skills.Any())
                {
                    context.Skills.AddRange(new List<Skills>()
                    {
                        new Skills()
                        {
                            Name = "Bread Making class",
                            Description = "I am a Professional chef and teach baking",
                            Price = 100,
                            CategoryId = 1

                        },
                        new Skills()
                        {
                            Name = "Pastry Making class",
                            Description = "I am a Professional chef and teach Pastries",
                            Price = 170,
                            CategoryId = 1

                        },
                        new Skills()
                        {
                            Name = "Cake Making class",
                            Description = "I am a Professional chef and teach backing cakes",
                            Price = 100,
                            CategoryId = 1
                        },
                        new Skills()
                        {
                            Name = "Acoustic Guitar playing",
                            Description = "I am a Professional Guitar player and teach Guitars",
                            Price = 150,
                            CategoryId = 2
                        },
                        new Skills()
                        {
                            Name = "Bass Guitar playing",
                            Description = "I am a Professional Guitar player and teach Bass guitars",
                            Price = 350,
                            CategoryId = 2
                        },
                        new Skills()
                        {
                            Name = "Lead Guitar playing",
                            Description = "I am a Professional Guitar player and teach Lead guitars",
                            Price = 50,
                            CategoryId = 2
                        },
                        new Skills()
                        {
                            Name = "Learn English",
                            Description = "I am an Language teacher and teach English",
                            Price = 90,
                            CategoryId = 3
                        },
                        new Skills()
                        {
                            Name = "Learn French",
                            Description = "I am an Language teacher and teach French",
                            Price = 190,
                            CategoryId = 3
                        }

                    });
                    context.SaveChanges();

                }

            }
        }
    }
}
