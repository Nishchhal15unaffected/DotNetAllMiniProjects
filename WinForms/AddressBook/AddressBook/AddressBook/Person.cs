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
    public partial class Person : Form, ISave
    {
        BindingList<AddressModel> Address = new BindingList<AddressModel>();
        public Person()
        {
            InitializeComponent();
            ShowRecord();
        }

        public void ShowRecord()
        {
            addressListBox.DataSource = Address;
            addressListBox.DisplayMember= nameof(AddressModel.AddressDisplayValue);
        }

        public void SaveAdress(AddressModel address)
        {
            Address.Add(address);
        }

        private void addAdressButton_Click(object sender, EventArgs e)
        {
            Address address = new Address(this);
            address.Show();
        }

        private void saveAllRecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel()
            {
               FirstName = firstNameTextBox.Text,
               LastName = lastNameTextBox.Text,
               IsActive = isActiveCheckBox.Checked,
               Address =  Address.ToList()
            };
        }
    }
}
