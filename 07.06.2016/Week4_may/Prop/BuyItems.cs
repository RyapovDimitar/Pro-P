using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace Prop
{
    public partial class BuyItems : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        List<Item> itemsInCart;
        public BuyItems()
        {
            InitializeComponent();
            dh = new DataHelper();
            List<Item> items = new List<Item>();
            itemsInCart = new List<Item>();
            items = dh.GetAllItems();
            foreach (Item sth in items)
            {
                listBox1.Items.Add(sth.GetItemInfo());
            }
            
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
                MessageBox.Show("startup: so far so good.");

            }
            catch (PhidgetException) { MessageBox.Show("error at start-up."); }
        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            MessageBox.Show("RFIDReader attached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            MessageBox.Show("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        }
        
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            MessageBox.Show("rfid has tag-nr: " + e.Tag);
            RFIDNumber.Text = e.Tag;
            List<User> users = new List<User>();
            users = dh.GetAllUsers();
            foreach (User ivan in users)
            {
                if (ivan.RFID() == RFIDNumber.Text)
                {
                    labelUserBalance.Text = ivan.Money().ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            users = dh.GetAllUsers();
            foreach (User ivan in users)
            {
                if (ivan.RFID() == RFIDNumber.Text)
                {
                    labelUserBalance.Text = ivan.Money().ToString();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal newmoney = 0;
            int userid;
            List<User> users = new List<User>();
            users = dh.GetAllUsers();
            foreach (User igrach in users)
            {
                if (igrach.RFID() == RFIDNumber.Text)
                {
                    newmoney = igrach.Money();
                    userid = igrach.user_nr;
                }
            }
            List<Item> items = new List<Item>();
            items = dh.GetAllItems();
            //foreach (Item sth in items)
            //{
            //    if (sth.GetID() == (listBox1.SelectedIndex + 1))
            //    {
            //        if ((newmoney - (sth.Price * (comboBox1.SelectedIndex + 1))) > 0)
            //        {
            //            newmoney = newmoney - (sth.Price * (comboBox1.SelectedIndex + 1));
            //            dh.BuyItem(textBox1.Text, listBox1.SelectedIndex + 1, comboBox1.SelectedIndex + 1, newmoney);
            //            textBox2.Text = newmoney.ToString();
            //        }
            //        else
            //        {
            //            MessageBox.Show("nope. no money no problem.");
            //        }
            //    }
            //}
            foreach (Item something in itemsInCart)
            {
                if ((newmoney - (something.Price * (comboBox1.SelectedIndex + 1))) > 0)
                {
                    newmoney = newmoney - (something.Price * something.Quantity);
                    dh.BuyItem(RFIDNumber.Text, something.GetID(), something.Quantity, newmoney);
                    labelUserBalance.Text = newmoney.ToString();
                }
                else
                {
                    MessageBox.Show("nope. no money no problem.");
                }
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();
            items = dh.GetAllItems();
            foreach (Item sth in items)
            {
                if (sth.GetID() == (listBox1.SelectedIndex + 1))
                {
                    sth.Quantity = comboBox1.SelectedIndex + 1;
                    itemsInCart.Add(sth);
                    listBox2.Items.Add(sth.Description + " " + sth.Quantity);
                }
            }
        }
    }
}
