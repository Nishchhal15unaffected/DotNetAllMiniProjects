using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AddressBookLibrary;
using AddressLibrary;

namespace AddressBook
{
    /// <summary>
    /// Interaction logic for Address.xaml
    /// </summary>
    public partial class Address : Window
    {
        private ISave _parent = null;
        public Address(ISave parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var address = new AddressModel()
            {
                Address = addressInputBox.Text,
                City = cityInputBox.Text,
                LandMark = landMarkInputBox.Text,
                PostalCode = postalCodeInputBox.Text
            };
            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
