using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Olman
{
    /// <summary>
    /// Логика взаимодействия для inst.xaml
    /// </summary>
    public partial class inst : Page
    {
        public inst()
        {
            InitializeComponent();
        }

        private void screwdriver(object sender, RoutedEventArgs e)
        {
            Process.Start("https://eroshevskiy.github.io/screwdriver/");
        
        }
    }
}
