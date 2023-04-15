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
using UpperConnection.Database;
using UpperConnection.Views;

namespace UpperConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            MySqldata.Connection();

            #region 初始化全屏
            this.WindowState = System.Windows.WindowState.Maximized;//最大化
            this.ResizeMode = System.Windows.ResizeMode.NoResize;//无法修改最大最小化
            this.Left = 0.0;//左边距离0
            this.Top = 0.0;//顶部距离0
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;//获取屏幕宽度
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;//获取屏幕高度
            #endregion
        }

        #region PCB管理页面
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Import_Click(object sender, RoutedEventArgs e)
        {
            PcbData pcbData = new PcbData();
            pcbData.Show();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletedData_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            PcbData pcbData = new PcbData();
            pcbData.Show();
        }

        /// <summary>
        /// 拼接PCB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Splicing_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region 统计报表页面
        /// <summary>
        /// 查看数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewData_Click(object sender, RoutedEventArgs e)
        {
            StatisticalStatement statisticalStatement = new StatisticalStatement();
            statisticalStatement.Show();

        }

        #endregion

    }
}
