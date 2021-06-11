namespace LerPDF
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
            this.txtCaminoNomePDF = new System.Windows.Forms.TextBox();
            this.btnConvertePDF = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivoTexto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCaminoNomePDF
            // 
            this.txtCaminoNomePDF.Location = new System.Drawing.Point(12, 21);
            this.txtCaminoNomePDF.Name = "txtCaminoNomePDF";
            this.txtCaminoNomePDF.Size = new System.Drawing.Size(360, 20);
            this.txtCaminoNomePDF.TabIndex = 0;
            // 
            // btnConvertePDF
            // 
            this.btnConvertePDF.Location = new System.Drawing.Point(13, 48);
            this.btnConvertePDF.Name = "btnConvertePDF";
            this.btnConvertePDF.Size = new System.Drawing.Size(75, 23);
            this.btnConvertePDF.TabIndex = 1;
            this.btnConvertePDF.Text = "Converter";
            this.btnConvertePDF.UseVisualStyleBackColor = true;
            this.btnConvertePDF.Click += new System.EventHandler(this.btnConvertePDF_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(379, 21);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // txtArquivoTexto
            // 
            this.txtArquivoTexto.Location = new System.Drawing.Point(13, 77);
            this.txtArquivoTexto.Multiline = true;
            this.txtArquivoTexto.Name = "txtArquivoTexto";
            this.txtArquivoTexto.Size = new System.Drawing.Size(431, 487);
            this.txtArquivoTexto.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(427, 487);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 576);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtArquivoTexto);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnConvertePDF);
            this.Controls.Add(this.txtCaminoNomePDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminoNomePDF;
        private System.Windows.Forms.Button btnConvertePDF;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox txtArquivoTexto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

