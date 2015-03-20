using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectMyStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Station
        {
            public string stationName { get; set; }
            public string streetAddress { get; set; }
            public string requestDateTime { get; set; }
            public float gasPrice { get; set; }
            public float distance { get; set; }
            public int ranking { get; set; }
            public int indexNumber { get; set; }
            public Guid stationId { get; set; }

            public Station(System.Guid Id)
            {
                stationId = Id;

            }
            public float GetDistanceFromTarget()
            {
                var distance = 10;
                return distance;
            }
            public float GetPrice()
            {
                float price = 3;
                return price;
            }
        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var userZipCode = txtZipCode.Text;
            var isValid = false;
            List<string> errorMsgs = new List<string>();

            //check zip code
            if (userZipCode.Length == 5) 
            {
                if (IsDigitsOnly(userZipCode))
                {
                    isValid = true;
                }
                else
                {
                    errorMsgs.Add("Zip Code contains invalid characters!");
                }
            }
            else
            {
                errorMsgs.Add("Zip Code supplied was not the correct length.");
            }


            if (!isValid)
            {
                if (errorMsgs.Count > 0)
                {
                    foreach (string msg in errorMsgs)
                    {
                        MessageBox.Show(msg, "Invalid Zip Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid exception: Error caught.", "Error Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var station = new Station(System.Guid.NewGuid());


                txtDistance.Text = station.GetDistanceFromTarget().ToString();
                txtGasPrice.Text = station.GetPrice().ToString();
                MessageBox.Show("Value Found", "Value Found", MessageBoxButton.OK, MessageBoxIcon.Information);
            }
        }

    }
}
