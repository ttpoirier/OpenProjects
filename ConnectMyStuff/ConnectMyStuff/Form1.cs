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

        private void btnFind_Click(object sender, EventArgs e)
        {
            var userZipCode = txtZipCode.Text;

            if(userZipCode == "") {
                MessageBox.Show("Please enter a ZipCode", "Invalid ZipCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var station = new Station(System.Guid.NewGuid());
                txtDistance.Text = station.GetDistanceFromTarget().ToString();
                txtGasPrice.Text = station.GetPrice().ToString();
            }
        }

    }
}
