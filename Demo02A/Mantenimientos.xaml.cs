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
    /// Lógica de interacción para Mantenimientos.xaml
    /// </summary>
    public partial class Mantenimientos : Window
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCamiones_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTransportistas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnConductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores conductores = new Conductores();
            conductores.Show();
        }
    }
}
