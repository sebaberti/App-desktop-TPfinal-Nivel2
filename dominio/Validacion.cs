using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dominio
{
    public class Validacion
    {
        public static void soloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                e.Handled = true;
                return;
            }
        }

        public static void soloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                e.Handled = true;
                return;
            }
        }

    }
}
