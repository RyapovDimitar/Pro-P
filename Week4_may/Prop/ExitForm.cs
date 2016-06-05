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
    public partial class ExitForm : Form
    {
        private RFID myRFIDReader;
        private DataHelper dh;
        public ExitForm()
        {
            InitializeComponent();
            dh = new DataHelper();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

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
            textBoxRFID.Text = e.Tag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            labelUserName.Text = dh.NameCorrespondingToRFID(textBoxRFID.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dh.ExitFromEvent(textBoxRFID.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = dh.IDCorrespondingToRFID(textBoxRFID.Text);
            List<string> items = dh.GetAllItemsToLoan(id);
            if (items.Count != 0)
            {
                foreach (string item in items)
                {
                    string hastogive = dh.ItemForLoanNameFromID(Convert.ToInt32(item));
                    MessageBox.Show("this person has to give back " + hastogive);
                }
            }
        }
    }
}
