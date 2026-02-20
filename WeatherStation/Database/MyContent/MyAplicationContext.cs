using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Database.MyContent
{
    public class MyAplicationContext : DbContext 
    {
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeatherStationDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
                           .UseSeeding((context, _) =>
                           {
                               var users = context.Set<User>().FirstOrDefault();
                               if(users == null)
                               {
                                   var userFaker = new Faker<User>();
                                   userFaker.RuleFor(x => x.Name, f => f.Name.FullName());
                                   var usersToAdd = userFaker.Generate(1000);

                                   context.AddRange(usersToAdd);
                                   context.SaveChanges();
                               }
                               var sensors = context.Set<Sensor>().FirstOrDefault();
                               if (sensors == null)
                               {
                                   var sensorsFaker = new Faker<Sensor>();
                                   sensorsFaker.RuleFor(x => x.Type, faker => faker.Company.CompanySuffix());
                                   sensorsFaker.RuleFor(x => x.MeasurementDate, faker => faker.Date.Past());
                                   sensorsFaker.RuleFor(x => x.Name, f => f.Name.FullName());
                                   var sensorsToAdd = sensorsFaker.Generate(1000);


                                   context.AddRange(sensorsToAdd);
                                   context.SaveChanges();
                               }

                           });
        }
    }
}





































