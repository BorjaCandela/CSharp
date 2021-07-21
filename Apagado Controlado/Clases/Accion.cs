using System.Diagnostics;
using System.Windows;

namespace Apagado_Controlado.Clases
{
    class Accion
    {
        public static void f_apagar(int days, int hours, int mins)
        {

            int total;

            if (days > 0)
            {
                days = days * (24 * 3600); // 24h * 60m * 60s * 1 = 86400s = 1d
            }

            if (hours > 0)
            {
                hours = hours * 3600;
            }

            if (mins > 0)
            {
                mins = mins * 60;
            }

            total = days + hours + mins;
            // MessageBox.Show(total.ToString());


            if (total == 0)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "¿Seguro que quieres apagar el ordenador sin cuenta atras?";
                string caption = "Confirma por favor";

                // Displays the MessageBox.
                if (System.Windows.MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    var exec = new ProcessStartInfo("shutdown", "/s /f /t " + total);
                    exec.CreateNoWindow = true;
                    exec.UseShellExecute = false;
                    Process.Start(exec);
                }
            }

            if (total > 0)
            {
                var exec = new ProcessStartInfo("shutdown", "/s /f /t " + total);
                exec.CreateNoWindow = true;
                exec.UseShellExecute = false;
                Process.Start(exec);
            }


        }

        public static void f_anular()
        {
            var psi = new ProcessStartInfo("shutdown", "/a");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }


    }
}
