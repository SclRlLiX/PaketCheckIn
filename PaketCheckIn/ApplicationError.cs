using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaketCheckIn
{
    internal class ApplicationError
    {
        public ApplicationError(string ErrorMessage)
        {
            MessageBox.Show(ErrorMessage, "Fehler",MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Windows.Application.Current.Shutdown();
            return;
        }
    }
}
