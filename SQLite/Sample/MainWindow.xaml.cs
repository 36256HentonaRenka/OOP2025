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
    private List<Person> _persons = new List<Person>();

    public MainWindow(){
        InitializeComponent();
        ReadDatabase();

        PersonListView.ItemsSource = _persons;
    }

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            _persons = connection.Table<Person>().ToList();
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

        ReadDatabase();
        PersonListView.ItemsSource = _persons;
        
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e) {
        var item = PersonListView.SelectedItem as Person;
        if(item == null) {
            MessageBox.Show("行を選択してください");
            return;
        }

        //データベース接続
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            connection.Delete(item);  //データから選択された項目を削除
            ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }

    }

    private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var filterList = _persons.Where(s=> s.Name.Contains(SearchTextBox.Text));
        
        PersonListView.ItemsSource = filterList;
    }

    //リストビューからレコード選択
    private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        var item = PersonListView.SelectedItem as Person;
        
        NameText.Text = item?.Name;
        PhoneText.Text = item?.Phone;

    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e) {
        var selectedPerson = PersonListView.SelectedItem as Person;
        if (selectedPerson == null) return;

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();

            var person = new Person() {
                Id = selectedPerson.Id,
                Name = NameText.Text,
                Phone = PhoneText.Text
            };
            connection.Update(person);
            ReadDatabase();
            PersonListView.ItemsSource = _persons;
        }
    }
}