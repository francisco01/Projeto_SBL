namespace ProjetoSBL
{
    partial class Form12Compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.grdvexemplar = new System.Windows.Forms.DataGridView();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.comprar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdvexemplar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o Livro";
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(144, 41);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(121, 21);
            this.cmbLista.TabIndex = 2;
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
            // 
            // cmbLivro
            // 
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(144, 94);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(121, 21);
            this.cmbLivro.TabIndex = 3;
            this.cmbLivro.SelectedIndexChanged += new System.EventHandler(this.cmbLivro_SelectedIndexChanged);
            // 
            // grdvexemplar
            // 
            this.grdvexemplar.AllowUserToAddRows = false;
            this.grdvexemplar.AllowUserToDeleteRows = false;
            this.grdvexemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvexemplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprar});
            this.grdvexemplar.Location = new System.Drawing.Point(12, 149);
            this.grdvexemplar.Name = "grdvexemplar";
            this.grdvexemplar.ReadOnly = true;
            this.grdvexemplar.Size = new System.Drawing.Size(688, 163);
            this.grdvexemplar.TabIndex = 4;
            this.grdvexemplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvexemplar_CellContentClick);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(11, 6);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(65, 20);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // comprar
            // 
            this.comprar.DataPropertyName = "txt";
            this.comprar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comprar.HeaderText = "Comprar";
            this.comprar.Name = "comprar";
            this.comprar.ReadOnly = true;
            this.comprar.Text = "Comprar";
            this.comprar.UseColumnTextForButtonValue = true;
            // 
            // Form12Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 336);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.grdvexemplar);
            this.Controls.Add(this.cmbLivro);
            this.Controls.Add(this.cmbLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form12Compra";
            this.Text = "Form12Compra";
            this.Load += new System.EventHandler(this.Form12Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvexemplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.DataGridView grdvexemplar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridViewButtonColumn comprar;
    }
}