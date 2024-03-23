using System.Windows;

namespace Semana2A
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Password;

            if (usuario == "antony" && contraseña == "123456")
            {
                Window1 window = new Window1();
                window.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error al iniciar sesión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana actual al hacer clic en Cancelar
            this.Close();
        }
    }
}
