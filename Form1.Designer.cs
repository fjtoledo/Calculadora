namespace Calculadora
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
            this.btn_um = new System.Windows.Forms.Button();
            this.tbx_display = new System.Windows.Forms.TextBox();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_sete = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_um
            // 
            this.btn_um.Location = new System.Drawing.Point(12, 210);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(75, 75);
            this.btn_um.TabIndex = 0;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // tbx_display
            // 
            this.tbx_display.Location = new System.Drawing.Point(13, 13);
            this.tbx_display.Multiline = true;
            this.tbx_display.Name = "tbx_display";
            this.tbx_display.ReadOnly = true;
            this.tbx_display.Size = new System.Drawing.Size(317, 110);
            this.tbx_display.TabIndex = 1;
            this.tbx_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_dois
            // 
            this.btn_dois.Location = new System.Drawing.Point(93, 210);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(75, 75);
            this.btn_dois.TabIndex = 2;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.Location = new System.Drawing.Point(174, 210);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(75, 75);
            this.btn_tres.TabIndex = 3;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = true;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.Location = new System.Drawing.Point(12, 291);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(75, 75);
            this.btn_quatro.TabIndex = 4;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = true;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Location = new System.Drawing.Point(93, 291);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(75, 75);
            this.btn_cinco.TabIndex = 5;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Location = new System.Drawing.Point(174, 291);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(75, 75);
            this.btn_seis.TabIndex = 6;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_sete
            // 
            this.btn_sete.Location = new System.Drawing.Point(12, 372);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(75, 75);
            this.btn_sete.TabIndex = 7;
            this.btn_sete.Text = "7";
            this.btn_sete.UseVisualStyleBackColor = true;
            this.btn_sete.Click += new System.EventHandler(this.btn_sete_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.Location = new System.Drawing.Point(93, 372);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(75, 75);
            this.btn_oito.TabIndex = 8;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = true;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.Location = new System.Drawing.Point(174, 372);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(75, 75);
            this.btn_nove.TabIndex = 9;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = true;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // btn_mais
            // 
            this.btn_mais.Location = new System.Drawing.Point(255, 210);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(75, 75);
            this.btn_mais.TabIndex = 10;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(255, 291);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 75);
            this.btn_min.TabIndex = 11;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(255, 372);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 75);
            this.btn_mult.TabIndex = 12;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(255, 453);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 75);
            this.btn_div.TabIndex = 13;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(93, 453);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(75, 75);
            this.btn_zero.TabIndex = 14;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(175, 454);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(75, 75);
            this.btn_igual.TabIndex = 15;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_virgula
            // 
            this.btn_virgula.Location = new System.Drawing.Point(12, 453);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.Size = new System.Drawing.Size(75, 75);
            this.btn_virgula.TabIndex = 16;
            this.btn_virgula.Text = ",";
            this.btn_virgula.UseVisualStyleBackColor = true;
            this.btn_virgula.Click += new System.EventHandler(this.btn_virgula_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(255, 129);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 75);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "C";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 550);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.tbx_display);
            this.Controls.Add(this.btn_um);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.TextBox tbx_display;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_sete;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_nove;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_virgula;
        private System.Windows.Forms.Button btn_limpar;
    }
}

