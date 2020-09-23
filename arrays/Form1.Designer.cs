namespace arrays
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
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnTestarTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(30, 34);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(327, 37);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "Testar Vetor";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnTestarTexto
            // 
            this.btnTestarTexto.Location = new System.Drawing.Point(64, 104);
            this.btnTestarTexto.Name = "btnTestarTexto";
            this.btnTestarTexto.Size = new System.Drawing.Size(277, 68);
            this.btnTestarTexto.TabIndex = 1;
            this.btnTestarTexto.Text = "Testar textos";
            this.btnTestarTexto.UseVisualStyleBackColor = true;
            this.btnTestarTexto.Click += new System.EventHandler(this.btnTestarTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 212);
            this.Controls.Add(this.btnTestarTexto);
            this.Controls.Add(this.btnTestar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnTestarTexto;
    }
}

