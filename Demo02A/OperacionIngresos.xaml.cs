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
    /// Lógica de interacción para OperacionIngresos.xaml
    /// </summary>
    public partial class OperacionIngresos : Window
    {
        public OperacionIngresos()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
