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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Shipment> shipmentsList = new List<Shipment>();
        List<Order> ordersList = new List<Order>();
        List<Customer> customersList = new List<Customer>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddDataToDGV()
        {
            for (int i = 0; i < shipmentsList.Count; i++) 
            {
                //dataGridView1.Add(shipmentsList[i].ShipmentID, shipmentsList[i].Address, shipmentsList[i].OrderID, shipmentsList[i].ShipmentStatus == true ? "Sent" : "Not Sent");
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.ShowDialog();
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmAddOrder = new FrmAddOrder();
            frmAddOrder.ShowDialog();
        }

        private void addNewShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddShipment frmAddShipment = new FrmAddShipment();
            frmAddShipment.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
