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

namespace UpperConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double WidthValue { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //初始化全屏
            this.WindowState = System.Windows.WindowState.Maximized;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            this.Left = 0.0;
            this.Top = 0.0;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
        }
        /// <summary>
        /// 查看数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewData_Click(object sender, RoutedEventArgs e)
        {
            StatisticalStatement statisticalStatement=new StatisticalStatement();
            statisticalStatement.Show();
            this.Close();
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletedData_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
