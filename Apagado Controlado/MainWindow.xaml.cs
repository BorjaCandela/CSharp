using Apagado_Controlado.Clases;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Apagado_Controlado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
            InitializeComponent();
        }

        private void buttonAnularClick(object sender, RoutedEventArgs e)
        {
            Accion.f_anular();
        }

        private void buttonApagarClick(object sender, RoutedEventArgs e)
        {
            int days = 0;
            int hours = 0;
            int minutes = 0;

            try
            {
                bool dayParse = Int32.TryParse(textBoxDias.Text, out days);
                bool hourParse = Int32.TryParse(textBoxHoras.Text, out hours);
                bool minuteParse = Int32.TryParse(textBoxMinutos.Text, out minutes);

                if (dayParse && hourParse && minuteParse)
                {
                    Accion.f_apagar(days, hours, minutes);
                }

            } catch (FormatException)
            {
                MessageBox.Show("Alguno de los valores no es un numero");
            }



        }
    }
}
