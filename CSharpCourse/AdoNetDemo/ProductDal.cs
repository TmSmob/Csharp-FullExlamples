using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=LENOX;initial catalog=Etrade;integrated security=true");
        public List<Product> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrive"])
                };
                products.Add(product);

            }
            reader.Close();
            _connection.Close();
            return products;
        }
        public DataTable GetAll2()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand commend = new SqlCommand("Insert into Products values(@name,@unitPrive,@stockAmount)", _connection);
            commend.Parameters.AddWithValue("@name", product.Name);
            commend.Parameters.AddWithValue("@unitPrive", product.UnitPrice);
            commend.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            commend.ExecuteNonQuery();
            _connection.Close();

        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand commend = new SqlCommand("Update Products set Name=@name, UnitPrive=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            commend.Parameters.AddWithValue("@id", product.Id);
            commend.Parameters.AddWithValue("@name", product.Name);
            commend.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            commend.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            commend.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand commend = new SqlCommand("Delete from Products where Id=@id", _connection);
            commend.Parameters.AddWithValue("@id",id);
            commend.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
