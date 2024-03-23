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
    /// Lógica de interacción para Camiones.xaml
    /// </summary>
    public partial class Camiones : Window
    {
        public Camiones()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Se ingresó correctamente", "Datos ingresados");

            result = MessageBoxResult.OK;
        }
    }
}
