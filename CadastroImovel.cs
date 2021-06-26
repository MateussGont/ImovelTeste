using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.
using Correios;
using System.Data.SqlClient;

namespace ImovelTeste
{
    public partial class CadastroImovel : Form
    {
        public CadastroImovel()
        {
            InitializeComponent();
        }
        private void CadastroImovel_Load(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCEP.Text) || txtCEP.Text == "     -")
            {
                MessageBox.Show("O campo CEP esta vazio!", "Atenção!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(txtCEP.Text);
                    txtRua.Text = retorno.end;
                    txtBairro.Text = retorno.bairro;
                    txtCidade.Text = retorno.cidade;
                    txtUF.Text = retorno.uf;
                }
                catch(Exception invalid)
                {
                    MessageBox.Show("O CEP inserido é invalido!", "Atenção!", MessageBoxButtons.OK)
                }
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
