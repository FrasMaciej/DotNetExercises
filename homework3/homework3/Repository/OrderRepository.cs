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
    public class OrderRepository
    {
        private string _connectionString;

        public OrderRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("PizzaDb");
        }

        public void InsertOrder(Order order)
        {
            var query =
                "INSERT INTO Orders ([PizzaId],[City],[Address],[Email],[PhoneNumber],[OrderDate]) " +
                "VALUES (@PizzaId, @City, @Address, @Email, @PhoneNumber, @OrderDate)";

            var queryParams = new
            {
                PizzaId = order.PizzaId,
                City = order.City,
                Address = order.Address,
                Email = order.Email,
                PhoneNumber = order.PhoneNumber,
                OrderDate = order.OrderDate
            };

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, queryParams);
            }
        }

        public IList<Order> GetOrders()
        {
            var query =
                "SELECT [PizzaId], [City], [Address], [Email], [PhoneNumber], [OrderDate] FROM [KredekPizza].[dbo].[Orders]";

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Order>(query).ToList();
            }
        }
    }
}