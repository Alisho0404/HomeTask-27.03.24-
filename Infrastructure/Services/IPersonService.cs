using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public interface IPersonService
    {
        List<Person> GetPersons(); 
        Person GetPersonById(int id);
        string AddPerson(Person person);
        string UpdatePerson(Person person); 
        bool DeletePerson(int id);
    }
}
