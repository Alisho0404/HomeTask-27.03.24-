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
    public class CountryService : ICountryService
    { 
        private readonly string _connectionString=
            "Server=localhost;Port=5432;Database=HTT27;User Id=postgres;Password=909662643";
        public string AddCountry(Country country)
        {
            using (var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = $"insert into country(name,capital,area,population,language) " +
                    $"values('{country.Name}','{country.Capital}',{country.Area},'{country.Population}','{country.Language}')";
                var insert = connection.Execute(sql);
                if (insert>0)
                {
                    return "Country succesfully added to db";
                }
                return "Error in adding country to db";
            }
        }

        public List<Country> GetCountries()
        {
            using(var connection=new NpgsqlConnection(_connectionString))
            {
                var sql = "Select * from Country";
                var result = connection.Query<Country>(sql);
                return result.ToList();
            }
        }

        public bool RemoveCountry(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Delete from country where id={@id}"; 
                var result =connection.Execute(sql);
                if (result>0)
                {
                    return true;
                } 
                return false;
            }
        }

        public string UpdateCountry(Country country)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var sql = $"update country set name='{country.Name}',capital='{country.Capital}',area={country.Area}," +
                    $"population='{country.Population}',language='{country.Language}'" +
                    $"where id={country.Id}";
                var result=connection.Execute(sql);
                if (result>0)
                {
                    return "Country succesfully updated";
                }
                return "Error in updating country";
            }
        }
    }
}
