using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace MultiFaceRec
{
    public partial class Registros : Form
    {
        private string caminhoArquivo = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        public Registros()
        {
            InitializeComponent();

            if (nvlAcessolbl.Text == "1")
            {
                caminhoArquivo = caminhoArquivo + @"\Resource\Banco.xml";
            }
            else if ( nvlAcessolbl.Text == "2" )
            {
                caminhoArquivo = caminhoArquivo + @"\Resource\Banco2.xml";
            }
            else if ( nvlAcessolbl.Text == "3" )
            {
                caminhoArquivo = caminhoArquivo + @"\Banco.xml";
            }

            try
            {
                DataSet dsResultado = new DataSet();
                // Console.WriteLine(caminhoArquivo);
                dsResultado.ReadXml(caminhoArquivo);
                if (dsResultado.Tables.Count != 0)
                {
                    if (dsResultado.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dsResultado.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Painel painel = new Painel();
            painel.label3.Text = nvlAcessolbl.Text;
            painel.label4.Text = nomelbl.Text;
            painel.Closed += (s, args) => this.Close();
            painel.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
