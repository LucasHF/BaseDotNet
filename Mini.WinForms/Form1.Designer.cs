namespace Mini.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Origem = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Origem
            // 
            this.Origem.Location = new System.Drawing.Point(210, 55);
            this.Origem.Name = "Origem";
            this.Origem.Size = new System.Drawing.Size(330, 27);
            this.Origem.TabIndex = 0;
            this.Origem.Text = "inicial.txt";
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(210, 120);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(330, 27);
            this.Destino.TabIndex = 1;
            this.Destino.Text = "final.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimalizador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Origem;
        private TextBox Destino;
        private Button button1;
    }
}