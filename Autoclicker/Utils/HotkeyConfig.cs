using System.Runtime.InteropServices;

namespace Autoclicker.Utils
{

    public class HotkeyConfig
    {
        // <summary>
        // Importamos el método RegisterHotKey
        // de user32.dll, que permite establecer 
        // una hotkey en la app
        // </sumarry>

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc); 

        private char explicitHotkey;

        // TODO: DEFAULT EMERGENCY HOTKEY (override)

        public HotkeyConfig(IntPtr hWnd, char explicitHotkey) // Metodo para Hotkey configurada por el USUARIO
        {
            this.explicitHotkey = explicitHotkey;

            bool rRegistered = RegisterHotKey(hWnd, 1, 0x0000, (int)explicitHotkey);

            if (rRegistered)
            {
                Console.WriteLine($"Hotkey {explicitHotkey} fue registrado exitosamente");
            }
            else
            {
                Console.WriteLine($"No se pudo registrar el hotkey {explicitHotkey}");
            }
        }
    }
}
