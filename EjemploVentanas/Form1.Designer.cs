namespace EjemploVentanas
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
            lblSaludo = new Label();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(26, 27);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(72, 15);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Bienvenido!!";
            lblSaludo.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(lblSaludo);
            Name = "Form1";
            Text = "Sistema de Gestion Interno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
    }
}
