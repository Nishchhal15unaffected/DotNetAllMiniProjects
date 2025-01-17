using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressLibrary;

namespace AddressBook
{
    public partial class Address : Form
    {
        private ISave _parent = null;
        public Address(ISave save)
        {
            InitializeComponent();
            _parent = save;

        }

        private void saveRecordLabel_Click(object sender, EventArgs e)
        {
            AddressModel addressModel = new AddressModel()
            {
                Address = AddressTextBox.Text,
                City = CityTextBox.Text,
                LandMark = LandMarkLabel.Text,
                PostalCode = PostalCodeTextBox.Text,
            };
            _parent.SaveAdress(addressModel);
            this.Close();
        }
    }
}
