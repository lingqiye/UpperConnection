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
using System.Windows.Shapes;

namespace UpperConnection
{
    /// <summary>
    /// StatisticalStatement.xaml 的交互逻辑
    /// </summary>
    public partial class StatisticalStatement : Window
    {
        public StatisticalStatement()
        {
            InitializeComponent();

            this.WindowState = System.Windows.WindowState.Maximized;//最大化
            this.ResizeMode = System.Windows.ResizeMode.NoResize;//无法修改最大最小化
            this.Left = 0.0;//左边距离0
            this.Top = 0.0;//顶部距离0
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;//获取屏幕宽度
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;//获取屏幕高度
        }
    }
}
