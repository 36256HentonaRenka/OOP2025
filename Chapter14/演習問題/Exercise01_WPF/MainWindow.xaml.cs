using Microsoft.Win32;
using System.IO;
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

namespace Exercise01_WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{
    public MainWindow(){
        
    }

    private async void Button_Click(object sender, RoutedEventArgs e) {
        TextButton.Text = await TextReadSample.ReadTextAsync("走れメロス.txt");
    }

    static class TextReadSample {
        public static async Task<string> ReadTextAsync(string filePath) {
            var sb = new StringBuilder();
            var sr = new StreamReader(filePath);
                while (!sr.EndOfStream) {
                    string? line = await sr.ReadLineAsync();
                    sb.AppendLine(line);
                    await Task.Delay(10);
                }
            
            return sb.ToString();
        }
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {

    }
}