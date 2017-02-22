#region using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string msg = BussineesLogicLayer.UserBLL.iniciarSesion(txtUser.Text, txtPass.Text);

            if(string.IsNullOrEmpty(msg)){
                MessageBox.Show("Bienvenido");
            }
            else{
                MessageBox.Show(msg);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
