using System.Runtime.InteropServices;

namespace Autoclicker.Utils
{

    public class HotkeyConfig
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private IntPtr hWnd;

        public HotkeyConfig(IntPtr hWnd) // Constructor para Hotkey configurada por el USUARIO 
        {
            this.hWnd = hWnd;
        }

        public void RegisterByUser(char explicitHotkey) // Metodo que settea la Hotkey
        {
            UnregisterHotKey(hWnd, 1);

            char explicitHotkeyUpper = explicitHotkey.ToString().ToUpper()[0];
            bool rRegistered = RegisterHotKey(hWnd, 1, 0x0000, (explicitHotkeyUpper)); 

            if (rRegistered)
                Console.WriteLine($"Hotkey {explicitHotkey} fue registrado exitosamente");
            else
                Console.WriteLine($"No se pudo registrar el hotkey {explicitHotkey}");
        }
    }
}
