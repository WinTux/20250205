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
            button1 = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblResultado = new Label();
            button2 = new Button();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label3 = new Label();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            lblEstudianteRegistrado = new Label();
            chckFormPregrado = new CheckBox();
            label8 = new Label();
            datePckFormFechaNac = new DateTimePicker();
            txtFormPromedio = new TextBox();
            txtFormApellido = new TextBox();
            txtFormNombre = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(26, 94);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(72, 15);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Bienvenido!!";
            // 
            // button1
            // 
            button1.Location = new Point(26, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Saludar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtNum2);
            groupBox1.Controls.Add(txtNum1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 258);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caalculadora";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(13, 134);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado: ";
            // 
            // button2
            // 
            button2.Location = new Point(94, 99);
            button2.Name = "button2";
            button2.Size = new Size(63, 23);
            button2.TabIndex = 3;
            button2.Text = "SUMAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(94, 64);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(63, 23);
            txtNum2.TabIndex = 2;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(94, 35);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(63, 23);
            txtNum1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 38);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Números:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(223, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 426);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(258, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Elementos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 33);
            label3.Name = "label3";
            label3.Size = new Size(178, 15);
            label3.TabIndex = 0;
            label3.Text = "Esta es la pesataña de elementos";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(chckFormPregrado);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(datePckFormFechaNac);
            tabPage1.Controls.Add(txtFormPromedio);
            tabPage1.Controls.Add(txtFormApellido);
            tabPage1.Controls.Add(txtFormNombre);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(258, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEstudianteRegistrado);
            groupBox2.Location = new Point(19, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 119);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estudiante registrado";
            // 
            // lblEstudianteRegistrado
            // 
            lblEstudianteRegistrado.AutoSize = true;
            lblEstudianteRegistrado.Location = new Point(16, 19);
            lblEstudianteRegistrado.Name = "lblEstudianteRegistrado";
            lblEstudianteRegistrado.Size = new Size(0, 15);
            lblEstudianteRegistrado.TabIndex = 0;
            // 
            // chckFormPregrado
            // 
            chckFormPregrado.AutoSize = true;
            chckFormPregrado.Location = new Point(97, 156);
            chckFormPregrado.Name = "chckFormPregrado";
            chckFormPregrado.Size = new Size(15, 14);
            chckFormPregrado.TabIndex = 6;
            chckFormPregrado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 155);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 5;
            label8.Text = "De pregrado";
            // 
            // datePckFormFechaNac
            // 
            datePckFormFechaNac.Format = DateTimePickerFormat.Short;
            datePckFormFechaNac.Location = new Point(142, 117);
            datePckFormFechaNac.Name = "datePckFormFechaNac";
            datePckFormFechaNac.Size = new Size(97, 23);
            datePckFormFechaNac.TabIndex = 4;
            // 
            // txtFormPromedio
            // 
            txtFormPromedio.Location = new Point(142, 182);
            txtFormPromedio.Name = "txtFormPromedio";
            txtFormPromedio.Size = new Size(97, 23);
            txtFormPromedio.TabIndex = 3;
            // 
            // txtFormApellido
            // 
            txtFormApellido.Location = new Point(76, 85);
            txtFormApellido.Name = "txtFormApellido";
            txtFormApellido.Size = new Size(163, 23);
            txtFormApellido.TabIndex = 3;
            // 
            // txtFormNombre
            // 
            txtFormNombre.Location = new Point(76, 54);
            txtFormNombre.Name = "txtFormNombre";
            txtFormNombre.Size = new Size(163, 23);
            txtFormNombre.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 123);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 2;
            label7.Text = "Fecha de nacimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 185);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 2;
            label9.Text = "Promedio Global";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 88);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 2;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 57);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 2;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 23);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 1;
            label4.Text = "REGISTRO DE ESTUDIANTES";
            // 
            // button3
            // 
            button3.Location = new Point(164, 227);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(258, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(258, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Controls.Add(lblSaludo);
            Name = "Form1";
            Text = "Sistema de Gestion Interno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Button button1;
        private TextBox txtNombre;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblResultado;
        private Button button2;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Button button3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtFormApellido;
        private TextBox txtFormNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker datePckFormFechaNac;
        private CheckBox chckFormPregrado;
        private Label label8;
        private TextBox txtFormPromedio;
        private Label label9;
        private GroupBox groupBox2;
        private Label lblEstudianteRegistrado;
    }
}
