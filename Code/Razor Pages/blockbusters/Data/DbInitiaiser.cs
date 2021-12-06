using blockbusters.Models;
using System;
using System.Linq;

namespace blockbusters.Data
{
    public static class DbInitiaiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddPayments(context);
            AddPeople(context);
            AddPeopleReviews(context);
            AddMovies(context);
            AddOrder(context);
            AddOrderItems(context);
        }

        private static void AddPeople(ApplicationDbContext context)
        {
            if (context.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {

                new Person{Email="bob14@email.com",FirstName="Bob",LastName = "Smith",StaffAccount=false},
                new Person{Email="Ruairi412@email.com",FirstName="Ruairi",LastName="Hawes",StaffAccount=false},
                new Person{Email="Millie635@email.com",FirstName="Millie",LastName="Storey",StaffAccount=false},
                new Person{Email="Carys45@email.com",FirstName="Carys",LastName="Brock",StaffAccount=false},
                new Person{Email="Priyanka4532@email.com",FirstName="Priyanka",LastName="Parkes",StaffAccount=true},
                new Person{Email="Arnold3578@email.com",FirstName="Arnold",LastName="Carys",StaffAccount=false},
                new Person{Email="Renesmae567@email.com",FirstName="Renesmae",LastName="Chen",StaffAccount=false},
                new Person{Email="Joe9@email.com",FirstName="Joe",LastName="Byren",StaffAccount=true},
                new Person{Email="Mark54@email.com",FirstName="Mark",LastName="Mil",StaffAccount=false},
                new Person{Email="Korban234@email.com",FirstName="Korban",LastName="Melendez",StaffAccount=false}
            };

            context.People.AddRange(people);
            // context.SaveChanges();
        }

        private static void AddPeopleReviews(ApplicationDbContext context)
        {
            if (context.PeopleReviews.Any())
            {
                return;   // DB has been seeded
            }

            var peopleReviews = new PersonReview[]
            {

                new PersonReview{ReviewDate=new DateTime(2021, 6, 7, 12, 43, 12), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2021, 3, 24, 19, 23, 45), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2016, 7, 22, 23, 20, 23), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2021, 2, 18, 22, 45, 53), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2021, 4, 15, 23, 11, 1), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2018, 8, 12, 8, 16, 43), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2020, 12, 4, 5, 12, 20), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2019, 8, 2, 1, 41, 44),ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2019, 4, 12, 18, 22, 21), ReviewText="", Likes=0},
                new PersonReview{ReviewDate=new DateTime(2019, 7, 5, 9, 11, 50), ReviewText="", Likes=0}
            };

            context.PeopleReviews.AddRange(peopleReviews);
            // context.SaveChanges();
        }

        private static void AddPayments(ApplicationDbContext context)
        {
            if (context.Payments.Any())
            {
                return;   // DB has been seeded
            }

            var payments = new Payment[]
            {
                new Payment{CardholderName="Bob Smith",CardNumber="1317605192083077",ExpirationDate = "1024",CCV="234"},
                new Payment{CardholderName="Ruairi Hawes",CardNumber="7040111525431560",ExpirationDate = "0926",CCV="563"},
                new Payment{CardholderName="Tom Storey",CardNumber="1382462212808082",ExpirationDate = "1022",CCV="635"},
                new Payment{CardholderName="Carys Brock",CardNumber="8492989781612922",ExpirationDate = "0823",CCV="453"},
                new Payment{CardholderName="Eddie Small",CardNumber="4526505824970589",ExpirationDate = "0523",CCV="412"},
                new Payment{CardholderName="Harry Carys",CardNumber="4571907661228074",ExpirationDate = "0224",CCV="636"},
                new Payment{CardholderName="Renesmae Chen",CardNumber="1290197277817382",ExpirationDate = "0524",CCV="787"},
                new Payment{CardholderName="Micheal Send",CardNumber="2210212951863207",ExpirationDate = "1126",CCV="435"},
                new Payment{CardholderName="Mark Mil",CardNumber="2283042845312800",ExpirationDate = "0927",CCV="414"},
                new Payment{CardholderName="Morgan Melendez",CardNumber="6932169416201862",ExpirationDate = "0123",CCV="448"}
            };

            context.Payments.AddRange(payments);
            // context.SaveChanges();
        }

        private static void AddOrder(ApplicationDbContext context)
        {
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }

            var orders = new Order[]
            {

                new Order{OrderDate=new DateTime(2020, 12, 4, 5, 12, 20),Completed=true},
                new Order{OrderDate=new DateTime(2018, 8, 12, 8, 16, 43),Completed=false},
                new Order{OrderDate=new DateTime(2016, 7, 22, 23, 20, 23),Completed=false},
                new Order{OrderDate=new DateTime(2019, 8, 2, 1, 41, 44),Completed=true},
                new Order{OrderDate=new DateTime(2019, 7, 5, 9, 11, 50),Completed=false},
                new Order{OrderDate=new DateTime(2019, 4, 12, 18, 22, 21),Completed=false},
                new Order{OrderDate=new DateTime(2021, 6, 7, 12, 43, 12),Completed=false},
                new Order{OrderDate=new DateTime(2021, 3, 24, 19, 23, 45),Completed=true},
                new Order{OrderDate=new DateTime(2021, 2, 18, 22, 45, 53),Completed=false},
                new Order{OrderDate=new DateTime(2021, 4, 15, 23, 11, 1),Completed=false}
            };

            context.Orders.AddRange(orders);
            // context.SaveChanges();
        }

        private static void AddOrderItems(ApplicationDbContext context)
        {
            if (context.OrderItems.Any())
            {
                return;   // DB has been seeded
            }

            var orderItems = new OrderItem[]
            {

                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
                new OrderItem{SalePrice=12.99m},
            };

            context.OrderItems.AddRange(orderItems);
            // context.SaveChanges();
        }

        private static void AddMovies(ApplicationDbContext context)
        {
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var movies = new Movie[]
            {
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="",
                    Description="",
                    ReleaseDate=new DateTime(2021, 12, 31),
                    LeadingDirector="",
                    LeadingProducer="",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
            };

            context.Movies.AddRange(movies);
            // context.SaveChanges();
        }
    }
}
