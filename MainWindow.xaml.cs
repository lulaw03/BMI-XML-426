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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF419
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 宣告身高(cm)和體重(kg)的變數
            double height = double.Parse(HeightBox.Text)/100;
            double weight = double.Parse(WeightBox.Text);

            // 計算BMI
            double BMI = weight / (height * height);
            Consult.Text = BMI.ToString();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("你騙人");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("請你離開嘿");
        }

        private void clear2_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = " ";
        }

        private void clear1_Click(object sender, RoutedEventArgs e)
        {
            WeightBox.Text = " ";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightBox.Text = HeightSlider.Value.ToString();
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeightBox.Text = WeightSlider.Value.ToString();
        }
    }
}
