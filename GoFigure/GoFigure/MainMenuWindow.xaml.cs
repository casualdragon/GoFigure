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

namespace GoFigure
{
    /// <summary>
    /// Interaction logic for MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)e.Source;
            button.Background = Brushes.DarkGray;
        }
        private void MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)e.Source;
            button.Background = Brushes.Black;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;
            if (button == Play_Game)
            {
                MainWindow game = new MainWindow();
                game.Show();
                this.Close();
                

            }
            else if (button == Level_Editor)
            {

            }
            else if (button == Exit)
            {
                string message = "Are you sure you want to leave?";
                string caption = "Go Figure";
                MessageBoxButton buttons = MessageBoxButton.OKCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = System.Windows.MessageBox.Show(message, caption, buttons, icon);
                switch (result)
                {
                    //This stops the apllication from closing
                    case MessageBoxResult.Cancel:
                        this.Close();
                        break;
                }
                
            }
        }
    }
}
