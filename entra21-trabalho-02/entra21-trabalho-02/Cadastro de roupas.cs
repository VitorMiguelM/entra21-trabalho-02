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
    public partial class Cadastro_de_roupas : Form
    {
        private int posicao = -1;
        public Cadastro_de_roupas()
        {
            InitializeComponent();
            for (int i = 8; i <= 60; i++)
            {
                cbTamanho.Items.Add(i);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no minímo 4 caracteres");
                txtNome.Focus();
                return;
            }
            if (cbTamanho.SelectedIndex < 0)
            {
                MessageBox.Show("Tamanho deve ser preenchido");
                cbTamanho.DroppedDown = true;
                return;
            }
            if (txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Altura deve ser preenchido");
                txtAltura.Focus();
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Email deve ser preenchido");
                txtEmail.Focus();
                return;
            }
            if (mtbTelefone.Text.Length == 0)
            {
                MessageBox.Show("Telefone deve ser preenchido");
                mtbTelefone.Focus();
                return;
            }
            if (txtCidade.Text.Length == 0)
            {
                MessageBox.Show("Cidade deve ser rpeenchido");
                txtCidade.Focus();
                return;
            }
            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Estado deve ser preenchido");
                cbEstado.DroppedDown = true;
                return;
            }
            if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("Marca deve ser preenchido");
                txtMarca.Focus();
                return;
            }


            try
            {
                string nome = txtNome.Text;
            }
            catch
            {
                MessageBox.Show("Nome deve conter apenas letras");
                txtNome.Focus();
                return;
            }
            try
            {
                double altura =Convert.ToDouble(txtAltura.Text);
            }
            catch
            {
                MessageBox.Show("Altura deve conter apenas números");
                txtAltura.Focus();
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
            try
            {
                string marca = txtMarca.Text;
            }
            catch
            {
                MessageBox.Show("Marca deve conter apenas letras");
                txtMarca.Focus();
                return;
            }

            Roupas roupas = new Roupas()
            {
                Nome = txtNome.Text,
                Tamanho = cbTamanho.SelectedIndex.ToString(),
                Altura = Convert.ToDouble(txtAltura.Text),
                Telefone = mtbTelefone.Text,
                Cidade = txtCidade.Text,
                Estado = cbEstado.SelectedIndex.ToString(),
                Marca = txtMarca.Text,
                Email = txtEmail.Text,
            };

            if (posicao >= 0)
            {
                Program.roupas[posicao] = roupas;
                MessageBox.Show("Cadastrado co  sucesso xD");
            }
            else
            {
                Program.roupas.Add(roupas);
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            ListarCampos();
        }
        private void ListarCampos()
        {
            txtNome.Text = "";
            cbTamanho.SelectedIndex = -1;
            txtAltura.Text = "";
            txtEmail.Text = "";
            mtbTelefone.Text = "";
            txtCidade.Text = "";
            cbEstado.SelectedIndex = -1;
            txtMarca.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        

       
    }
}
