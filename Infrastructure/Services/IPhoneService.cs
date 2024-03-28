using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public interface IPhoneService
    { 
        List<Phone> GetPhones();
        string AddPhone(Phone phone); 
        string UpdatePhone(Phone phone);
        bool DeletePhone(int id);
    }
}
