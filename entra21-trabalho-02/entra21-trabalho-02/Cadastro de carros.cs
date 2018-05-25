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
        

        public Cadastro_de_carros()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            //Validação

            try
            {
                string nomeDaPessoa = txtNomeDaPessoa.Text;
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas palavras/letras xD");
                txtNomeDaPessoa.Focus();
                return;
            }
            try
            {
                string marca = txtMarca.Text;
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas palavras/letras xD");
                txtMarca.Focus();
                return;
            }
            try
            {
                double alturaDoCarro = Convert.ToDouble(txtAlturaDoCarro.Text);
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas Números xD");
                txtAlturaDoCarro.Focus();
                return;
            }
            try
            {
                double pesoDoCarro = Convert.ToDouble(txtPesoDocarro.Text);
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas Números xD");
                txtCidade.Focus();
                return;
            }
            try
            {
                int placaDoCarro = Convert.ToInt32(mtbPlaca.Text);
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas Números xD");
                mtbPlaca.Focus();
                return;
            }
            try
            {
                string cidade = txtCidade.Text;
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas palavras/letras xD");
                txtCidade.Focus();
                return;
            }
            try
            {
                int cpf = Convert.ToInt32(mtbCPF.Text);
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas Números xD");
                mtbCPF.Focus();
                return;
            }
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas Números xD");
                txtIdade.Focus();
                return;
            }
            try
            {
                int rg = Convert.ToInt32(mtbRG.Text);
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas Números xD");
                mtbRG.Focus();
                return;
            }
            try
            {
                string email = txtEmail.Text;
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas palavras/letras xD");
                txtEmail.Focus();
                return;
            }
            try
            {
                string profissao = txtProfissao.Text;
            }
            catch
            {
                MessageBox.Show("HAHA muito engraçadinho,apenas palavras/letras xD");
                txtProfissao.Focus();
                return;
            }





        } 
    }
}
