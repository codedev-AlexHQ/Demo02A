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
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void BtnIngresos_Click(object sender, RoutedEventArgs e)
        {
            OperacionIngresos operacionIngresos = new OperacionIngresos();
            operacionIngresos.Show();
        }

        private void BtnSalidas_Click(object sender, RoutedEventArgs e)
        {
            // cerrar ventana actual
            this.Close();
        }
    }
}
