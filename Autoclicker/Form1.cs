using Autoclicker.Utils;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Autoclicker
{
    public partial class mainForm : Form
    {

        private readonly HotkeyConfig hotkeyConfig;

        private char customKey = 'S';  // TODO: Default y la que guarda el usuario

        public mainForm()
        {
            InitializeComponent();

            this.hotkeyConfig = new HotkeyConfig(this.Handle);
            this.hotkeyConfig.RegisterByUser(customKey);
        }

        protected override void WndProc(ref Message m) // Metodo interno del sistema que escucha por la Hotkey  NO TOCAR!!!!
        {
            // Metodo para escuchar hotkey
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    Console.WriteLine($"La tecla {customKey} fue presionada");
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
            hotkeyLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(593, 151);
            startButton.Name = "startButton";
            startButton.Size = new Size(190, 73);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(397, 151);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(190, 73);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // changeHotkeyButton
            // 
            changeHotkeyButton.Location = new Point(121, 199);
            changeHotkeyButton.Name = "changeHotkeyButton";
            changeHotkeyButton.Size = new Size(100, 25);
            changeHotkeyButton.TabIndex = 3;
            changeHotkeyButton.Text = "Change Hotkey";
            changeHotkeyButton.UseVisualStyleBackColor = true;
            changeHotkeyButton.Click += changeHotkeyButton_Click;
            // 
            // hotkeyLabel
            // 
            hotkeyLabel.AutoSize = true;
            hotkeyLabel.Location = new Point(121, 181);
            hotkeyLabel.Name = "hotkeyLabel";
            hotkeyLabel.Size = new Size(12, 15);
            hotkeyLabel.TabIndex = 4;
            hotkeyLabel.Text = "Current hotkey: " + customKey;
            // 
            // mainForm
            // 
            ClientSize = new Size(960, 529);
            Controls.Add(hotkeyLabel);
            Controls.Add(changeHotkeyButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainForm";
            Text = "Autoclicker";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
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

        private void changeHotkeyButton_Click(object sender, EventArgs k)
        {
            HotkeyWaitForm hotkeyWaitForm = new HotkeyWaitForm();
            hotkeyWaitForm.ShowDialog();
            customKey = hotkeyWaitForm.key;
            MessageBox.Show(customKey.ToString());
            hotkeyLabel.Text = $"Current hotkey: {customKey}";

            hotkeyConfig.RegisterByUser(customKey);
        }
    }
}
