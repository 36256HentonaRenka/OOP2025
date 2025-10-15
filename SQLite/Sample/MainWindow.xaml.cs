using Sample.Data;
using SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Xml.Serialization;

namespace Sample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{
    private ObservableCollection<Person> _persons = new ObservableCollection<Person>();

    public MainWindow(){
        InitializeComponent();
        //ReadDatabase();
        _persons.Add(new Person { Id = 1, Name = "aaaaa", Phone = "12345678901" });
        PersonListView.ItemsSource = _persons;
    }

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            //_persons = connection.Table<Person>().ToList();
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        var person = new Person() {
            Name = NameText.Text,
            Phone = PhoneText.Text,
        };

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            connection.Insert(person);
        }

    }

    private void ReadButton_Click(object sender, RoutedEventArgs e) {

        _persons.Add(new Person { Id = 1, Name = "aaaaa", Phone = "12345678901" });

        //ReadDatabase();

    }
}