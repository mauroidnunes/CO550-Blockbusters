﻿using blockbusters.Models;
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

                new Person
                {
                    Email="bob14@email.com",
                    FirstName="Bob",
                    LastName = "Smith",
                    StaffAccount=false,
                    PaymentID = 1
                },
                new Person
                {Email="Ruairi412@email.com",FirstName="Ruairi",LastName="Hawes",StaffAccount=false, PaymentID = 2},
                new Person{Email="Millie635@email.com",FirstName="Millie",LastName="Storey",StaffAccount=false, PaymentID = 3},
                new Person{Email="Carys45@email.com",FirstName="Carys",LastName="Brock",StaffAccount=false, PaymentID = 4},
                new Person{Email="Priyanka4532@email.com",FirstName="Priyanka",LastName="Parkes",StaffAccount=true, PaymentID = 5},
                new Person{Email="Arnold3578@email.com",FirstName="Arnold",LastName="Carys",StaffAccount=false, PaymentID = 6},
                new Person{Email="Renesmae567@email.com",FirstName="Renesmae",LastName="Chen",StaffAccount=false, PaymentID = 7},
                new Person{Email="Joe9@email.com",FirstName="Joe",LastName="Byren",StaffAccount=true, PaymentID = 8},
                new Person{Email="Mark54@email.com",FirstName="Mark",LastName="Mil",StaffAccount=false, PaymentID = 9},
                new Person{Email="Korban234@email.com",FirstName="Korban",LastName="Melendez",StaffAccount=false, PaymentID = 10}
            };

            context.People.AddRange(people);
            context.SaveChanges();
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
             context.SaveChanges();
        }

        private static void AddOrder(ApplicationDbContext context)
        {
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }

            var orders = new Order[]
            {

                new Order{OrderDate=new DateTime(2020, 12, 4, 5, 12, 20),Completed=true, PersonID = 1}, 
                new Order{OrderDate=new DateTime(2018, 8, 12, 8, 16, 43),Completed=false, PersonID = 1},
                new Order{OrderDate=new DateTime(2016, 7, 22, 23, 20, 23),Completed=false, PersonID = 2},
                new Order{OrderDate=new DateTime(2019, 8, 2, 1, 41, 44),Completed=true, PersonID = 3},
                new Order{OrderDate=new DateTime(2019, 7, 5, 9, 11, 50),Completed=false, PersonID = 3},
                new Order{OrderDate=new DateTime(2019, 4, 12, 18, 22, 21),Completed=false, PersonID = 4},
                new Order{OrderDate=new DateTime(2021, 6, 7, 12, 43, 12),Completed=false, PersonID = 5},
                new Order{OrderDate=new DateTime(2021, 3, 24, 19, 23, 45),Completed=true, PersonID = 6},
                new Order{OrderDate=new DateTime(2021, 2, 18, 22, 45, 53),Completed=false, PersonID = 7},
                new Order{OrderDate=new DateTime(2021, 4, 15, 23, 11, 1),Completed=false, PersonID = 8}
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
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
                    Title="Interstellar",
                    Description="A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    ReleaseDate=new DateTime(2014, 10, 29),
                    LeadingDirector="Christopher Nolan",
                    LeadingProducer="Christopher Nolan",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Harry Potter and the Prisoner of Azkaban",
                    Description="Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, " +
                    "where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard.",
                    ReleaseDate=new DateTime(2004, 05, 31),
                    LeadingDirector="Alfonso Cuarón",
                    LeadingProducer="Chris Columbus",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Khuda Kay Liye",
                    Description="A drama about three stories centered on the effects of extremism and 9/11 on Pakistanis.",
                    ReleaseDate=new DateTime(2007, 11, 02),
                    LeadingDirector="Shoaib Mansoor",
                    LeadingProducer="Shoaib Mansoor",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Mah E Mir",
                    Description="A modern poet Jamal who is against the traditional Urdu Poetry reads the biography of Mir Taqi Mir, " +
                    "one of the greatest poets of the 18th century. And sees Mir's reflection on his personality.",
                    ReleaseDate=new DateTime(2016, 05, 06),
                    LeadingDirector="Anjum Shahzad",
                    LeadingProducer="Badar Ikram",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Howl's Moving Castle",
                    Description="When an unconfident young woman is cursed with an old body by a spiteful witch, her only chance of breaking the spell lies with a self-indulgent yet insecure" +
                    " young wizard and his companions in his legged, walking castle.",
                    ReleaseDate=new DateTime(2005, 09, 23),
                    LeadingDirector="Hayao Miyazaki",
                    LeadingProducer="Rick Dempsey",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Avengers: Endgame",
                    Description="After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies," +
                    " the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                    ReleaseDate=new DateTime(2019, 04, 25),
                    LeadingDirector="Anthony Russo",
                    LeadingProducer="Victoria Alonso",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Pulp Fiction",
                    Description="The lives of two mob hitmen, a boxer," +
                    " a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ReleaseDate=new DateTime(1994, 10, 21),
                    LeadingDirector="Quentin Tarantino",
                    LeadingProducer="Lawrence Bender",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Love, Actually",
                    Description="Follows the lives of eight very different couples in dealing with their love lives in various" +
                    " loosely interrelated tales all set during a frantic month before Christmas in London, England.",
                    ReleaseDate=new DateTime(2003, 11, 16),
                    LeadingDirector="Richard Curtis",
                    LeadingProducer="Tim Bevan",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Uncut Gems",
                    Description="With his debts mounting and angry collectors closing in," +
                    " a fast-talking New York City jeweler risks everything in hope of staying afloat and alive.",
                    ReleaseDate=new DateTime(2019, 10, 09),
                    LeadingDirector="Benny Safdie",
                    LeadingProducer="Michael Bartol",
                    ContentLocation = "/baseimagelocation/",
                    Price=12.99m,
                    Rating = 0
                },
                new Movie
                {
                    Title="Insidious",
                    Description="A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.",
                    ReleaseDate=new DateTime(2011, 04, 29),
                    LeadingDirector="James Wan",
                    LeadingProducer="Jason Blum",
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
