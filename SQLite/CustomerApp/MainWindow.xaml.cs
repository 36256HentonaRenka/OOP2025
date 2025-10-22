using CustomerApp.Data;
using SQLite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{

    private List<Customer> _customers = new List<Customer>();
    public MainWindow()
    {
        InitializeComponent();
        ReadDatabase();
        CustomerListView.ItemsSource = _customers;
    }

    private void PhotoButton_Click(object sender, RoutedEventArgs e) {

    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e) {
        var item = CustomerListView.SelectedItem as Customer;

        if (item == null) {
            MessageBox.Show("行を選択してください");
            return;
        }

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Delete(item);  //データから選択された項目を削除
            ReadDatabase();
            CustomerListView.ItemsSource = _customers;
        }
    }

    private void UpDateButton_Click(object sender, RoutedEventArgs e) {
        var item = CustomerListView.SelectedItem as Customer;

        if (item == null) return;

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();

            var customer = new Customer() {
                Name = NameText.Text,
                Phone = CallNumberText.Text,
                Address = AddressText.Text
            };
            connection.Update(customer);
            ReadDatabase();
            CustomerListView.ItemsSource = _customers;
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        var customer = new Customer() {
            Name = NameText.Text,
            Phone = CallNumberText.Text,
            Address = AddressText.Text
        };

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Insert(customer);
        }

    }

    private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        var item = CustomerListView.SelectedItem as Customer;

        NameText.Text = item?.Name;
        CallNumberText.Text = item?.Phone;
        AddressText.Text = item?.Address;

    }

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            _customers = connection.Table<Customer>().ToList();
        }
    }

    private void SerchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var Serch = _customers.Where(s => s.Name.Contains(SerchTextBox.Text));
    }
}