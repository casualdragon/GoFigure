﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace GoFigure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String filename;
        private Game game;
        private Level level;

        public MainWindow()
        {
            InitializeComponent();
            Rectangle screenRes = Screen.PrimaryScreen.Bounds;

            int height = screenRes.Height;
            int width = screenRes.Width;

            Canvas canvas = new Canvas();
            canvas = canvaslevel;

            System.Windows.Controls.Image img = new System.Windows.Controls.Image();
            BitmapImage map = new BitmapImage();
            map.UriSource= new Uri("images/character.png", UriKind.Relative);

            Character character = new Character(new System.Windows.Controls.Image(), new System.Drawing.Point(100,100));
            character.image.Source = map;

            Canvas.SetLeft(character.image, 100);
            Canvas.SetTop(character.image, 100);

            canvaslevel.Children.Add(character.image);

            //level = new Level(filename);
            //game = new Game(level, false);

        }
        private void MainWindow_Paint (object sender, PaintEventArgs e)
        {
            using(Graphics g = e.Graphics)
            {
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100,100,100,100);
                g.DrawRectangle(Pens.Black, rect);
            }
           
        }
        
        private void keyUp(object sender, KeyEventArgs e)
        {
            
        }

        //This method determines whether which direction the character 
        //is moving based on the user input
        private void keyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    
                    break;
                case Keys.Right:
                    
                    break;
                case Keys.Up:
                    
                    break;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
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
                    e.Cancel = true;
                    break;
            }
            base.OnClosed(e);
        }

    }
}
