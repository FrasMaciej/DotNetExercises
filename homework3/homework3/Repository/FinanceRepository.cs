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
    public class FinanceRepository
    {
        private string _connectionString;

        public FinanceRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("PizzaDb");
        }

        public IList<Finance> GetFinance()
        {
            var query =
                "SELECT [FinanceID], [PizzaId], [Description], [Sum] FROM [KredekPizza].[dbo].[Finance]";

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Finance>(query).ToList();
            }
        }

    }
}
