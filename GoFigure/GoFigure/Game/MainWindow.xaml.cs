using GoFigure.Game;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Threading;

namespace GoFigure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String filename;
//        private Game game;
        private Level level;
        private Character character;
        private System.Windows.Point point;
        private int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            Rectangle screenRes = Screen.PrimaryScreen.Bounds;

            int height = screenRes.Height;
            int width = screenRes.Width;

            Canvas canvas = new Canvas();
            canvas = canvaslevel;

            ImageSource image = new BitmapImage(new Uri("/GoFigure;component/images/character.png", UriKind.Relative));
            
            character = new Character(new System.Windows.Controls.Image(), new System.Drawing.Point(100,100));
            character.image.Source = image;

            Canvas.SetLeft(character.image, 100);
            Canvas.SetTop(character.image, 100);

            Spike spike = new Spike(new PointF(620, 1000), new System.Windows.Controls.Image());
            image = new BitmapImage(new Uri("/GoFigure;component/images/spike.png", UriKind.Relative));
            spike.image.Source = image;

            GameObject floor = new Spike(new PointF(0, 0), new System.Windows.Controls.Image());
            image = new BitmapImage(new Uri("/GoFigure;component/images/block.png", UriKind.Relative));
            floor.image.Source = image;
            floor.image.Height = 55;
            floor.image.Width = 1280;
            floor.image.Stretch = Stretch.Fill;

            point.X = 100;
            point.Y = 100;

            canvaslevel.Children.Add(character.image);

            Canvas.SetBottom(spike.image, 50);
            Canvas.SetRight(spike.image, 500);
            spike.image.Height = 100;
            spike.image.Width = 100;
            canvaslevel.Children.Add(spike.image);

            Canvas.SetBottom(floor.image, 0);
            Canvas.SetRight(floor.image, 0);
            canvaslevel.Children.Add(floor.image);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(gameLoop);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            //level = new Level(filename);
            //game = new Game(level, false);

        }
        private void gameLoop(object sender, EventArgs e)
        {
            counter++;
            System.Windows.Controls.TextBox tb = time_textbox;
            tb.Text =  counter.ToString();
            
        }

        private void moveCharacter(System.Windows.Controls.Image image, double x, double y)
        {
            Canvas.SetTop(image, x);
            Canvas.SetLeft(image, y);
        }

        //This method determines whether which direction the character 
        //is moving based on the user input
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            switch (e.Key)
            {
                case Key.A:
                case Key.Left:
                    if (point.Y-100 >= 100) {
                        point.Y -= 100;
                        moveCharacter(character.image, point.X, point.Y);
                    }
                    break;
                case Key.D:
                case Key.Right:
                    if (point.Y <=1000) {
                        point.Y += 100;
                        moveCharacter(character.image, point.X, point.Y);
                    }
                    break;
                case Key.Up:
                case Key.W:
                    if (point.X-100 >= 20)
                    {
                        point.X -= 100;
                        moveCharacter(character.image, point.X, point.Y);
                    }
                    break;
                case Key.Down:
                case Key.S:
                    if (point.X + 100 <= 520)
                    {
                        point.X += 100;
                        moveCharacter(character.image, point.X, point.Y);
                    }
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

        private void time_textbox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            System.Windows.Controls.TextBox tb = (System.Windows.Controls.TextBox)sender;
            tb.Background = System.Windows.Media.Brushes.White;
            tb.BorderBrush = System.Windows.Media.Brushes.White;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            new IntermediateWindow(this).Show();
        }
    }
}
