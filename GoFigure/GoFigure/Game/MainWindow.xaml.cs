using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
