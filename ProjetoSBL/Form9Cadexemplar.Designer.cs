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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtentrega = new System.Windows.Forms.TextBox();
            this.ckbDobra = new System.Windows.Forms.CheckBox();
            this.ckbAnot = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.btnCadexemp = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Situação :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forma de Entrega:";
            // 
            // txtentrega
            // 
            this.txtentrega.Location = new System.Drawing.Point(130, 77);
            this.txtentrega.Name = "txtentrega";
            this.txtentrega.Size = new System.Drawing.Size(144, 20);
            this.txtentrega.TabIndex = 7;
            // 
            // ckbDobra
            // 
            this.ckbDobra.AutoSize = true;
            this.ckbDobra.Location = new System.Drawing.Point(117, 38);
            this.ckbDobra.Name = "ckbDobra";
            this.ckbDobra.Size = new System.Drawing.Size(58, 17);
            this.ckbDobra.TabIndex = 8;
            this.ckbDobra.Text = "dobras";
            this.ckbDobra.UseVisualStyleBackColor = true;
            // 
            // ckbAnot
            // 
            this.ckbAnot.AutoSize = true;
            this.ckbAnot.Location = new System.Drawing.Point(208, 37);
            this.ckbAnot.Name = "ckbAnot";
            this.ckbAnot.Size = new System.Drawing.Size(76, 17);
            this.ckbAnot.TabIndex = 9;
            this.ckbAnot.Text = "anotações";
            this.ckbAnot.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selecione  o livro:";
            // 
            // cmbLivro
            // 
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(293, 68);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(238, 21);
            this.cmbLivro.TabIndex = 11;
            this.cmbLivro.SelectedIndexChanged += new System.EventHandler(this.cmbLivro_SelectedIndexChanged);
            // 
            // lblPrc
            // 
            this.lblPrc.AutoSize = true;
            this.lblPrc.Location = new System.Drawing.Point(501, 385);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(10, 13);
            this.lblPrc.TabIndex = 12;
            this.lblPrc.Text = ".";
            // 
            // btnCadexemp
            // 
            this.btnCadexemp.Location = new System.Drawing.Point(265, 375);
            this.btnCadexemp.Name = "btnCadexemp";
            this.btnCadexemp.Size = new System.Drawing.Size(115, 23);
            this.btnCadexemp.TabIndex = 13;
            this.btnCadexemp.Text = "Cadastrar";
            this.btnCadexemp.UseVisualStyleBackColor = true;
            this.btnCadexemp.Click += new System.EventHandler(this.btnCadexemp_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(46, 28);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 27);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "<< voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Preço :";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(130, 29);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 16;
            this.txtPreco.Text = "R$";
            // 
            // txtSituacao
            // 
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.Items.AddRange(new object[] {
            "Disponivel"});
            this.txtSituacao.Location = new System.Drawing.Point(84, 85);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(140, 21);
            this.txtSituacao.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbDobra);
            this.groupBox1.Controls.Add(this.txtSituacao);
            this.groupBox1.Controls.Add(this.ckbAnot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(46, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 188);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Estado ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "O exemplar possui ?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPreco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtentrega);
            this.groupBox2.Location = new System.Drawing.Point(377, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 188);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribuição";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form9Cadexemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnCadexemp);
            this.Controls.Add(this.lblPrc);
            this.Controls.Add(this.cmbLivro);
            this.Controls.Add(this.label5);
            this.Name = "Form9Cadexemplar";
            this.Text = "Cadastro de Exemplar ";
            this.Load += new System.EventHandler(this.Form9Cadexemplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtentrega;
        private System.Windows.Forms.CheckBox ckbDobra;
        private System.Windows.Forms.CheckBox ckbAnot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.Label lblPrc;
        private System.Windows.Forms.Button btnCadexemp;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox txtSituacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}