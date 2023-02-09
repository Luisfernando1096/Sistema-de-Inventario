using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.GUI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int n = 0;

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            label2.Text = "Cargando... " + n.ToString() + "%";
            progressBar1.Value = n;

            if(n == 100)
            {
                this.Hide();
                timer1.Stop();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
