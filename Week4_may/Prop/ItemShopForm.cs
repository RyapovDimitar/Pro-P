using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Prop
{
    public partial class ItemShopForm : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        private List<Item> itemList = new List<Item>();
        private List<Item> ShopCart = new List<Item>();
        private int finalCost { get; set; } //Stores the final cost which will be substracted from the user
        public ItemShopForm()
        {
            InitializeComponent();
            dh = new DataHelper();
        }

        // Transfers the data from the database to the list
        private void button1_Click(object sender, EventArgs e)
        {

            itemList = dh.GetAllItems();

            listBox1.Items.Clear();
            foreach (Item item in itemList)
            {
                listBox1.Items.Add(item.GetItemInfo());

            }

        }

        //Adding some testing information to the Database
        private void button3_Click(object sender, EventArgs e)
        {
            //int ID = 3;
            //string Description = "Sprite";
            //int Price = 2;
            //int quantity = 100;

            //  dh.AddItem(ID, Description, Price, quantity);
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    ShopCart.Add(((Item)(listBox2.Items)).ToString);
        //    string a = Convert.ToString(finalCost);
        //    foreach (Item g in ShopCart)
        //    {

        //    }

        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Adds a specified amount of a selected item from ListBox1 to ListBox2(shopingcart) 
        // 
        private void button4_Click(object sender, EventArgs e)
        {
            string currentitem = listBox1.SelectedItem.ToString();
            int CountDropBox = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 1; i <= CountDropBox; i++)
            {

                listBox2.Items.Add(currentitem);
            }

        }
    }
}
