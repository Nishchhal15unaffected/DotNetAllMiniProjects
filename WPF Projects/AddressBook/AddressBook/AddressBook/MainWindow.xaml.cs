using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AddressBookLibrary;
using AddressLibrary;

namespace AddressBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISave
    {
        BindingList<AddressModel> message = new BindingList<AddressModel>();
        public MainWindow()
        {
            InitializeComponent();
            ShowAdress();
        }

        private void ShowAdress()
        {
            addressList.ItemsSource = message;
        }

        public void SaveAddress(AddressModel addressModel)
        {
            message.Add(addressModel);
        }

        private void AddAddressButton_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address(this);
            address.Show();
        }
    }
}
