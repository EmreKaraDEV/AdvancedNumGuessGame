using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedNumGuessGame
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }
        public Form1 form1; //Form1 will add itself.

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://emreki.art.blog/"}") { CreateNoWindow = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://www.youtube.com/c/EmreKaraTV"}") { CreateNoWindow = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://github.com/EmreKaraDEV"}") { CreateNoWindow = true });
        }
    }
}
