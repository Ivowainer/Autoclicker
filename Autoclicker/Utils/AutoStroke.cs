namespace Autoclicker.Utils
{
    public class AutoStroke
    {

        private readonly string k;

        public AutoStroke(string k = "s") {  // TODO: SET DEFAULT KEY ON CONFIG YAML
            this.k = k;
        }

        public void keyStroke()
        {
                Thread.Sleep(3000);
                SendKeys.SendWait(k);

                Console.WriteLine(k);
        }
    }
}
