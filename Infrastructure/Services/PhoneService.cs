using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace Infrastructure.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly string _connectionString =
            "Server=localhost;Port=5432;Database=HTT27;User Id=postgres;Password=909662643";
        public string AddPhone(Phone phone)
        {
            using (var connection =new NpgsqlConnection(_connectionString))
            {
                var sql = $"insert into phone (PhoneName,model,RAM,Memory)" +
                    $"values('{phone.PhoneName}','{phone.Model}',{phone.Ram} ,{phone.Memory} )";
                var insert = connection.Execute(sql);
                if (insert>0)
                {
                    return "Phone added to DB";
                }
                return "Error in adding phone to DB";
            }
        }

        public bool DeletePhone(int id)
        {
           using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = $"Delete from phone where id={@id}";
                var result=connection.Execute(sql);
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
             
        }

        public List<Phone> GetPhones()
        {
            using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = "Select * from Phone";
                var result = connection.Query<Phone>(sql);
                return result.ToList();
            }
        }

        public string UpdatePhone(Phone phone)
        {
            using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = $"Update phone set firstname='{phone.PhoneName}',model='{phone.Model}',Ram={phone.Ram} ,memory={phone.Memory}" +
                    $"where id={phone.Id}"; 
                var update= connection.Execute(sql);
                if (update > 0)
                {
                    return "Phone updated";
                }
                return "Error in updating phone";
            }
        }
    }
}
