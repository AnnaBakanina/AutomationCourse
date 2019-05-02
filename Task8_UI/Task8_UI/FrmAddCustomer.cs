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
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        List<Customer> customersList = new List<Customer>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customersList.Add(new Customer(Guid.NewGuid().ToString(), txtCustomerName.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
