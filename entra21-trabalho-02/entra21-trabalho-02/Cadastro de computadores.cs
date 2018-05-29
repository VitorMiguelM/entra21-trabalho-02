using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entra21_trabalho_02
{
    public partial class Cadastro_de_computadores : Form
    {

        private int posicao = -1;

        public Cadastro_de_computadores()
        {
            InitializeComponent();
        }

        



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
            }
            catch 
            {
                MessageBox.Show("Nome deve ser preenchido apenas com Letras");
                txtNome.Focus();
                return;
            }
            try
            {
                string gabinete = txtGabinete.Text;
            }
            catch
            {
                MessageBox.Show("Gabinete deve conter apenas letras");
                txtGabinete.Focus();
                return;
            }
            try
            {
                string processador = txtProcessador.Text;
            }
            catch
            {
                MessageBox.Show("Processador deve conter apenas letras");
                txtProcessador.Focus();
                return;
            }
            try
            {
                string placaDeVideo = txtPlacaDeVideo.Text;
            }
            catch 
            {
                MessageBox.Show("Placa de video de conter apenas letras");
                txtPlacaDeVideo.Focus();
                return;
            }
            try
            {
                double ram = Convert.ToDouble(txtRAM.Text);
            }
            catch
            {
                MessageBox.Show("Ram deve conter apenas números");
                txtRAM.Focus();
                return;
            }
            try
            {
                double HD = Convert.ToDouble(txtHD.Text);
            }
            catch
            {
                MessageBox.Show("HD deve conter apenas números");
                txtHD.Focus();
                return;
            }
            try
            {
                double fonte = Convert.ToDouble(txtFonte.Text);
            }
            catch
            {
                MessageBox.Show("Fonte deve conter apenas números");
                txtFonte.Focus();
                return;
            }
            try
            {
                string placaMae = txtPlacaMae.Text;
            }
            catch
            {
                MessageBox.Show("Placa mãe deve conter apenas letras");
                txtPlacaMae.Focus();
                return;
            }
            try
            {
                string cidade = txtCidade.Text;
            }
            catch
            {
                MessageBox.Show("Cidade deve conter apenas letras");
                txtCidade.Focus();
                return;
            }



            if (txtNome.Text.Length < 0)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres");
                txtNome.Focus();
                return;
            }
            if (txtGabinete.Text.Length == 0)
            {
                MessageBox.Show("Gabinete deve ser preenchido");
                txtGabinete.Focus();
                return;
            }
            if (txtProcessador.Text.Length == 0)
            {
                MessageBox.Show("Processador deve ser preenchido corretamente");
                txtProcessador.Focus();
                return;
            }
            if (txtPlacaDeVideo.Text.Length == 0)
            {
                MessageBox.Show("Placa de video de ser preenchido");
                txtPlacaDeVideo.Focus();
                return;
            }
            if (txtRAM.Text.Length == 0)
            {
                MessageBox.Show("RAM deve ser preenchido");
                txtRAM.Focus();
                return;
            }
            if (txtHD.Text.Length == 0)
            {
                MessageBox.Show("HD deve ser preenchido");
                txtHD.Focus();
                return;
            }
            if (txtFonte.Text.Length == 0)
            {
                MessageBox.Show("Fonte deve ser preenchido");
                txtFonte.Focus();
                return;
            }
            if (txtPlacaMae.Text.Length == 0)
            {
                MessageBox.Show("Placa mãe deve ser preenchida");
                txtPlacaMae.Focus();
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("E-mail deve ser preenchido");
                txtEmail.Focus();
                return;
            }
            if (mtbTelefone.Text.Length == 0)
            {
                MessageBox.Show("Telefone deve ser preenchido ");
                mtbTelefone.Focus();
                return;
            }
            if (txtCidade.Text.Length == 0) 
            {
                MessageBox.Show("Cidade deve ser preenchido");
                txtCidade.Focus();
                return;
            }
            Computador computador = new Computador()
            {
                Nome = txtNome.Text,
                Gabinete = txtGabinete.Text,
                Processador = txtProcessador.Text,
                PlacaDeVideo = txtPlacaDeVideo.Text,
                RAM = Convert.ToDouble(txtRAM.Text),
                HD = Convert.ToDouble(txtHD.Text),
                Fonte = Convert.ToDouble(txtFonte.Text),
                PlacaMae = txtPlacaMae.Text,
                Email = txtEmail.Text,
                Telefone = mtbTelefone.Text,
                Cidade = txtCidade.Text,
            };

            if (posicao >= 0)
            {
                Program.computadores[posicao] = computador;
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            else
            {
                Program.computadores.Add(computador);
                MessageBox.Show("Cadastro realizado com sucesso");

            }


            LimparCampos();


        }
        private void LimparCampos()
        {

            txtNome.Text = "";
            txtGabinete.Text = "";
            txtProcessador.Text = "";
            txtPlacaDeVideo.Text = "";
            txtRAM.Text = "";
            txtHD.Text ="";
            txtFonte.Text = "";
            txtPlacaMae.Text = "";
            txtEmail.Text = "";
            mtbTelefone.Text = "";
            txtCidade.Text = "";
        }



    }
}
