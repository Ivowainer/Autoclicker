using System.Windows.Forms;
using Autoclicker.Utils;

namespace Autoclicker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new mainForm());


            int a = Console.Read();
            AutoStroke test = new AutoStroke(Convert.ToChar(a).ToString());

            test.keyStroke();

        }
    }
}