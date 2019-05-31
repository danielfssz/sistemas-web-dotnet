namespace TesteWebApi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnObterProdutos = new System.Windows.Forms.Button();
            this.btnProdutosPorId = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.btnAtualizaProduto = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(38, 6);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(371, 20);
            this.txtURI.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(38, 32);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(653, 369);
            this.dgvDados.TabIndex = 2;
            // 
            // btnObterProdutos
            // 
            this.btnObterProdutos.Location = new System.Drawing.Point(38, 407);
            this.btnObterProdutos.Name = "btnObterProdutos";
            this.btnObterProdutos.Size = new System.Drawing.Size(102, 20);
            this.btnObterProdutos.TabIndex = 3;
            this.btnObterProdutos.Text = "Get All";
            this.btnObterProdutos.UseVisualStyleBackColor = true;
            this.btnObterProdutos.Click += new System.EventHandler(this.btnObterProdutos_Click);
            // 
            // btnProdutosPorId
            // 
            this.btnProdutosPorId.Location = new System.Drawing.Point(146, 407);
            this.btnProdutosPorId.Name = "btnProdutosPorId";
            this.btnProdutosPorId.Size = new System.Drawing.Size(75, 20);
            this.btnProdutosPorId.TabIndex = 4;
            this.btnProdutosPorId.Text = "Get By Id";
            this.btnProdutosPorId.UseVisualStyleBackColor = true;
            this.btnProdutosPorId.Click += new System.EventHandler(this.btnProdutosPorId_Click);
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Location = new System.Drawing.Point(227, 407);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(75, 20);
            this.btnIncluirProduto.TabIndex = 5;
            this.btnIncluirProduto.Text = "Insert";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // btnAtualizaProduto
            // 
            this.btnAtualizaProduto.Location = new System.Drawing.Point(318, 407);
            this.btnAtualizaProduto.Name = "btnAtualizaProduto";
            this.btnAtualizaProduto.Size = new System.Drawing.Size(75, 20);
            this.btnAtualizaProduto.TabIndex = 6;
            this.btnAtualizaProduto.Text = "Update";
            this.btnAtualizaProduto.UseVisualStyleBackColor = true;
            this.btnAtualizaProduto.Click += new System.EventHandler(this.btnAtualizaProduto_Click);
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(399, 407);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(75, 20);
            this.btnDeletarProduto.TabIndex = 7;
            this.btnDeletarProduto.Text = "Delete";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            this.btnDeletarProduto.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(415, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAtualizaProduto);
            this.Controls.Add(this.btnIncluirProduto);
            this.Controls.Add(this.btnProdutosPorId);
            this.Controls.Add(this.btnObterProdutos);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnObterProdutos;
        private System.Windows.Forms.Button btnProdutosPorId;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Button btnAtualizaProduto;
        private System.Windows.Forms.Button btnDeletarProduto;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

