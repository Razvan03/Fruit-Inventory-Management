# Windows Forms App with Web Service Integration for Fruit Inventory Management in C# (.NET Framework).
This repository contains a Windows Forms application that integrates with a web service for managing a fruit inventory. The application interacts with the web service, which is connected to a SQL database, to perform operations such as retrieving a list of fruits, adding new fruits, updating fruit details, and deleting fruits. The app provides a user-friendly interface for managing the fruit inventory efficiently.

WebService1.asmx.cs:
```C#
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
```

Form1.cs:
```C#
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        List<ShoppingListItem> items = new List<ShoppingListItem>();

        private void Form1_Load(object sender, EventArgs e)
        {
            ShoppingListItem[] itemsArray = service.GetShoppingListItems();
            items = itemsArray.ToList();
            foreach (ShoppingListItem item in items)
            {
                listBox_Produse.Items.Add(item.Name);
            }
            lbl_Pret_Change();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ShoppingListItem newItem = new ShoppingListItem();
            newItem.Name = txtBox_Nume.Text;
            newItem.Quantity = int.Parse(txtBox_Cantitate.Text);
            newItem.Price = decimal.Parse(txtBox_Pret.Text);
            newItem.Details = txtBox_Detalii.Text;
            byte[] photo = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    photo = stream.ToArray();
                }
            }
            newItem.Photo = photo;
            service.AddShoppingListItem(newItem);

            items.Add(newItem); // adaug si noul element la colectia items
            listBox_Produse.Items.Add(newItem.Name);
            lbl_Pret_Change();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (listBox_Produse.SelectedIndex >= 0)
            {
                ShoppingListItem selectedItem = items[listBox_Produse.SelectedIndex];
                selectedItem.Name = txtBox_Nume.Text;
                selectedItem.Quantity = int.Parse(txtBox_Cantitate.Text);
                selectedItem.Price = decimal.Parse(txtBox_Pret.Text);
                selectedItem.Details = txtBox_Detalii.Text;
                byte[] photo = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        photo = stream.ToArray();
                    }
                }
                selectedItem.Photo = photo;
                service.UpdateShoppingListItem(selectedItem);

                items[listBox_Produse.SelectedIndex] = selectedItem;
                listBox_Produse.Items[listBox_Produse.SelectedIndex] = selectedItem.Name;
                lbl_Pret_Change();
            }
        }

        private void listBox_Produse_Click(object sender, EventArgs e)
        {
            if (listBox_Produse.SelectedIndex >= 0)
            {
                ShoppingListItem selectedItem = items[listBox_Produse.SelectedIndex];
                txtBox_Nume.Text = selectedItem.Name;
                txtBox_Cantitate.Text = selectedItem.Quantity.ToString();
                txtBox_Pret.Text = selectedItem.Price.ToString();
                txtBox_Detalii.Text = selectedItem.Details;
                if (selectedItem.Photo != null)
                {
                    using (MemoryStream stream = new MemoryStream(selectedItem.Photo))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Produse.SelectedIndex >= 0)
            {
                ShoppingListItem selectedItem = items[listBox_Produse.SelectedIndex];

                service.DeleteShoppingListItem(selectedItem.Id);

                items.RemoveAt(listBox_Produse.SelectedIndex);
                listBox_Produse.Items.RemoveAt(listBox_Produse.SelectedIndex);
                lbl_Pret_Change();
            }
        }
        private void Incarca_Poza_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                openFileDialog.Title = "Select Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                }
            }
        }
        private void btn_SortByPrice_Click(object sender, EventArgs e)
        {
            listBox_Produse.Items.Clear();
            ShoppingListItem[] itemsArray = service.GetShoppingListItemsSortedByPrice();
            items = itemsArray.ToList();
            foreach (ShoppingListItem item in items)
            {
                listBox_Produse.Items.Add(item.Name);
            }
        }
        private void lbl_Pret_Change()
        {
            lbl_Price.Text = "Total price: " + service.GetTotalValue();
        }
    }
```
