using Autoclicker.Utils;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class mainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        private readonly HotkeyConfig hotkeyConfig;
        public mainForm()
        {
            InitializeComponent();

            this.hotkeyConfig = new HotkeyConfig(this.Handle);
            this.hotkeyConfig.RegisterByUser('S');
        }

        protected override void WndProc(ref Message m) // Metodo interno del sistema que escucha por la Hotkey  NO TOCAR!!!!
        {
            // Metodo para escuchar hotkey
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    Console.WriteLine("La tecla r fue presionada");
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            startButton = new Button();
            stopButton = new Button();
            changeHotkeyButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(620, 321);
            startButton.Name = "startButton";
            startButton.Size = new Size(190, 73);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(205, 370);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(190, 73);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // changeHotkeyButton
            // 
            changeHotkeyButton.Location = new Point(350, 205);
            changeHotkeyButton.Name = "changeHotkeyButton";
            changeHotkeyButton.Size = new Size(100, 25);
            changeHotkeyButton.TabIndex = 3;
            changeHotkeyButton.Text = "Change Hotkey";
            changeHotkeyButton.UseVisualStyleBackColor = true;
            changeHotkeyButton.Click += button1_Click;
            // 
            // mainForm
            // 
            ClientSize = new Size(960, 529);
            Controls.Add(changeHotkeyButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainForm";
            Text = "Autoclicker";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            AutoStroke test = new AutoStroke('r'.ToString());

            test.KeyStroke();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
