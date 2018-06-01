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
    public partial class Cadastro_de_móveis : Form
    {
        private int posicao = -1;

        public Cadastro_de_móveis()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
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
                string Endereco = txtEndereco.Text;
            }
            catch
            {
                MessageBox.Show("Endereco deve conter apenas letras");
                txtEndereco.Focus();
                return;
            }
            try
            {
                double preco = Convert.ToDouble(txtPreco.Text);
            }
            catch
            {
                MessageBox.Show("Preço deve conter apenas números");
                txtPreco.Focus();
                return;
            }
            try
            {
                string tipoDeMaterial = txtTipoDoMaterial.Text;
            }
            catch
            {
                MessageBox.Show("Tipo do material deve conter apenas letras");
                txtTipoDoMaterial.Focus();
                return;
            }
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
            }
            catch
            {
                MessageBox.Show("Peso deve conter apenas números");
                txtPeso.Focus();
                return;
            }
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
            }
            catch
            {
                MessageBox.Show("altura deve conter apenas números");
                txtAltura.Focus();
                return;
            }
            try
            {
                string RG = mtbRG.Text;
            }
            catch
            {
                MessageBox.Show("RG deve ser preenchido apenas com números");
                mtbRG.Focus();
                return;
            }
            try
            {
                string telefone = mtbTelefone.Text;
            }
            catch
            {
                MessageBox.Show("Telefone deve conter apenas números");
                mtbTelefone.Focus();
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
                MessageBox.Show("Marca deve ser preenchido apenas com letras");
                txtMarca.Focus();
                return;
            }
            try
            {
                string estado = cbEstado.Text;
            }
            catch
            {
                MessageBox.Show("Estado deve conter apenas letras");
                cbEstado.Focus();
                return;
            }





            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter mais de 4 letras");
                txtNome.Focus();
                return;
            }
            if (txtEndereco.Text.Length == 0)
            {
                MessageBox.Show("Endereço deve ser preenchido");
                txtEndereco.Focus();
                return;
            }
            if (txtPreco.Text.Length == 0)
            {
                MessageBox.Show("Preço deve ser preenchido");
                txtPreco.Focus();
                return;
            }
            if (txtTipoDoMaterial.Text.Length == 0)
            {
                MessageBox.Show("Tipo do material deve ser preenchido");
                txtTipoDoMaterial.Focus();
                return;
            }
            if (txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Peso deve ser preenchido");
                txtPeso.Focus();
                return;
            }
            if (txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Campo altura deve ser preenchido");
                txtAltura.Focus();
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Email deve ser preenchido");
                txtEmail.Focus();
                return;
            }
            if (rbMacho.Text.Length == 0)
            {
                MessageBox.Show("Campo sexo deve ser preenchido");
                rbMacho.Focus();
                return;
            }
            if (txtCidade.Text.Length == 0)
            {
                MessageBox.Show("Campo cidade deve ser preenchido");
                txtCidade.Focus();
                return;
            }

            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Campo estado deve ser preenchido");
                cbEstado.DroppedDown = true;
                return;
            }
            if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("Campo marca deve ser preenchido");
                txtMarca.Focus();
                return;
            }
            Moveis moveis = new Moveis()
            {
                nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                preco =Convert.ToDouble(txtPreco.Text),
                tipoMaterial = txtTipoDoMaterial.Text,
                peso = Convert.ToDouble(txtPeso.Text),
                altura = Convert.ToDouble(txtAltura.Text),
                email = txtEmail.Text,
                RG = mtbRG.Text,
                telefone = mtbTelefone.Text,
                cidade = txtCidade.Text,
                estado = cbEstado.SelectedItem.ToString(),
                marca = txtMarca.Text,
            };
            if (posicao >= 0)
            {
                Program.movel[posicao] =moveis ;
                MessageBox.Show("Cadastro alterado com sucesso");
            }
            else
            {
                Program.movel.Add(moveis);
                MessageBox.Show("Cadastro realizado com sucesso");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtPreco.Text = "";
            txtTipoDoMaterial.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtEmail.Text = "";
            mtbRG.Text = "";
            mtbTelefone.Text = "";
            txtCidade.Text = "";
            cbEstado.Text = "";
            txtMarca.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        

        

       
    }
}
