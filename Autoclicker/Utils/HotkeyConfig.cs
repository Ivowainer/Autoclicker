using System.Runtime.InteropServices;

namespace Autoclicker.Utils
{

    public class HotkeyConfig
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc); 

        private IntPtr hWnd;

        // TODO: DEFAULT EMERGENCY HOTKEY (override)

        public HotkeyConfig(IntPtr hWnd) // Constructor para Hotkey configurada por el USUARIO 
        {
            this.hWnd = hWnd;
        }

        public void RegisterByUser(char explicitHotkey) // Metodo que settea la Hotkey
        {
            char explicitHotkeyUpper = explicitHotkey.ToString().ToUpper()[0];
            bool rRegistered = RegisterHotKey(hWnd, 1, 0x0000, (explicitHotkeyUpper)); 

            if (rRegistered)
                Console.WriteLine($"Hotkey {explicitHotkey} fue registrado exitosamente");
            else
                Console.WriteLine($"No se pudo registrar el hotkey {explicitHotkey}");
        }

        public void HandleHotKey(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    Console.WriteLine("La tecla r fue presionada");
                }
            }
        }
    }
}
