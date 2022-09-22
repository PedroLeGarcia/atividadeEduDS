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
    public partial class Principal : Form
    {
        public struct Usuar
        {
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }

        static public Usuar[] usuarios = new Usuar[10];
        static public int contUsuario = 0;

        public struct CadasC
        {
            public int codigo;
            public string nome;
            public string cpf;
            public string rg;
            public string end;
            public string bairro;
            public string cidade;
            public string uf;
            public string telefone;
            public string email;
            public string cep;
        }

        static public CadasC[] cadastro = new CadasC[10];
        static public int contCadastro = 0;

        public struct CadasP
        {
            public int codigo;
            public string desc;
            public string uni;
            public string qtd;
            public string pcC;
            public string pcV;
        }

        static public CadasP[] cadastrop = new CadasP[10];
        static public int contCadastrop = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            Usuario fu = new Usuario();
            fu.ShowDialog();
        }

        private void cliente_Click(object sender, EventArgs e)
        {
            CadastroC lol = new CadastroC();
            lol.ShowDialog();
        }

        private void produtos_Click(object sender, EventArgs e)
        {
            CadastroP lmao = new CadastroP();
            lmao.ShowDialog();
        }



        private void pdUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;



            while (cabecalho)
            {
                strDados = "                             RELATÓRIO DE USUÁRIOS" + (char)10;
                strDados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "                                                         Pág: " + pag.ToString("00") + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                strDados += "Código Nome                                     Nível Login" + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                itens = true;
                while (itens)
                {
                    strDados += usuarios[i].codigo.ToString("000000") + " " + usuarios[i].nome.PadRight(40) + "   " + usuarios[i].nivel + "   " + usuarios[i].login + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        strDados += (char)12;
                    }
                    if (i >= contUsuario)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }
            }
            objImpressao.DrawString(strDados, new Font("Courier New", 11, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void usuario2_Click(object sender, EventArgs e)
        {
            ppdUsuario.ShowDialog();
        }

        private void pdCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;
            while (cabecalho)
            {
                strDados = "                             RELATÓRIO DE CLIENTES " + (char)10;
                strDados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "                                                         Pág: " + pag.ToString("00") + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                strDados += "Código Nome CPF RG Endereço Bairro Cidade UF CEP Telefone Email ";
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                itens = true;
                while (itens)
                {
                    strDados += cadastro[i].codigo.ToString("000000") + " " + cadastro[i].nome.PadRight(40) + "   " + cadastro[i].cpf + "   " + cadastro[i].rg + "   " + cadastro[i].end + "   " + cadastro[i].bairro + "   " + cadastro[i].cidade + "   " + cadastro[i].uf + "   " + cadastro[i].cep + "   " + cadastro[i].telefone + "   " + cadastro[i].email + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        strDados += (char)12;
                    }
                    if (i >= contCadastro)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }


            }
            objImpressao.DrawString(strDados, new Font("Courier New", 11, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void cliente2_Click(object sender, EventArgs e)
        {
            ppdCliente.ShowDialog();
        }

        private void pdProduto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;
            while (cabecalho)
            {
                strDados = "                             RELATÓRIO DE PRODUTOS " + (char)10;
                strDados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "                                                         Pág: " + pag.ToString("00") + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                strDados += "Código   Descrição   Unidade   Quantidade   Preço de Custo   Preço de Venda ";
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                itens = true;
            }
            while (itens)
            {
                strDados += cadastro[i].codigo.ToString("000000") + " " + cadastrop[i].desc.PadRight(40) + "   " + cadastrop[i].uni + "   " + cadastrop[i].qtd + "   " + cadastrop[i].pcC + "   " + cadastrop[i].pcV + (char)10;
                linha++;
                i++;
                if (linha >= 64)
                {
                    itens = false;
                    strDados += (char)12;
                }
                if (i >= contCadastrop)
                {
                    itens = false;
                    cabecalho = false;
                }
            }
            objImpressao.DrawString(strDados, new Font("Courier New", 11, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}

    


