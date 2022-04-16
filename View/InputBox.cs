using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioEditor.View
{
    public partial class InputBox : Form
    {
        public string Value { get; private set; }

        public InputBox(string message, string title, Form owner = null)
        {
            InitializeComponent();
            lbMessage.Text = message;
            Text = title;
            Owner = owner;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Value = txtInput.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
