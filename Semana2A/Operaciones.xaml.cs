using System.Windows;

namespace Semana2A
{
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Obtener los valores de los campos de texto
            string tipoDocumento = txtTipoDocumento.Text;
            string numeroDocumento = txtNumeroDocumento.Text;
            string placa = txtPlaca.Text;
            string turno = txtTurno.Text;
            string nombreConductor = txtNombreConductor.Text;
            string nombreCliente = txtNombreCliente.Text;
            string fechaHora = txtFechaHora.Text;
            string pesoIngreso = txtPesoIngreso.Text;

            // Aquí puedes realizar alguna acción con los datos ingresados, como guardarlos en una base de datos
            // Por ahora, solo mostraremos un mensaje de éxito
            MessageBox.Show("Se ingresaron los datos correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
