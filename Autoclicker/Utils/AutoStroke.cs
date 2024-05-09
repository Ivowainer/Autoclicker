namespace Autoclicker.Utils
{
    public class AutoStroke // AutoStroke class: Configures Key to simulate a key stroke
    {

        private readonly string k;

        public AutoStroke(string k = "s") {  // TODO: SET DEFAULT KEY ON CONFIG YAML
            this.k = k;
        }

        public async void keyStroke() // Executes keystroke action
        {
                SendKeys.Send(k);

                Console.WriteLine(k);
        }
    }
}