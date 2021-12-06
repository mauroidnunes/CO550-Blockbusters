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
        }

        private static void AddPeople(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
               new Person()
               {
                   FirstName="",
               }
            };

            context.People.AddRange(people);
            // context.SaveChanges();
        }

        private static void AddPayments(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Payments.Any())
            {
                return;   // DB has been seeded
            }

            var payments = new Payment[]
            {
                new Payment()
                {
                    CardholderName="Bob Smith", 
                    CardNumber="1234567812345678",
                    ExpirationDate = "1024",
                    CCV="234"
                }
            };

            context.Payments.AddRange(payments);
            // context.SaveChanges();
        }
    }
}
