using Autoclicker.Utils;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            Console.WriteLine($"La tecla fue presionada");
            // Captura cuando se presiona el hotkey
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
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
            hotkeyChange = new TextBox();
            changeHotkeyButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(391, 152);
            startButton.Name = "startButton";
            startButton.Size = new Size(190, 73);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(391, 305);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(190, 73);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // hotkeyChange
            // 
            hotkeyChange.Location = new Point(21, 224);
            hotkeyChange.MaxLength = 1;
            hotkeyChange.Name = "hotkeyChange";
            hotkeyChange.PlaceholderText = "Hotkey";
            hotkeyChange.Size = new Size(100, 23);
            hotkeyChange.TabIndex = 2;
            // 
            // changeHotkeyButton
            // 
            changeHotkeyButton.Location = new Point(21, 253);
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
            Controls.Add(hotkeyChange);
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
            await Task.Delay(5000);


            //int a = Console.Read();
            //AutoStroke test = new AutoStroke(Convert.ToChar(a).ToString());

            //test.keyStroke();

            MessageBox.Show("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
