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
    public class PersonService : IPersonService
    { 
        private readonly string _connectionString=
            "Server=localhost;Port=5432;Database=HTT27;User Id=postgres;Password=909662643";
        public string AddPerson(Person person)
        {
           using(var connection =new NpgsqlConnection(_connectionString))
            {
                var sql = $"insert into Person(FirstName,LastName,email,phone,nationality)" +
                    $"values('{person.FirstName}','{person.LastName}','{person.Email}','{person.Phone}','{person.Nationality}')";
                var insert = connection.Execute(sql);
                if (insert>0)
                {
                    return "Person added to DB";
                }
                return "Error in entering to DB";
            }
        }

        public bool DeletePerson(int id)
        {
            using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = $"Delete from person where id={@id}"; 
                var delete= connection.Execute(sql);
                if (delete > 0)
                {
                    return true;
                } 
                return false;
            }
        }

        public Person GetPersonById(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Select * from Person where id={@id}"; 
                var result=connection.QueryFirstOrDefault<Person>(sql);
                return result;
            }
        }

        public List<Person> GetPersons()
        {
            using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = "Select * from Person"; 
                var result= connection.Query<Person>(sql);
                return result.ToList();
            }
        }

        public string UpdatePerson(Person person)
        {
            using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = $"update person set FirstName='{person.FirstName}',LastName='{person.LastName}',email='{person.Email}'," +
                    $"phone='{person.Phone}',nationality='{person.Nationality}'";
                var update= connection.Execute(sql);
                if (update>0)
                {
                    return "Person succesfully updated";
                }
                return "Error in updating person";
            }
        }
    }
}
