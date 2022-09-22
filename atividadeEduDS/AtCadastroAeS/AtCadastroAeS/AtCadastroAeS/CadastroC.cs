using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtCadastroAeS
{
    public partial class CadastroC : Form
    {
        bool tipoEdicao = false;
        int atual = 0;
        private void HabilitaEdicao()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEnd.Enabled = true;
            txtRG.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtCEP.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEnd.Enabled = false;
            txtRG.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtCEP.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        private void MostraDados()
        {
            txtCodigo.Text = Principal.cadastro[atual].codigo.ToString();
            txtNome.Text = Principal.cadastro[atual].nome;
            txtCPF.Text = Principal.cadastro[atual].cpf;
            txtEnd.Text = Principal.cadastro[atual].end;
            txtRG.Text = Principal.cadastro[atual].rg;
            txtBairro.Text = Principal.cadastro[atual].bairro;
            txtCidade.Text = Principal.cadastro[atual].cidade;
            txtUF.Text = Principal.cadastro[atual].uf;
            txtTelefone.Text = Principal.cadastro[atual].telefone;
            txtEmail.Text = Principal.cadastro[atual].email;
            txtCEP.Text = Principal.cadastro[atual].cep;
        }
        public CadastroC()
        {
            InitializeComponent();
        }
        
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                MostraDados();
            }
            else MessageBox.Show("Início do arquivo!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Principal.contUsuario < 10)
            {
                txtCodigo.Text = (Principal.contUsuario + 1).ToString();
                txtNome.Text = "";
                txtCPF.Text = "";
                txtEnd.Text = "";
                txtRG.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtCEP.Text = "";
                HabilitaEdicao();
                tipoEdicao = true;
            }
            else MessageBox.Show("Arquivo cheio!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Principal.contUsuario > 0)
            {
                HabilitaEdicao();
                tipoEdicao = false;
            }
            else MessageBox.Show("Arquivo vazio!");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                Principal.cadastro[Principal.contCadastro].codigo = int.Parse(txtCodigo.Text);
                Principal.cadastro[Principal.contCadastro].nome = txtNome.Text;
                Principal.cadastro[Principal.contCadastro].cpf = txtCPF.Text;
                Principal.cadastro[Principal.contCadastro].end = txtEnd.Text;
                Principal.cadastro[Principal.contCadastro].rg = txtRG.Text;
                Principal.cadastro[Principal.contCadastro].bairro = txtBairro.Text;
                Principal.cadastro[Principal.contCadastro].cidade = txtCidade.Text;
                Principal.cadastro[Principal.contCadastro].uf = txtUF.Text;
                Principal.cadastro[Principal.contCadastro].telefone = txtTelefone.Text;
                Principal.cadastro[Principal.contCadastro].email = txtEmail.Text;
                Principal.cadastro[Principal.contCadastro].cep = txtCEP.Text;
                atual = Principal.contCadastro++;
            }
            else
            {
                Principal.cadastro[Principal.contCadastro].nome = txtNome.Text;
                Principal.cadastro[Principal.contCadastro].cpf = txtCPF.Text;
                Principal.cadastro[Principal.contCadastro].end = txtEnd.Text;
                Principal.cadastro[Principal.contCadastro].rg = txtRG.Text;
                Principal.cadastro[Principal.contCadastro].bairro = txtBairro.Text;
                Principal.cadastro[Principal.contCadastro].cidade = txtCidade.Text;
                Principal.cadastro[Principal.contCadastro].uf = txtUF.Text;
                Principal.cadastro[Principal.contCadastro].telefone = txtTelefone.Text;
                Principal.cadastro[Principal.contCadastro].email = txtEmail.Text;
                Principal.cadastro[Principal.contCadastro].cep = txtCEP.Text;
            }
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostraDados();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

            if (atual < Principal.contUsuario - 1)
            {
                atual++;
                MostraDados();
            }
            else MessageBox.Show("Fim de arquivo!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Principal.contUsuario > 0)
            {
                txtCodigo.Text = (Principal.contCadastro + 1).ToString();
                txtNome.Text = "";
                txtCPF.Text = "";
                txtEnd.Text = "";
                txtRG.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtCEP.Text = "";
                MostraDados();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
            txtPesquisa2.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int z;
            for (z = 0; z < Principal.contUsuario; z++)
            {
                if (Principal.usuarios[z].nome.IndexOf(txtPesquisa2.Text) >= 0)
                {
                    atual = z;
                    MostraDados();
                    break;
                }
            }

            if (z >= Principal.contUsuario)
            {
                MessageBox.Show("Não Encontrado!");
            }
            pnlPesquisa.Visible = false;
        }

        private void btnCancelaPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
        }

        private void CadastroC_Load_1(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostraDados();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CLIENTES" + (char)10 + (char)10;
            strDados = strDados + "--------------------------------------------------------------------------------------------------------" + (char)10 + (char)10;
            strDados = strDados + "Código: " + txtCodigo.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + txtNome.Text + (char)10 + (char)10;
            strDados = strDados + "CPF: " + txtCPF.Text + (char)10 + (char)10;
            strDados = strDados + "RG: " + txtRG.Text;
            strDados = strDados + "Endereço: " + txtEnd.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + txtBairro.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + txtCidade.Text + (char)10 + (char)10;
            strDados = strDados + "UF: " + txtUF.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + txtCEP.Text + (char)10 + (char)10;
            strDados = strDados + "Telefone: " + txtTelefone.Text + (char)10 + (char)10;
            strDados = strDados + "Email: " + txtEmail.Text + (char)10 + (char)10;
            

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }


    }
}

