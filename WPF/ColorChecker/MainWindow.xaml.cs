using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window{

        Color loadColor = Color.FromRgb(0,0,0);  //起動時のカラー
        MyColor currentColor;

        public MainWindow(){
            InitializeComponent();
            DataContext = GetColorList();
            
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        //すべてのスライダーから呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //colorAriaの色設定（背景色）は、スライダーで指定したRGBの色を表示する
            //スライダーの色情報をもとに色の名前を取得する
            currentColor = new MyColor { Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
                Name = ((MyColor[])DataContext).Where(c =>
                c.Color.R == (Byte)rSlider.Value &&
                c.Color.G == (Byte)gSlider.Value &&
                c.Color.B == (Byte)bSlider.Value).Select(X => X.Name).FirstOrDefault()
                };;
            colorArea.Background = new SolidColorBrush(currentColor.Color);

            var myColor = new MyColor {
                Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value),
                Name = string.Empty
            };
            currentColor.Color = myColor.Color;
            currentColor.Name = ((MyColor[])DataContext).Where(c => c.Color.Equals(currentColor.Color))
                .Select(x => x.Name).FirstOrDefault();

            int i;
            for ( i = 0; i < ((MyColor[])DataContext).Length; i++) {
                if (((MyColor[])DataContext)[i].Color.Equals(currentColor.Color)){
                    currentColor.Name = ((MyColor[])DataContext)[i].Name;
                    break;
                }
            }
            colorSelectComboBox.SelectedIndex = i < ((MyColor[])DataContext).Length ? i : -1;
            colorArea.Background = new SolidColorBrush(myColor.Color);

            colorSelectComboBox.SelectedIndex = GetColorToIndex(currentColor.Color);　//色のインデックスの設定
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            if (!stockList.Items.Contains((MyColor)currentColor)) {
                stockList.Items.Insert(0, currentColor);
            }else {
                MessageBox.Show("この色はすでにストックされています","ColorCheker",
                    MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            
            
        }

        //コンボボックスから色を選択
        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e){
            
            if (((ComboBox)sender).SelectedIndex == -1) return;

            var comboSelectMyColor = (MyColor)((ComboBox)sender).SelectedItem;
            currentColor = comboSelectMyColor;
            setSliderValue(comboSelectMyColor.Color); //スライダーを設定

            currentColor.Name = comboSelectMyColor.Name;
        }
        //各スライダーの値を設定する
        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            //MyColor selectcolor = (MyColor)stockList.SelectedItem;
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }

        //windowが表示されるタイミングで呼ばれる
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            colorSelectComboBox.SelectedIndex = GetColorToIndex(loadColor) ; //起動時に設定する色の設定
        }

        private int GetColorToIndex(Color color) {
            return (((MyColor[])DataContext).ToList()).FindIndex(c => c.Color.Equals(color));
        }
    }
}
