namespace Autoclicker.Utils
{
    public class AutoStroke // AutoStroke class: Configures Key to simulate a key stroke
    {

        private readonly string k;

        public AutoStroke(string k = "s") {  // TODO: SET DEFAULT KEY ON CONFIG YAML
            this.k = k;
        }

        public async void KeyStroke() // Executes keystroke action
        {
            SendKeys.Send(k);

            await Task.Delay(2000);

            Console.WriteLine(k);
        }
    }
}