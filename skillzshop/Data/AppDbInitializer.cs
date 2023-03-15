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
                            Name = "Data Engineering",
                            Description = "Share skillset related to Data Engineering"
                        },
                        new Category()
                        {
                            Name = "AI",
                            Description = "Share skillset related to AI"
                        },
                        new Category()
                        {
                            Name = "Coding",
                            Description = "Share skillset related to Coding"
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
                            Name = "Python class",
                            Description = "I am a Professional developer and teach python",
                            SellerName = "John",
                            Rating = 5,
                            Price = 100,
                            CategoryId = 1

                        },
                        new Skills()
                        {
                            Name = "Elasticsearch class",
                            Description = "I am a Professional data engineer and teach ELK",
                            SellerName = "Michelle Smith",
                            Rating = 5,
                            Price = 170,
                            CategoryId = 1

                        },
                        new Skills()
                        {
                            Name = "Kibana class",
                            Description = "I am a Professional Data Scientist and teach Kibana",
                            SellerName = "Mike Turner",
                            Rating = 3,
                            Price = 100,
                            CategoryId = 1
                        },
                        new Skills()
                        {
                            Name = "AI Algo playing",
                            Description = "I am a Professional ML engineer and teach algorithms",
                            SellerName = "Sam Client",
                            Rating = 2,
                            Price = 150,
                            CategoryId = 2
                        },
                        new Skills()
                        {
                            Name = "Chatgpt basics",
                            Description = "I am a Professional AI engineer",
                            SellerName = "Tin Stone",
                            Rating = 4,
                            Price = 350,
                            CategoryId = 2
                        },
                        new Skills()
                        {
                            Name = "Linear regression",
                            Description = "I am a Professional ML engineer",
                            SellerName = "Sandy Colleen",
                            Rating = 4,
                            Price = 50,
                            CategoryId = 2
                        },
                        new Skills()
                        {
                            Name = "Learn Java",
                            Description = "I am an software developer and teach Java",
                            SellerName = "Trisha Jane",
                            Rating = 3,
                            Price = 90,
                            CategoryId = 3
                        },
                        new Skills()
                        {
                            Name = "Learn C#",
                            Description = "I am an software developer and teach C#",
                            SellerName = "Felix Dane",
                            Rating = 2,
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
