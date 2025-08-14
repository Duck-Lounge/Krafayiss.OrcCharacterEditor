using System;
using System.Windows.Forms;

namespace OrcCharacterEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
