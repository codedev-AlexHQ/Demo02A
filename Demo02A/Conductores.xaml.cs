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

namespace Demo02A
{
    /// <summary>
    /// Lógica de interacción para Conductores.xaml
    /// </summary>
    public partial class Conductores : Window
    {
        public class Conductor
        {
            public string NombreConductor { get; set; }
            public string Licencia { get; set; }
            public string Transporte { get; set; }
        }
        private List<Conductor> listaConductores = new List<Conductor>();

        public Conductores()
        {
            InitializeComponent();
            DataGridConductores.ItemsSource = listaConductores;

        }

        private void BtnGrabar_Click(object sender, RoutedEventArgs e)
        {
            string nombreConductor = TxtNombreConductor.Text.Trim();
            string licencia = TxtLicencia.Text.Trim();
            string transporte = TxtTransporte.Text.Trim();

            // Validación básica
            if (string.IsNullOrWhiteSpace(nombreConductor) ||
                string.IsNullOrWhiteSpace(licencia) ||
                string.IsNullOrWhiteSpace(transporte))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Crear objeto y agregarlo a la lista
            var nuevoConductor = new Conductor
            {
                NombreConductor = nombreConductor,
                Licencia = licencia,
                Transporte = transporte
            };

            listaConductores.Add(nuevoConductor);

            // Actualizar el DataGrid
            DataGridConductores.Items.Refresh();

            // Limpiar campos
            TxtNombreConductor.Clear();
            TxtLicencia.Clear();
            TxtTransporte.Clear();
        }
    }
}
