namespace ProjetoSBL
{
    partial class Form4Opcoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadescola = new System.Windows.Forms.Button();
            this.btnCadLista = new System.Windows.Forms.Button();
            this.btnCadLivro = new System.Windows.Forms.Button();
            this.btneditarescola = new System.Windows.Forms.Button();
            this.btneditarlista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadescola
            // 
            this.btnCadescola.Location = new System.Drawing.Point(12, 41);
            this.btnCadescola.Name = "btnCadescola";
            this.btnCadescola.Size = new System.Drawing.Size(110, 23);
            this.btnCadescola.TabIndex = 0;
            this.btnCadescola.Text = "Cadastrar escola";
            this.btnCadescola.UseVisualStyleBackColor = true;
            this.btnCadescola.Click += new System.EventHandler(this.btnCadescola_Click);
            // 
            // btnCadLista
            // 
            this.btnCadLista.Location = new System.Drawing.Point(12, 110);
            this.btnCadLista.Name = "btnCadLista";
            this.btnCadLista.Size = new System.Drawing.Size(110, 23);
            this.btnCadLista.TabIndex = 1;
            this.btnCadLista.Text = "Cadastrar lista";
            this.btnCadLista.UseVisualStyleBackColor = true;
            this.btnCadLista.Click += new System.EventHandler(this.btnCadLista_Click);
            // 
            // btnCadLivro
            // 
            this.btnCadLivro.Location = new System.Drawing.Point(12, 188);
            this.btnCadLivro.Name = "btnCadLivro";
            this.btnCadLivro.Size = new System.Drawing.Size(110, 23);
            this.btnCadLivro.TabIndex = 2;
            this.btnCadLivro.Text = "Cadastrar livro";
            this.btnCadLivro.UseVisualStyleBackColor = true;
            this.btnCadLivro.Click += new System.EventHandler(this.btnCadLivro_Click);
            // 
            // btneditarescola
            // 
            this.btneditarescola.Location = new System.Drawing.Point(213, 41);
            this.btneditarescola.Name = "btneditarescola";
            this.btneditarescola.Size = new System.Drawing.Size(97, 23);
            this.btneditarescola.TabIndex = 3;
            this.btneditarescola.Text = "Editar escola";
            this.btneditarescola.UseVisualStyleBackColor = true;
            this.btneditarescola.Click += new System.EventHandler(this.btneditarescola_Click);
            // 
            // btneditarlista
            // 
            this.btneditarlista.Location = new System.Drawing.Point(213, 110);
            this.btneditarlista.Name = "btneditarlista";
            this.btneditarlista.Size = new System.Drawing.Size(97, 23);
            this.btneditarlista.TabIndex = 4;
            this.btneditarlista.Text = "Editar lista";
            this.btneditarlista.UseVisualStyleBackColor = true;
            this.btneditarlista.Click += new System.EventHandler(this.btneditarlista_Click);
            // 
            // Form4Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.btneditarlista);
            this.Controls.Add(this.btneditarescola);
            this.Controls.Add(this.btnCadLivro);
            this.Controls.Add(this.btnCadLista);
            this.Controls.Add(this.btnCadescola);
            this.Name = "Form4Opcoes";
            this.Text = "Form4Opcoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadescola;
        private System.Windows.Forms.Button btnCadLista;
        private System.Windows.Forms.Button btnCadLivro;
        private System.Windows.Forms.Button btneditarescola;
        private System.Windows.Forms.Button btneditarlista;
    }
}