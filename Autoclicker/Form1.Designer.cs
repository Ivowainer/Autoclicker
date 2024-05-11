namespace Autoclicker
{
    partial class mainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button startButton;
        private Button stopButton;
        private Button changeHotkeyButton;
        private Label hotkeyLabel;
    }
}
