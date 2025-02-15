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
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            tblEstudiantes = new DataGridView();
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
            lblMensajeEliminar = new Label();
            button4 = new Button();
            txtId = new TextBox();
            label10 = new Label();
            tabPage4 = new TabPage();
            button6 = new Button();
            txtModId = new TextBox();
            label17 = new Label();
            lblModMensaje = new Label();
            button5 = new Button();
            chkModPregrado = new CheckBox();
            label11 = new Label();
            tdPckrModFechaNac = new DateTimePicker();
            txtModPromedio = new TextBox();
            txtModApellido = new TextBox();
            txtModNombre = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button10 = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblEstudiantes).BeginInit();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
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
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(tblEstudiantes);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(258, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista est";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(130, 301);
            button9.Name = "button9";
            button9.Size = new Size(120, 23);
            button9.TabIndex = 3;
            button9.Text = "Cargar postgrado";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(130, 272);
            button8.Name = "button8";
            button8.Size = new Size(122, 23);
            button8.TabIndex = 2;
            button8.Text = "Cargar pregrado";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 272);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 1;
            button7.Text = "Cargar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tblEstudiantes
            // 
            tblEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEstudiantes.Location = new Point(6, 9);
            tblEstudiantes.Name = "tblEstudiantes";
            tblEstudiantes.Size = new Size(246, 257);
            tblEstudiantes.TabIndex = 0;
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
            tabPage3.Controls.Add(lblMensajeEliminar);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(txtId);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(258, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminación";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblMensajeEliminar
            // 
            lblMensajeEliminar.AutoSize = true;
            lblMensajeEliminar.Location = new Point(24, 105);
            lblMensajeEliminar.Name = "lblMensajeEliminar";
            lblMensajeEliminar.Size = new Size(0, 15);
            lblMensajeEliminar.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(161, 17);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 20);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 0;
            label10.Text = "ID";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(txtModId);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(lblModMensaje);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(chkModPregrado);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(tdPckrModFechaNac);
            tabPage4.Controls.Add(txtModPromedio);
            tabPage4.Controls.Add(txtModApellido);
            tabPage4.Controls.Add(txtModNombre);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label16);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(258, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Modificar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(169, 23);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 22;
            button6.Text = "Verificar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtModId
            // 
            txtModId.Location = new Point(63, 21);
            txtModId.Name = "txtModId";
            txtModId.Size = new Size(100, 23);
            txtModId.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 24);
            label17.Name = "label17";
            label17.Size = new Size(18, 15);
            label17.TabIndex = 20;
            label17.Text = "ID";
            // 
            // lblModMensaje
            // 
            lblModMensaje.AutoSize = true;
            lblModMensaje.Location = new Point(26, 337);
            lblModMensaje.Name = "lblModMensaje";
            lblModMensaje.Size = new Size(0, 15);
            lblModMensaje.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(165, 285);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Actualizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // chkModPregrado
            // 
            chkModPregrado.AutoSize = true;
            chkModPregrado.Location = new Point(98, 214);
            chkModPregrado.Name = "chkModPregrado";
            chkModPregrado.Size = new Size(15, 14);
            chkModPregrado.TabIndex = 17;
            chkModPregrado.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 213);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 16;
            label11.Text = "De pregrado";
            // 
            // tdPckrModFechaNac
            // 
            tdPckrModFechaNac.Format = DateTimePickerFormat.Short;
            tdPckrModFechaNac.Location = new Point(143, 175);
            tdPckrModFechaNac.Name = "tdPckrModFechaNac";
            tdPckrModFechaNac.Size = new Size(97, 23);
            tdPckrModFechaNac.TabIndex = 15;
            // 
            // txtModPromedio
            // 
            txtModPromedio.Location = new Point(143, 240);
            txtModPromedio.Name = "txtModPromedio";
            txtModPromedio.Size = new Size(97, 23);
            txtModPromedio.TabIndex = 12;
            // 
            // txtModApellido
            // 
            txtModApellido.Location = new Point(77, 143);
            txtModApellido.Name = "txtModApellido";
            txtModApellido.Size = new Size(163, 23);
            txtModApellido.TabIndex = 13;
            // 
            // txtModNombre
            // 
            txtModNombre.Location = new Point(77, 112);
            txtModNombre.Name = "txtModNombre";
            txtModNombre.Size = new Size(163, 23);
            txtModNombre.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 181);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 8;
            label12.Text = "Fecha de nacimiento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 243);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 9;
            label13.Text = "Promedio Global";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 146);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 10;
            label14.Text = "Apellido";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 115);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 11;
            label15.Text = "Nombre";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(53, 81);
            label16.Name = "label16";
            label16.Size = new Size(184, 15);
            label16.TabIndex = 7;
            label16.Text = "MODIFICACIÓN DE ESTUDIANTES";
            // 
            // button10
            // 
            button10.Location = new Point(116, 330);
            button10.Name = "button10";
            button10.Size = new Size(134, 23);
            button10.TabIndex = 4;
            button10.Text = "Mejores estudiantes";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
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
            ((System.ComponentModel.ISupportInitialize)tblEstudiantes).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private Label lblMensajeEliminar;
        private Button button4;
        private TextBox txtId;
        private Label label10;
        private CheckBox chkModPregrado;
        private Label label11;
        private DateTimePicker tdPckrModFechaNac;
        private TextBox txtModPromedio;
        private TextBox txtModApellido;
        private TextBox txtModNombre;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtModId;
        private Label label17;
        private Label lblModMensaje;
        private Button button5;
        private Button button6;
        private DataGridView tblEstudiantes;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
