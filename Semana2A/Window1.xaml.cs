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

namespace Semana2A
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Show();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores conductores = new Conductores();
            conductores.Show();
        }
        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            Camiones camiones = new Camiones();
            camiones.Show();
        }
        
    }
}
