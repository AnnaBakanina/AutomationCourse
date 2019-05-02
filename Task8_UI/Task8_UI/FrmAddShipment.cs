using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8_UI
{
    public partial class FrmAddShipment : Form
    {
        public FrmAddShipment()
        {
            InitializeComponent();
        }

        List<Shipment> shipmentsList = new List<Shipment>();

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 1;
            string str = $"AB{i}";
            shipmentsList.Add(new Shipment(str, txtAddress.Text, int.Parse(cmbOrderID.Text), false)); //int? parse
            i++;
        }
    }
}
