using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_App_Win_Forms_Teste
{
    public partial class Form1 : Form
    {
        private bool travar;
        public Form1()
        {
            InitializeComponent();
            this.travar = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Hide();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            label2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            if (!this.travar)
            {
                label2.Text = "HAHAHA!";
                if (button3.Location.X < 430)
                {
                    button3.Location = new Point(430, 147);
                }
                else
                {
                    button3.Location = new Point(60, 147);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Nathan"))
            {
                this.travar = true;
                MessageBox.Show("Botão Travado");
                label2.Text = "Afff, droga ;-;";
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
                txtUserName.Clear();
                txtUserName.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Visible = checkBox1.Checked;
        }

        private void rdDesabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDesabilitado.Checked) txtUserName.Enabled = false;
            else txtUserName.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
