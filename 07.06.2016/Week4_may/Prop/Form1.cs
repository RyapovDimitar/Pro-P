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
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        public List<String> UsersInEvent;

        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                listBox1.Items.Add("startup: so far so good.");
                UsersInEvent = new List<String>();

            }
            catch (PhidgetException) { listBox1.Items.Add("error at start-up."); }
        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            listBox1.Items.Add("RFIDReader attached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            listBox1.Items.Add("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            listBox1.Items.Add("rfid has tag-nr: " + e.Tag);
            textBox2.Text = e.Tag;
        }

        public void SayHello(object sender, TagEventArgs e)
        {
            MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
                ".\nWelcome at our event ! ! !");
        }

        public bool Check(string x)
        {
            string ChipNR = this.myRFIDReader.LastTag.ToString();
            foreach (string g in UsersInEvent)
            {
                if (g.Equals(ChipNR))
                {

                    return true;
                }

            }
            return false;
        }

        public bool remove(string x)
        {
            string ChipNR = this.myRFIDReader.LastTag.ToString();
            if (UsersInEvent.Count > 0)
            {
                foreach (string g in UsersInEvent)
                {
                    if (g.Equals(ChipNR))
                    {
                        UsersInEvent.Remove(g);
                        MessageBox.Show("Chip with nr:" + g + "has been removed! ");
                        return true;
                    }
                }
            }
            MessageBox.Show("Ni items in list");
            return false;

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
                listBox1.Items.Add("an RFID-reader is found and opened.");
            }
            catch (PhidgetException)
            {
                MessageBox.Show("RFID reader not attached");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string ChipNR = this.myRFIDReader.LastTag.ToString();

            try
            {
                if (Check(ChipNR) == true)
                {
                    MessageBox.Show("chip exists");
                }
                else
                {
                    UsersInEvent.Add(ChipNR);
                }
            }



            catch (PhidgetException)
            {
                MessageBox.Show("Scan a chip");
            }
        }

        private void CloseRFID_Click(object sender, System.EventArgs e)
        {
            try
            {
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = false;
                myRFIDReader.LED = false;
                myRFIDReader.close();
                listBox1.Items.Add("\n RFID-reader is clsoed.");
            }
            catch (IOException)
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void RemoveFromFile_Click(object sender, System.EventArgs e)
        {
            string ChipNR = this.myRFIDReader.LastTag.ToString();
            remove(ChipNR);


        }

        private void show_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string g in UsersInEvent)
            {
                listBox1.Items.Add(g);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<User> userList;
            userList = dh.GetAllUsers();

            listBox1.Items.Clear();
            foreach (User person in userList)
            {
                listBox1.Items.Add(person.getInfo());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddtoDB_Click(object sender, EventArgs e)
        {
            String email = "test";
            String fname = "proba";
            String lname = "opit";
            String rfid = "opit";
            int money = 120;
            int over18 = 1;
            int inevent = 1;
            int incamping = 1;
            dh.AddAUser(email, fname, lname, money, over18, inevent, incamping, rfid);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dh.AssignARFID(Convert.ToInt32(textBox1.Text), textBox2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<User> userList;
            userList = dh.GetAllUsers();

            listBox1.Items.Clear();
            foreach (User person in userList)
            {
                if(person.FullName().Contains(textBox3.Text) || person.user_nr.ToString()==textBox3.Text)
                {
                    listBox1.Items.Add(person.getInfo());
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<User> userList;
            userList = dh.GetAllUsers();

            listBox1.Items.Clear();
            foreach (User person in userList)
            {
                listBox1.Items.Add(person.getInfo());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dh.PutInEvent(Convert.ToInt32(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dh.ExitFromEvent(Convert.ToInt32(textBox1.Text));
        }
    }

}

