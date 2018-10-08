using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaigyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_kuso = Clipboard.GetText();
            string text_nice = text_kuso.Replace(Environment.NewLine, "");
            string text_verynice = text_nice.Replace(".", "." + Environment.NewLine + Environment.NewLine);
            Clipboard.SetText(text_verynice);
        }
    }
}
