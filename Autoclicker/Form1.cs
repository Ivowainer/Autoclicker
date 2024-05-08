using System.Windows.Forms;

namespace Autoclicker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            SuspendLayout();
            ClientSize = new Size(631, 384);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainForm";
            Text = "Autoclicker";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
    }
}
