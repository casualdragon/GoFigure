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

namespace GoFigure.Game
{
    /// <summary>
    /// Interaction logic for IntermediateWindow.xaml
    /// </summary>
    public partial class IntermediateWindow : Window
    {
        MainWindow main;
        public IntermediateWindow(MainWindow main)
        {
            InitializeComponent();
            Closing += new System.ComponentModel.CancelEventHandler(closing);
            this.main = main;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new GameLevelSelectWindow().Show();
            Visibility = Visibility.Collapsed;
        }
        void closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;    
            main.Visibility = Visibility.Visible;
        }
    }
}
