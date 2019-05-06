using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImportExportHelper;

namespace Partyplaner
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
           ImportExportHelper ImportHelper = ImportExportHelper.getImportExportHelper();
           
           printf(ImportHelper.getGuest("Marco Polo").beruf);
        }
    }
}
