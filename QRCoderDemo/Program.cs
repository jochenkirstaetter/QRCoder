using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QRCoderDemo;

internal static class Program
{
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new Form1());
        Application.Run(new Form1());
    }
}
