﻿using GoFigure.Game;
using GoFigure.LevelEditor;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

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
            System.Windows.Controls.Button button = (System.Windows.Controls.Button)e.Source;
            button.Background = Brushes.DarkGray;
        }
        private void MouseLeave(object sender, MouseEventArgs e)
        {
            System.Windows.Controls.Button button = (System.Windows.Controls.Button)e.Source;
            button.Background = Brushes.Black;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            GameLevelSelectWindow levelselect = new GameLevelSelectWindow();
            levelselect.Show();
            Close();
        }

        private void Level_Editor_Click(object sender, RoutedEventArgs e)
        {
            LevelEditorWindow leveleditor = new LevelEditorWindow();
            leveleditor.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string caption = "Go Figure";
            MessageBoxButton buttons = MessageBoxButton.OKCancel;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = System.Windows.MessageBox.Show(message, caption, buttons, icon);
            switch (result)
            {
                //This stops the apllication from closing
                case MessageBoxResult.OK:
                    this.Close();
                    break;
            }
        }
    }
}
