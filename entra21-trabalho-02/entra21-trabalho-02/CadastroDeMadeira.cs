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
    public partial class Cadastro_de_madeira : Form
    {
        public Cadastro_de_madeira()
        {
            InitializeComponent();
  
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbHigrospicidade.Value == -1)
            {
                MessageBox.Show("Higrospicidade deve ser preenchido corretamente !");
            }

            if (tbFlexibilidade.Value == -1)
            {
                MessageBox.Show("Flexibilidade deve ser preenchido corretamente !");
            }

            if (tbDurabilidade.Value == -1)
            {
                MessageBox.Show("Durabilidade deve ser preenchido corretamente !");
            }

            if (tbResistenciaCompressao.Value == -1)
            {
                MessageBox.Show("Resistência a compressão deve ser preenchido corretamente !");
            }

            if (tbResistenciaTraccao.Value == -1)
            {
                MessageBox.Show("Resistência a tracção deve ser preenchido corretamente !");
            }

            if (tbResistenciaFlexao.Value == -1)
            {
                MessageBox.Show("Resistência a flexão deve ser preenchido corretamente !");
            }

            if (tbQualidade.Value == -1)
            {
                MessageBox.Show("Qualidade deve ser preenchido corretamente !");
            }

            if (nupTempoExistencia.Value == -1)
            {
                MessageBox.Show("Tempo de existência deve ser preenchido corretamente !");
            }

            if (txtLocalDeExtracao.Text.Length < 4 )
            {
                MessageBox.Show("Local de extração deve ser preenchido corretamente !");
            }

            if (txtPrecoUnidade.Text.Length <= 1)
            {
                MessageBox.Show("Preço por unidade deve ser preenchido corretamente !");
            }

            if (txtDemanda.Text.Length == 0)
            {
                MessageBox.Show("Demanda deve ser preenchido corretamente !");
            }

            if (txtDestino.Text.Length <= 3)
            {
                MessageBox.Show("Destino deve ser preenchido corretamente !");
            }

            if (nupQuantidadeCaminhoesDisponiveis.Value == -1)
            {
                MessageBox.Show("Quantidade de camnhões disponíveis deve ser preenchido corretamente !");
            }

            try
            {
                string localDeExtracao = txtLocalDeExtracao.Text;
            }
            catch
            {
                MessageBox.Show("Local de extração deve ser preenchido corretramente");
                txtLocalDeExtracao.Focus();
                return;
            }

            try
            {
                int demanda = Convert.ToInt32(txtDemanda.Text);
            }
            catch
            {
                MessageBox.Show("Demanda deve ser preenchido corretamente !");
                txtDemanda.Focus();
                return;
            }

            try
            {
                int tempoDeExistencia = Convert.ToInt32(nupTempoExistencia.Value);
            }
            catch
            {
                MessageBox.Show("Tempo de existência deve ser preenchido corretamente !");
                nupTempoExistencia.Focus();
                return;
            }

            try
            {
                double precoPorUnidade = Convert.ToDouble(txtPrecoUnidade.Text);
            }
            catch
            {
                MessageBox.Show("Preço por unidade deve ser preenchido corretamente !");
                txtPrecoUnidade.Focus();
                return;
            }

            try
            {
                string destino = txtDestino.Text;
            }
            catch
            {
                MessageBox.Show("Destino deve ser preenchido corretamente !");
                txtDestino.Focus();
                return;
            }

            try
            {
                int QuantidadeDeCaminhoesDisponiveis = Convert.ToInt32(nupQuantidadeCaminhoesDisponiveis.Value);
            }
            catch
            {
                MessageBox.Show("Quantidade de caminhões disponíveis deve ser preenchido corretamente");
                nupQuantidadeCaminhoesDisponiveis.Focus();
                return;
            }

            Madeira madeira = new Madeira()
            {
                LocalDeExtracao = txtLocalDeExtracao.Text,
                Demanda = Convert.ToInt32(txtDemanda.Text),
                TempoDeExistencia = Convert.ToInt32(nupTempoExistencia.Value),
                PrecoPorUnidade = Convert.ToDouble(txtPrecoUnidade.Text),
                Destino = txtDestino.Text,
                QuantidadeDeCaminhoesDisponiveis = Convert.ToInt32(nupQuantidadeCaminhoesDisponiveis.Value),

            };

            LimparCampos();
           
        }
        private void LimparCampos()
        {
            txtLocalDeExtracao.Text = "";
            txtDemanda.Text = "";
            nupTempoExistencia.Value = 0;
            txtPrecoUnidade.Text = "";
            txtDestino.Text = "";
            nupQuantidadeCaminhoesDisponiveis.Value = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        }      
    }

