using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using homework3.Models;

namespace homework3.Repository
{
    public class PizzaRepository
    {
        private string _connectionString;

        public PizzaRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("PizzaDb");
        }

        public IList<Pizza> GetPizzas()
        {
            var query =
                "SELECT [PizzaId], [Name], [Price], [Description], [ImagePath] FROM [KredekPizza].[dbo].[Pizzas]";

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Pizza>(query).ToList();
            }
        }

        public void InsertPizza(Pizza pizza)
        {
            var query =
                "INSERT INTO Pizzas ([Name],[Price],[Description],[ImagePath]) " +
                "VALUES (@Name, @Price, @Description, @ImagePath)";

            var queryParams = new
            {
                Name = pizza.Name,
                Price = pizza.Price,
                Description = pizza.Description,
                ImagePath = pizza.ImagePath
            };

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, queryParams);
            }

        }

    }
}