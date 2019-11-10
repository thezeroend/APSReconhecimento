using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        public void SetaNome()
        {
            char[] Separador = { '|' };
            string NomeENivel = label4.Text;
            string[] split = NomeENivel.Split(Separador, StringSplitOptions.None);

            label4.Text = split[0];
            label3.Text = split[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "2" || label3.Text == "3")
            { 
                this.Hide();
                FrmPrincipal adicionar = new FrmPrincipal();
                adicionar.nomelbl.Text = label4.Text;
                adicionar.nivellbl.Text = label3.Text;
                adicionar.Closed += (s, args) => this.Close();
                adicionar.Show();
            }
            else
            {
                acessolbl.Text = "ACESSO NEGADO !!!";
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetaNome();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Registros registros = new Registros();
            registros.Closed += (s, args) => this.Close();
            registros.Show();
        }
    }
}
