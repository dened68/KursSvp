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

namespace Tetris
{
    /// <summary>
    /// Логика взаимодействия для EnterName.xaml
    /// </summary>
    public partial class EnterName : Window
    {
        string namew;
        public EnterName( )
        {
            InitializeComponent();
        }

        private void Player_name_button_Click(object sender, RoutedEventArgs e)
        {
            namew = player_name.Text;
            this.Close();
        }
    }
}
