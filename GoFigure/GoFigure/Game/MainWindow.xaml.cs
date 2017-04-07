using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
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
            Rectangle screenRes = Screen.PrimaryScreen.Bounds;

            int WIDTH = Convert.ToInt32(this.Width);
            int HEIGHT = Convert.ToInt32(this.Height);
            imageLevel.Width = WIDTH;
            imageLevel.Height = HEIGHT;

            Bitmap displayBitmap = new Bitmap(WIDTH, HEIGHT);
            BitmapSource bitmap = Imaging.CreateBitmapSourceFromHBitmap(displayBitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(WIDTH, HEIGHT));
            imageLevel.Source = bitmap;

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
            game.movement = Game.Movement.STOPPED;
        }

        //This method determines whether which direction the character 
        //is moving based on the user input
        private void keyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    game.movement = Game.Movement.LEFT;
                    break;
                case Keys.Right:
                    game.movement = Game.Movement.RIGHT;
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
