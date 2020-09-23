namespace Tratamento_erros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNdois = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSomaSinal = new System.Windows.Forms.Label();
            this.lblIgualSinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 125);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Soma";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 231);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(564, 50);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(15, 157);
            this.txtNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(156, 41);
            this.txtNum.TabIndex = 2;
            // 
            // txtNdois
            // 
            this.txtNdois.Location = new System.Drawing.Point(219, 157);
            this.txtNdois.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNdois.Name = "txtNdois";
            this.txtNdois.Size = new System.Drawing.Size(156, 41);
            this.txtNdois.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(423, 157);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(156, 41);
            this.txtResultado.TabIndex = 4;
            // 
            // lblSomaSinal
            // 
            this.lblSomaSinal.AutoSize = true;
            this.lblSomaSinal.Location = new System.Drawing.Point(183, 160);
            this.lblSomaSinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSomaSinal.Name = "lblSomaSinal";
            this.lblSomaSinal.Size = new System.Drawing.Size(24, 28);
            this.lblSomaSinal.TabIndex = 5;
            this.lblSomaSinal.Text = "+";
            // 
            // lblIgualSinal
            // 
            this.lblIgualSinal.AutoSize = true;
            this.lblIgualSinal.Location = new System.Drawing.Point(387, 160);
            this.lblIgualSinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIgualSinal.Name = "lblIgualSinal";
            this.lblIgualSinal.Size = new System.Drawing.Size(24, 28);
            this.lblIgualSinal.TabIndex = 6;
            this.lblIgualSinal.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 311);
            this.Controls.Add(this.lblIgualSinal);
            this.Controls.Add(this.lblSomaSinal);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNdois);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNdois;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSomaSinal;
        private System.Windows.Forms.Label lblIgualSinal;
    }
}

