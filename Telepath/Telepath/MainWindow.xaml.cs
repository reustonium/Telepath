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

namespace Telepath
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double screenWidth = SystemParameters.PrimaryScreenWidth;
        private double screenHeight = SystemParameters.PrimaryScreenHeight;

        public MainWindow()
        {
            InitializeComponent();
            this.Width = screenWidth;
            this.Left = 0;
            this.Top = screenHeight - this.Height;
        }

    }
}
