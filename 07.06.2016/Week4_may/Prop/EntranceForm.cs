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
    public partial class EntranceForm : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        public List<String> UsersInEvent;
        public EntranceForm()
        {
            InitializeComponent();
            dh = new DataHelper();
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
                UsersInEvent = new List<String>();

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
            RFID_label_number.Text = e.Tag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<User> userList;
            userList = dh.GetAllUsers();

            foreach (User person in userList)
            {
                if (person.user_nr.ToString() == textBoxUserID.Text)
                {
                    textBoxFullName.Text = person.FullName();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dh.AssignARFID(Convert.ToInt32(textBoxUserID.Text), RFID_label_number.Text);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<User> userList;
            userList = dh.GetAllUsers();

            foreach (User person in userList)
            {
                if (person.FullName() == textBoxFullName.Text)
                {
                    textBoxUserID.Text = person.user_nr.ToString();
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
