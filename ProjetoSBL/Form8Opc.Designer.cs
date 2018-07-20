namespace ProjetoSBL
{
    partial class Form8Opc
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(37, 67);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(92, 60);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Cadastrar exempla P/ venda";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(155, 67);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(88, 60);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Compar exemplar";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // Form8Opc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnComprar);
            this.Name = "Form8Opc";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVender;
    }
}