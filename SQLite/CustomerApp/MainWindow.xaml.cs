using CustomerApp.Data;
using Microsoft.Win32;
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
        OpenFileDialog openFileDialog = new OpenFileDialog {
            InitialDirectory = @"C:\Users\infosys\Desktop\画像集",
            Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        };

        if (openFileDialog.ShowDialog() == true) {
            string filepath = openFileDialog.FileName;
            byte[] imageBytes = System.IO.File.ReadAllBytes(filepath);

            // 画像をImageBoxに表示
            var bitmapImage = new BitmapImage();
            using (var stream = new System.IO.MemoryStream(imageBytes)) {
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
            }

            ImageBox.Source = bitmapImage;  // ImageBoxに表示

            // 顧客情報を作成
            var customer = new Customer() {
                Name = NameText.Text,
                Phone = CallNumberText.Text,
                Address = AddressText.Text,
                

            };
        }
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

        byte[] imageBytes = null;
        if (ImageBox.Source is BitmapImage bitmapImage) {
            using (var ms = new System.IO.MemoryStream()) {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(ms);
                imageBytes = ms.ToArray();
            }
        }

        item.Name = NameText.Text;
        item.Phone = CallNumberText.Text;
        item.Address = AddressText.Text;
        item.Picture = imageBytes;

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Update(item);
        }

        ReadDatabase();
        CustomerListView.ItemsSource = _customers;
        
    }

    

    private void SaveButton_Click(object sender, RoutedEventArgs e) {

        byte[] imageBytes = null;
        if (ImageBox.Source is BitmapImage bitmapImage) {
            using (var ms = new System.IO.MemoryStream()) {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(ms);
                imageBytes = ms.ToArray();
            }
        }

        var customer = new Customer() {
            Name = NameText.Text,
            Phone = CallNumberText.Text,
            Address = AddressText.Text,
            Picture = imageBytes

        };

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Insert(customer);
        }

        ReadDatabase();
        CustomerListView.ItemsSource = _customers;

    }

    private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        var item = CustomerListView.SelectedItem as Customer;

        NameText.Text = item?.Name;
        CallNumberText.Text = item?.Phone;
        AddressText.Text = item?.Address;
        ImageBox.Source = item?.PictureImage;


    }

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            _customers = connection.Table<Customer>().ToList();
        }
    }

    private void SerchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var Serch = _customers.Where(s => s.Name.Contains(SerchTextBox.Text));
        CustomerListView.ItemsSource = Serch;
    }
}