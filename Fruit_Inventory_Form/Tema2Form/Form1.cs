using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tema2Form.ServiceReference1;

namespace Tema2Form
{
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
}
