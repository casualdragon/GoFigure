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
    /// Interaction logic for GameLevelSelectWindow.xaml
    /// </summary>
    public partial class GameLevelSelectWindow : Window
    {
        public GameLevelSelectWindow()
        {
            InitializeComponent();
        }
        private void Click(object sender, RoutedEventArgs e)
        {
            MainWindow game = new MainWindow();
            game.Show();
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new MainMenuWindow().Show();
            Close();
        }

        private void NotAvailable_Click(object sender, RoutedEventArgs e)
        {
            string message = "Sorry! This level will be able in the next expansion.";
            string caption = "Go Figure";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result = System.Windows.MessageBox.Show(message, caption, buttons, icon);
        }
    }
}
