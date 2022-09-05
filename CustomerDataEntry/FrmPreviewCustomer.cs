using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDataEntry
{
    public partial class FormCustomerPreview : Form
    {
        public FormCustomerPreview()
        {
            InitializeComponent();
        }

        private void FormCustomPreview_Load(object sender, EventArgs e)
        {

        }
        public void SetValues(string custName ,string Country, 
                         string Gender,
                         string Hobbies,
                         string Status,string Address)
        {
            CustomerData.Text = custName;
            CountryData.Text = Country;
            GenderData.Text = Gender;
            HobbiesData.Text = Hobbies;
            StatusData.Text = Status;
            AddressData.Text = Address; 
        }
    }
}
