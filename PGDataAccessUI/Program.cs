



using Microsoft.Extensions.Configuration;
using PGDataAccessLibrary;

var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile("appSettings.json");
var config = builder.Build();


SqlCrud dataAccess = new SqlCrud();
string conn = config.GetConnectionString("PGRES");

var connString = "Host=dbserver1.postgres.database.azure.com;Username=serverthing15;Password=7ayB9WE32#f6;Database=test";

List<PersonModel> customers = dataAccess.GetAllPeople(connString);
foreach (var person in customers)
{
    Console.WriteLine($"{ person.FirstName},:");
}




Console.ReadLine();