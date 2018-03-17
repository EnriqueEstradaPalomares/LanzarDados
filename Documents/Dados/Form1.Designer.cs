namespace LanzarDados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1Lanze = new System.Windows.Forms.Button();
            this.btn100Lan = new System.Windows.Forms.Button();
            this.btn1x2x100L = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1Lanze
            // 
            this.btn1Lanze.Location = new System.Drawing.Point(28, 12);
            this.btn1Lanze.Name = "btn1Lanze";
            this.btn1Lanze.Size = new System.Drawing.Size(75, 23);
            this.btn1Lanze.TabIndex = 0;
            this.btn1Lanze.Text = "1 Lanze";
            this.btn1Lanze.UseVisualStyleBackColor = true;
            this.btn1Lanze.Click += new System.EventHandler(this.btn1Lanze_Click);
            // 
            // btn100Lan
            // 
            this.btn100Lan.Location = new System.Drawing.Point(135, 13);
            this.btn100Lan.Name = "btn100Lan";
            this.btn100Lan.Size = new System.Drawing.Size(75, 23);
            this.btn100Lan.TabIndex = 1;
            this.btn100Lan.Text = "100 Lan";
            this.btn100Lan.UseVisualStyleBackColor = true;
            this.btn100Lan.Click += new System.EventHandler(this.btn100Lan_Click);
            // 
            // btn1x2x100L
            // 
            this.btn1x2x100L.Location = new System.Drawing.Point(243, 13);
            this.btn1x2x100L.Name = "btn1x2x100L";
            this.btn1x2x100L.Size = new System.Drawing.Size(75, 23);
            this.btn1x2x100L.TabIndex = 2;
            this.btn1x2x100L.Text = "1*2*100L";
            this.btn1x2x100L.UseVisualStyleBackColor = true;
            this.btn1x2x100L.Click += new System.EventHandler(this.btn1x2x100L_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(28, 69);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(276, 283);
            this.txtShow.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 379);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btn1x2x100L);
            this.Controls.Add(this.btn100Lan);
            this.Controls.Add(this.btn1Lanze);
            this.Name = "Form1";
            this.Text = "DADOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Lanze;
        private System.Windows.Forms.Button btn100Lan;
        private System.Windows.Forms.Button btn1x2x100L;
        private System.Windows.Forms.TextBox txtShow;
    }
}

