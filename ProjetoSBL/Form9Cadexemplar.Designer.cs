namespace ProjetoSBL
{
    partial class Form9Cadexemplar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.txtentrega = new System.Windows.Forms.TextBox();
            this.ckbDobra = new System.Windows.Forms.CheckBox();
            this.ckbAnot = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.btnCadexemp = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anotações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Situação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entrega";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(79, 144);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(100, 20);
            this.txtSituacao.TabIndex = 6;
            // 
            // txtentrega
            // 
            this.txtentrega.Location = new System.Drawing.Point(79, 187);
            this.txtentrega.Name = "txtentrega";
            this.txtentrega.Size = new System.Drawing.Size(100, 20);
            this.txtentrega.TabIndex = 7;
            // 
            // ckbDobra
            // 
            this.ckbDobra.AutoSize = true;
            this.ckbDobra.Location = new System.Drawing.Point(81, 53);
            this.ckbDobra.Name = "ckbDobra";
            this.ckbDobra.Size = new System.Drawing.Size(58, 17);
            this.ckbDobra.TabIndex = 8;
            this.ckbDobra.Text = "Dorbra";
            this.ckbDobra.UseVisualStyleBackColor = true;
            // 
            // ckbAnot
            // 
            this.ckbAnot.AutoSize = true;
            this.ckbAnot.Location = new System.Drawing.Point(81, 99);
            this.ckbAnot.Name = "ckbAnot";
            this.ckbAnot.Size = new System.Drawing.Size(77, 17);
            this.ckbAnot.TabIndex = 9;
            this.ckbAnot.Text = "Anotações";
            this.ckbAnot.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Livros";
            // 
            // cmbLivro
            // 
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(281, 50);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(121, 21);
            this.cmbLivro.TabIndex = 11;
            this.cmbLivro.SelectedIndexChanged += new System.EventHandler(this.cmbLivro_SelectedIndexChanged);
            // 
            // lblPrc
            // 
            this.lblPrc.AutoSize = true;
            this.lblPrc.Location = new System.Drawing.Point(278, 144);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(10, 13);
            this.lblPrc.TabIndex = 12;
            this.lblPrc.Text = ".";
            // 
            // btnCadexemp
            // 
            this.btnCadexemp.Location = new System.Drawing.Point(79, 253);
            this.btnCadexemp.Name = "btnCadexemp";
            this.btnCadexemp.Size = new System.Drawing.Size(115, 23);
            this.btnCadexemp.TabIndex = 13;
            this.btnCadexemp.Text = "Cadastrar exemplar";
            this.btnCadexemp.UseVisualStyleBackColor = true;
            this.btnCadexemp.Click += new System.EventHandler(this.btnCadexemp_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 2);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(54, 23);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Form9Cadexemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 322);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnCadexemp);
            this.Controls.Add(this.lblPrc);
            this.Controls.Add(this.cmbLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbAnot);
            this.Controls.Add(this.ckbDobra);
            this.Controls.Add(this.txtentrega);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9Cadexemplar";
            this.Text = "Form9Cadexemplar";
            this.Load += new System.EventHandler(this.Form9Cadexemplar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.TextBox txtentrega;
        private System.Windows.Forms.CheckBox ckbDobra;
        private System.Windows.Forms.CheckBox ckbAnot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.Label lblPrc;
        private System.Windows.Forms.Button btnCadexemp;
        private System.Windows.Forms.Button btnvoltar;
    }
}