namespace ContactWeb1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactWeb1.Models.ContactWeb1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ContactWeb1.Models.ContactWeb1Context";
        }

        protected override void Seed(ContactWeb1.Models.ContactWeb1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact
                {
                    Id = 1,
                    BirthDay = new DateTime(1920, 01, 20),
                    City = "Chicago",
                    Email = "doc.mccoy@starfleet.com",
                    FirstName = "DeForest",
                    LastName = "Kelley",
                    PhonePrimary = "123-456-7890",
                    PhoneSecondary = "234-567-8901",
                    State = "IL",
                    StreetAdress1 = "Sickbay",
                    StreetAdress2 = "Starship Enterprise NCC-1701",
                    UserId = new Guid("91844395-fb18-4b9d-a259-0149d7b91e92"),
                    Zip = "98765"
                }
                , new Models.Contact
                {
                    Id = 2,
                    BirthDay = new DateTime(1920, 03, 03),
                    City = "New York",
                    Email = "i.beam.you.up@starfleet.com",
                    FirstName = "James",
                    LastName = "Doohan",
                    PhonePrimary = "345-678-9012",
                    PhoneSecondary = "456-789-0123",
                    State = "NY",
                    StreetAdress1 = "Engineering",
                    StreetAdress2 = "Starship Enterprise NCC-1701",
                    UserId = new Guid("09b7b09f-30dc-4df2-b3bf-9f21cce67c0f"),
                    Zip = "87654"
                }
                , new Models.Contact
                {
                    Id = 3,
                    BirthDay = new DateTime(1931, 03, 26),
                    City = "Los Angeles",
                    Email = "its.only.logic@starfleet.com",
                    FirstName = "Leonard",
                    LastName = "Nimoy",
                    PhonePrimary = "987-654-3210",
                    PhoneSecondary = "876-543-2109",
                    State = "CA",
                    StreetAdress1 = "Science Station 1",
                    StreetAdress2 = "Starship Enterprise NCC-1701",
                    UserId = new Guid("852838cf-5e85-4846-bb30-bc8b32e7c7d2"),
                    Zip = "76543-2109"
                }
                , new Models.Contact
                {
                    Id = 4,
                    BirthDay = new DateTime(1931, 03, 22),
                    City = "Riverside",
                    Email = "the.captain@starfleet.com",
                    FirstName = "William",
                    LastName = "Shatner",
                    PhonePrimary = "765-432-1098",
                    PhoneSecondary = "654-321-0987",
                    State = "IA",
                    StreetAdress1 = "The Bridge",
                    StreetAdress2 = "Starship Enterprise NCC-1701",
                    UserId = new Guid("da4c1cc5-e7f3-4085-869b-0ba02704b8a7"),
                    Zip = "65432-0123"
                }
            );
        }
    }
}
