
namespace IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_Altura = new System.Windows.Forms.TextBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Location = new System.Drawing.Point(21, 41);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(31, 13);
            this.LblPeso.TabIndex = 0;
            this.LblPeso.Text = "Peso";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(21, 113);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(34, 13);
            this.LblAltura.TabIndex = 1;
            this.LblAltura.Text = "Altura";
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(68, 38);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(100, 20);
            this.Txt_Peso.TabIndex = 2;
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(68, 106);
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(100, 20);
            this.Txt_Altura.TabIndex = 3;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(24, 169);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(75, 55);
            this.Btn_Calcular.TabIndex = 4;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(159, 188);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 5;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 256);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Txt_Altura);
            this.Controls.Add(this.Txt_Peso);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Índice de massa corporea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.TextBox Txt_Altura;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Limpar;
    }
}

