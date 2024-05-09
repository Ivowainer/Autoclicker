using System.Windows.Forms;
using Autoclicker.Utils;

namespace Autoclicker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm());


            //int a = Console.Read(); // Toma el primer caracter de lo que se escribe en formato Unicode
            //AutoStroke test = new AutoStroke(Convert.ToChar(a).ToString()); // Parseamos de Unicode a Char y de Char a String

            //test.keyStroke();

        }
    }
}