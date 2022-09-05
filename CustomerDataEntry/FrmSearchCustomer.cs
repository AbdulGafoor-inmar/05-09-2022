using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static MiddleTier.Class1;

namespace CustomerDataEntry
{
    public partial class FrmSearchCustomer : Form
    {
        public FrmSearchCustomer()
        {
            InitializeComponent();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            customer obj = new customer();
            DataSet objDataset=obj.LoadCustomer();
            dataGridView1.DataSource = objDataset.Tables[0];
        }
        /* CommonCode obj = new CommonCode();
            if (obj.CheckValidation(txtSearchCustomer.Text)==false)
            {
                MessageBox.Show("Customer Name Is Compulasory");
                return;
            }*/

        private void FrmSearchCustomer_Load(object sender, EventArgs e)
        {
           


        }
    }
}
