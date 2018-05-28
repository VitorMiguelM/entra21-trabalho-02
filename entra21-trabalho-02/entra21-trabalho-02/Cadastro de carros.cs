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
    public partial class Cadastro_de_carros : Form
    {
        private int posicao = -1;

        public Cadastro_de_carros()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeDaPessoa.Text;
            }
            catch
            {
                MessageBox.Show("Campo nome deve conter apenas letras xD");
                txtNomeDaPessoa.Focus();
                return;
            }
            try
            {
                string marca = txtMarca.Text;
            }
            catch
            {
                MessageBox.Show("Campo marca deve conter apenas letras");
                txtMarca.Focus();
                return;
            }
            try
            {
                double altura = Convert.ToDouble(txtAlturaDoCarro.Text);
            }
            catch
            {
                MessageBox.Show("Campo altura deve conter apenas números");
                txtAlturaDoCarro.Focus();
                return;
            }
            try
            {
                double peso = Convert.ToDouble(txtPesoDocarro.Text);
            }
            catch
            {
                MessageBox.Show("Campo peso deve conter apenas números");
                txtPesoDocarro.Focus();
                return;
            }
            try
            {
                string placa = mtbPlaca.Text;
            }
            catch
            {
                MessageBox.Show("Campo placa deve ser preenchido corretamente");
                mtbPlaca.Focus();
                return;
            }
            try
            {
                string cidade = txtCidade.Text;
            }
            catch
            {
                MessageBox.Show("Campo cidade deve ser preenchido apenas com letras");
                txtCidade.Focus();
                return;
            }
            try
            {
                string CPF = mtbCPF.Text;
            }
            catch
            {
                MessageBox.Show("Campo Cpf deve ser preenchido corretamente");
                mtbCPF.Focus();
                return;
            }
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
            }
            catch
            {
                MessageBox.Show("Campo idade deve ser preenchido apenas com números naturais");
                txtIdade.Focus();
                return;
            }
            try
            {
                string RG = mtbRG.Text;
            }
            catch
            {
                MessageBox.Show("Campo RG deve ser preenchido corretamente");
                mtbRG.Focus();
                return;
            }
            try
            {
                string Email = txtEmail.Text;
            }
            catch
            {
                MessageBox.Show("Campo email deve ser preenchido corretamente");
                txtEmail.Focus();
                return;
            }
            try
            {
                string telefone = mtbTelefone.Text;
            }
            catch
            {
                MessageBox.Show("Campo telefone deve ser preenchido apenas com números");
                mtbTelefone.Focus();
                return;
            }
            try
            {
                string profissao = txtProfissao.Text;
            }
            catch
            {
                MessageBox.Show("Campo profissao deve ser preenchido corretamente");
                txtProfissao.Focus();
                return;
            }






            if (txtNomeDaPessoa.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres");
                txtNomeDaPessoa.Focus();
                return;
            }
            if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("Campo Marca deve ser preenchido");
                txtMarca.Focus();
                return;
            }
            if (txtAlturaDoCarro.Text.Length == 0)
            {
                MessageBox.Show("Campo altura do carro deve ser preenchido");
                txtAlturaDoCarro.Focus();
                return;
            }
            if (txtPesoDocarro.Text.Length == 0)
            {
                MessageBox.Show("Campo peso do carro deve ser preenchido");
                txtPesoDocarro.Focus();
                return;
            }
            if (mtbPlaca.Text.Length == 0)
            {
                MessageBox.Show("Campo placa deve ser preenchido");
                mtbPlaca.Focus();
                return;
            }
            if (txtCidade.Text.Length == 0)
            {
                MessageBox.Show("Campo Cidade deve ser preenchido");
                txtCidade.Focus();
                return;
            }
            if (mtbCPF.Text.Length == 0)
            {
                MessageBox.Show("Campo CPF deve ser preenchido");
                mtbCPF.Focus();
                return;
            }
            if (txtIdade.Text.Length == 0)
            {
                MessageBox.Show("Campo idade deve ser preenchido");
                txtIdade.Focus();
                return;
            }
            if (mtbRG.Text.Length == 0)
            {
                MessageBox.Show("O campo RG deve ser preenchido");
                mtbRG.Focus();
                return;
            }
            if (rbMacho.Text.Length == 0)
            {
                MessageBox.Show("Campo sexo deve ser preenchido");
                rbMacho.Focus();
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Campo email deve ser preenchido");
                txtEmail.Focus();
                return;
            }
            if (mtbTelefone.Text.Length == 0)
            {
                MessageBox.Show("Campo telefone deve ser preenchido");
                mtbTelefone.Focus();
                return;
            }
            if (txtProfissao.Text.Length == 0)
            {
                MessageBox.Show("Campo Profissão deve ser preenchido");
                txtProfissao.Focus();
                return;
            }
            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Campo Estado deve ser preenchido");
                cbEstado.DroppedDown = true;
                return;
            }
            
            Carros carros = new Carros()
            {
                NomeDaPessoa = txtNomeDaPessoa.Text,
                Marca = txtMarca.Text,
                Altura = Convert.ToDouble(txtAlturaDoCarro.Text),
                Peso = Convert.ToDouble(txtPesoDocarro.Text),
                Placa = mtbPlaca.Text,
                Cidade = txtCidade.Text,
                CPF = mtbCPF.Text,
                Idade = Convert.ToInt32(txtIdade.Text),
                RG = mtbRG.Text,
                Macho = rbMacho.Checked,
                Email = txtEmail.Text,
                Telefone = mtbTelefone.Text,
                Profissao = txtProfissao.Text,
                Estado = cbEstado.SelectedItem.ToString(),
            };
            if (posicao >= 0)
            {
                Program.carro[posicao] = carros;
                MessageBox.Show("CADASTRADO COM SUCESSO");
            }
            else
            {
                Program.carro.Add(carros);
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO");
            }

            LimparCampos();

        }
        private void LimparCampos()
        {
            txtNomeDaPessoa.Text = "";
            txtMarca.Text = "";
            txtAlturaDoCarro.Text = "";
            txtPesoDocarro.Text = "";
            mtbPlaca.Text = "";
            txtCidade.Text = "";
            mtbCPF.Text = "";
            txtIdade.Text = "";
            mtbRG.Text = "";
            rbMacho.Text = "";
            rbMulher.Text = "";
            txtEmail.Text = "";
            txtEmail.Text = "";
            mtbTelefone.Text = "";
            txtProfissao.Text = "";
            cbEstado.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    
}
