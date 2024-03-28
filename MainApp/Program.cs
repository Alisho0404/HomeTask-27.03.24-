using Infrastructure.Services;
using Domain.Models;

var countryService=new CountryService();
var country1 = new Country()
{
    Name= "Tajikistan",
    Capital="Dushanbe",
    Area=143,
    Population="9 mln"
};
var country2 = new Country()
{
    Name = "USA",
    Capital = "Washington DC",
    Area = 843,
    Population = "49 mln"
};
var country3 = new Country()
{
    Name = "Canada",
    Capital = "Otava",
    Area = 742,
    Population = "69 mln"
};
//countryService.AddCountry(country1);
//countryService.AddCountry(country2);
//countryService.AddCountry(country3);
//Console.WriteLine(countryService.RemoveCountry(3)); 

var phoneService = new PhoneService();
var phone1 = new Phone() 
{ 
    PhoneName="Iphone", 
    Model="15 pro max", 
    Ram=16,
    Memory=256
};
var phone2 = new Phone()
{
    PhoneName = "Huawei",
    Model = "P20 Lite",
    Ram = 4,
    Memory = 64
};
var phone3 = new Phone()
{
    PhoneName = "Samsung",
    Model = "S23 Ultra+",
    Ram = 16,
    Memory = 256
};

//Console.WriteLine(phoneService.AddPhone(phone1));
//Console.WriteLine(phoneService.AddPhone(phone1));
//Console.WriteLine(phoneService.AddPhone(phone1));
//Console.WriteLine(phoneService.AddPhone(phone2));
//Console.WriteLine(phoneService.AddPhone(phone3)); 
//phoneService.DeletePhone(2);
//phoneService.DeletePhone(3); 

var personService=new PersonService();
var person1 = new Person()
{
    FirstName = "Alex",
    LastName = "Johnson",
    Email = "alex@gmail.com",
    Phone = "+992501478520",
    Nationality = "America"
};
var person2 = new Person()
{
    FirstName = "Bob",
    LastName = "Marli",
    Email = "bob@gmail.com",
    Phone = "+99290902020",
    Nationality = "Italy"
};
var person3 = new Person()
{
    FirstName = "Sam",
    LastName = "Abdulaziz",
    Email = "sam@gmail.com",
    Phone = "+992885411111",
    Nationality = "Tajikistan"
};

//Console.WriteLine(personService.AddPerson(person1));
//Console.WriteLine(personService.AddPerson(person2));
//Console.WriteLine(personService.AddPerson(person3));
//Console.WriteLine(personService.DeletePerson(2)); 

foreach (var item in personService.GetPersons())
{
    Console.Write(item.FirstName+" ");
    Console.Write(item.LastName + " ");
    Console.Write(item.Email + " ");
    Console.Write(item.Phone + " ");
    Console.Write(item.Nationality + " ");
    Console.WriteLine();
}