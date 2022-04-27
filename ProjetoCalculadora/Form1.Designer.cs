
namespace ProjetoCalculadora
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
            this.Subtrair = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Subtrair
            // 
            this.Subtrair.AccessibleDescription = "Botão para subtrair";
            this.Subtrair.AccessibleName = "Subtrair";
            this.Subtrair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subtrair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Subtrair.BackgroundImage")));
            this.Subtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Subtrair.Location = new System.Drawing.Point(197, 78);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(115, 92);
            this.Subtrair.TabIndex = 1;
            this.Subtrair.UseVisualStyleBackColor = false;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.AccessibleDescription = "Botão para multiplicar";
            this.Multiplicar.AccessibleName = "Multiplicar";
            this.Multiplicar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multiplicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Multiplicar.BackgroundImage")));
            this.Multiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Multiplicar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Multiplicar.Location = new System.Drawing.Point(319, 78);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(105, 92);
            this.Multiplicar.TabIndex = 2;
            this.Multiplicar.UseVisualStyleBackColor = false;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Dividir
            // 
            this.Dividir.AccessibleDescription = "Botão para dividir";
            this.Dividir.AccessibleName = "Dividir";
            this.Dividir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dividir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dividir.BackgroundImage")));
            this.Dividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dividir.Location = new System.Drawing.Point(73, 176);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(107, 93);
            this.Dividir.TabIndex = 3;
            this.Dividir.UseVisualStyleBackColor = false;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Potencia
            // 
            this.Potencia.AccessibleDescription = "Botão para potencia";
            this.Potencia.AccessibleName = "Potencia";
            this.Potencia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Potencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Potencia.BackgroundImage")));
            this.Potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Potencia.Location = new System.Drawing.Point(197, 176);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(115, 93);
            this.Potencia.TabIndex = 4;
            this.Potencia.UseVisualStyleBackColor = false;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Raiz
            // 
            this.Raiz.AccessibleDescription = "Botão para raiz";
            this.Raiz.AccessibleName = "Raiz";
            this.Raiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Raiz.BackgroundImage")));
            this.Raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Raiz.Location = new System.Drawing.Point(319, 176);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(105, 93);
            this.Raiz.TabIndex = 5;
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Soma
            // 
            this.Soma.AccessibleDescription = "Botão para somar";
            this.Soma.AccessibleName = "Soma";
            this.Soma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Soma.BackgroundImage")));
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soma.Location = new System.Drawing.Point(73, 78);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(107, 92);
            this.Soma.TabIndex = 6;
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Primeiro Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundo Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(518, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Subtrair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Claculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

