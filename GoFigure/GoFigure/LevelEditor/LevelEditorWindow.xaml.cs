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

namespace GoFigure.LevelEditor
{
    /// <summary>
    /// Interaction logic for LevelEditorWindow.xaml
    /// </summary>
    public partial class LevelEditorWindow : Window
    {
        public LevelEditorWindow()
        {
            InitializeComponent();

        }

        private void character_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Brush background = button.Background;
        }
    }
}
