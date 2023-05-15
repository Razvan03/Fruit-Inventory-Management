using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Tema2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ShoppingListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public byte[] Photo { get; set; }


    }
    public class WebService1 : System.Web.Services.WebService
    {

        private string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Tema2;Integrated Security=True";
        [WebMethod]
        public List<ShoppingListItem> GetShoppingListItems()
        {
            List<ShoppingListItem> items = new List<ShoppingListItem>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ShoppingListItems", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ShoppingListItem item = new ShoppingListItem();
                    item.Id = (int)reader["Id"];
                    item.Name = reader["Name"].ToString();
                    item.Quantity = (int)reader["Quantity"];
                    item.Price = (decimal)reader["Price"];
                    item.Details = reader["Details"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                    {
                        item.Photo = (byte[])reader["Photo"];
                    }
                    items.Add(item);
                }
            }

            return items;
        }

        [WebMethod]
        public void AddShoppingListItem(ShoppingListItem item)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {


                SqlCommand cmd = new SqlCommand("INSERT INTO ShoppingListItems (Name, Quantity, Price, Details, Photo) VALUES (@Name, @Quantity, @Price, @Details, @Photo)", conn);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Details", item.Details);
                cmd.Parameters.AddWithValue("@Photo", item.Photo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public void UpdateShoppingListItem(ShoppingListItem item)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE ShoppingListItems SET Name = @Name, Quantity = @Quantity, Price = @Price, Details = @Details, Photo = @Photo WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Details", item.Details);
                cmd.Parameters.AddWithValue("@Photo", item.Photo);
                cmd.Parameters.AddWithValue("@Id", item.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public void DeleteShoppingListItem(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ShoppingListItems WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
        }
        [WebMethod]
        public List<ShoppingListItem> GetShoppingListItemsSortedByPrice()
        {
            List<ShoppingListItem> items = new List<ShoppingListItem>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ShoppingListItems ORDER BY Price", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ShoppingListItem item = new ShoppingListItem();
                    item.Id = (int)reader["Id"];
                    item.Name = reader["Name"].ToString();
                    item.Quantity = (int)reader["Quantity"];
                    item.Price = (decimal)reader["Price"];
                    item.Details = reader["Details"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                    {
                        item.Photo = (byte[])reader["Photo"];
                    }
                    items.Add(item);
                }
            }

            return items;
        }
        [WebMethod]
        public string GetTotalValue()
        {
            decimal totalValue = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Price, Quantity FROM ShoppingListItems", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    decimal price = (decimal)reader["Price"];
                    int quantity = (int)reader["Quantity"];
                    totalValue += price * quantity;
                }
            }

            return totalValue.ToString();
        }
    }
}

