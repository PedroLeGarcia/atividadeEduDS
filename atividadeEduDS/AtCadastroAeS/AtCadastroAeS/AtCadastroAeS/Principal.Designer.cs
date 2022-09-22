
namespace AtCadastroAeS
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cliente2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtos2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pdUsuario = new System.Drawing.Printing.PrintDocument();
            this.ppdUsuario = new System.Windows.Forms.PrintPreviewDialog();
            this.pdCliente = new System.Drawing.Printing.PrintDocument();
            this.ppdCliente = new System.Windows.Forms.PrintPreviewDialog();
            this.pdProduto = new System.Drawing.Printing.PrintDocument();
            this.ppdProduto = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkKhaki;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.relatoriosToolStripMenuItem,
            this.sair});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1235, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario,
            this.cliente,
            this.produtos});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Cadastros";
            // 
            // usuario
            // 
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(122, 22);
            this.usuario.Text = "Usuários";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // cliente
            // 
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(122, 22);
            this.cliente.Text = "Clientes";
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // produtos
            // 
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(122, 22);
            this.produtos.Text = "Produtos";
            this.produtos.Click += new System.EventHandler(this.produtos_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario2,
            this.cliente2,
            this.produtos2});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // usuario2
            // 
            this.usuario2.Name = "usuario2";
            this.usuario2.Size = new System.Drawing.Size(180, 22);
            this.usuario2.Text = "Usuários";
            this.usuario2.Click += new System.EventHandler(this.usuario2_Click);
            // 
            // cliente2
            // 
            this.cliente2.Name = "cliente2";
            this.cliente2.Size = new System.Drawing.Size(180, 22);
            this.cliente2.Text = "Clientes";
            this.cliente2.Click += new System.EventHandler(this.cliente2_Click);
            // 
            // produtos2
            // 
            this.produtos2.Name = "produtos2";
            this.produtos2.Size = new System.Drawing.Size(180, 22);
            this.produtos2.Text = "Produtos";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(38, 20);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(584, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exército Brasileiro: Braço forte, mão amiga.";
            // 
            // pdUsuario
            // 
            this.pdUsuario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdUsuario_PrintPage);
            // 
            // ppdUsuario
            // 
            this.ppdUsuario.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdUsuario.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdUsuario.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdUsuario.Document = this.pdUsuario;
            this.ppdUsuario.Enabled = true;
            this.ppdUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdUsuario.Icon")));
            this.ppdUsuario.Name = "ppdUsuario";
            this.ppdUsuario.Visible = false;
            // 
            // pdCliente
            // 
            this.pdCliente.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdCliente_PrintPage);
            // 
            // ppdCliente
            // 
            this.ppdCliente.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdCliente.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdCliente.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdCliente.Document = this.pdCliente;
            this.ppdCliente.Enabled = true;
            this.ppdCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdCliente.Icon")));
            this.ppdCliente.Name = "ppdCliente";
            this.ppdCliente.Visible = false;
            // 
            // pdProduto
            // 
            this.pdProduto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdProduto_PrintPage);
            // 
            // ppdProduto
            // 
            this.ppdProduto.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdProduto.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdProduto.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdProduto.Enabled = true;
            this.ppdProduto.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdProduto.Icon")));
            this.ppdProduto.Name = "ppdProduto";
            this.ppdProduto.Visible = false;
            // 
            // Principal
            // 
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1235, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Principal";
            this.Text = "Cadastro Exército";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuario;
        private System.Windows.Forms.ToolStripMenuItem cliente;
        private System.Windows.Forms.ToolStripMenuItem produtos;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuario2;
        private System.Windows.Forms.ToolStripMenuItem cliente2;
        private System.Windows.Forms.ToolStripMenuItem produtos2;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument pdUsuario;
        private System.Windows.Forms.PrintPreviewDialog ppdUsuario;
        private System.Drawing.Printing.PrintDocument pdCliente;
        private System.Windows.Forms.PrintPreviewDialog ppdCliente;
        private System.Drawing.Printing.PrintDocument pdProduto;
        private System.Windows.Forms.PrintPreviewDialog ppdProduto;
    }
}

