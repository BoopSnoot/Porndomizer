using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://pornhub.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random RandomMachine = new Random();
            int Select = RandomMachine.Next(1, 15);
            switch (Select)
            {
                case 1:
                    Process.Start("https://xvideos.com");
                    break;
                case 2:
                    Process.Start("https://fuq.com");
                    break;
                case 3:
                    Process.Start("https://porn.com");
                    break;
                case 4:
                    Process.Start("https://youporn.com");
                    break;
                case 5:
                    Process.Start("https://xnxx.com");
                    break;
                case 6:
                    Process.Start("https://xhamster.com");
                    break;
                case 7:
                    Process.Start("https://hentaihaven.org");
                    break;
                case 8:
                    Process.Start("https://youjizz.com");
                    break;
                case 9:
                    Process.Start("https://youngpornvideos.com");
                    break;
                case 10:
                    Form1 form = new Form1();
                    form.label1.Visible = true;
                    Process.Start("https://porzo.com");
                    break;
                case 11:
                    Process.Start("https://porno365.com");
                    break;
                case 12:
                    Process.Start("https://pornjam.com");
                    break;
                case 13:
                    Process.Start("https://redtube.com");
                    break;
                case 14:
                    Process.Start("https://pornhub.com");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://pornhub.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://porno365.com");
        }
    }
}
