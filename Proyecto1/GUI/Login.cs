﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataManager.DBConexion o = new DataManager.DBConexion();

            if (o.Conectar())
            {
                MessageBox.Show("Conectado");
                o.Desconectar();
            }
            else
            {
                MessageBox.Show("No se conecto");
            }
        }
    }
}
