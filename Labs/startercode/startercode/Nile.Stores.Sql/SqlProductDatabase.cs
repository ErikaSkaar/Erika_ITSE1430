using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        public SqlProductDatabase(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (connectionString == "")
                throw new ArgumentException("Connection string cannot be empty.", nameof(connectionString));

            _connectionString = connectionString;
        }
        private readonly string _connectionString;

        protected override Product AddCore(Product product)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override Product GetCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override Product UpdateCore(Product existing, Product newItem)
        {
            throw new NotImplementedException();
        }

        private SqlConnection CreateConnection()
             => new SqlConnection(_connectionString);

        private object GetProductId(Product product)
        {
            var sql = product as SqlProduct;

            return sql?.GetId() ?? 0;
        }

        public override bool ExistingProduct(string name)
        {
            throw new NotImplementedException();
        }
    }
}
