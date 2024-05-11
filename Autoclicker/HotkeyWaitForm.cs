using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class HotkeyWaitForm : Form
    {
        public char key { get; set; }
        public HotkeyWaitForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += HotkeyWaitForm_KeyDown;
        }
        private void HotkeyWaitForm_KeyDown(object sender, KeyEventArgs e)
        {
            key = (char)e.KeyCode;
            this.Close();
        }

        private void HotkeyWaitForm_Load(object sender, EventArgs e)
        {
        }
    }
}
