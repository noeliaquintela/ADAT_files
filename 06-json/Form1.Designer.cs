namespace _06_json
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
            btnLeerJsonLocal = new Button();
            lblResultadoFichero = new Label();
            btnSerializarAFichero = new Button();
            btnSerializarFromForm = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnAppendPersona = new Button();
            txtProfesion = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnLeerLista = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLeerJsonLocal
            // 
            btnLeerJsonLocal.Location = new Point(12, 42);
            btnLeerJsonLocal.Name = "btnLeerJsonLocal";
            btnLeerJsonLocal.Size = new Size(228, 23);
            btnLeerJsonLocal.TabIndex = 0;
            btnLeerJsonLocal.Text = "Leer personas.json";
            btnLeerJsonLocal.UseVisualStyleBackColor = true;
            btnLeerJsonLocal.Click += btnLeerJsonLocal_Click;
            // 
            // lblResultadoFichero
            // 
            lblResultadoFichero.AutoSize = true;
            lblResultadoFichero.Location = new Point(286, 50);
            lblResultadoFichero.Name = "lblResultadoFichero";
            lblResultadoFichero.Size = new Size(13, 15);
            lblResultadoFichero.TabIndex = 1;
            lblResultadoFichero.Text = "::";
            // 
            // btnSerializarAFichero
            // 
            btnSerializarAFichero.Location = new Point(548, 33);
            btnSerializarAFichero.Name = "btnSerializarAFichero";
            btnSerializarAFichero.Size = new Size(228, 23);
            btnSerializarAFichero.TabIndex = 2;
            btnSerializarAFichero.Text = "Grabar Json Macarena";
            btnSerializarAFichero.UseVisualStyleBackColor = true;
            btnSerializarAFichero.Click += btnSerializarAFichero_Click;
            // 
            // btnSerializarFromForm
            // 
            btnSerializarFromForm.Location = new Point(332, 28);
            btnSerializarFromForm.Name = "btnSerializarFromForm";
            btnSerializarFromForm.Size = new Size(228, 23);
            btnSerializarFromForm.TabIndex = 3;
            btnSerializarFromForm.Text = "Grabar Json";
            btnSerializarFromForm.UseVisualStyleBackColor = true;
            btnSerializarFromForm.Click += btnSerializarFromForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAppendPersona);
            panel1.Controls.Add(txtProfesion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSerializarFromForm);
            panel1.Location = new Point(22, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 141);
            panel1.TabIndex = 5;
            // 
            // btnAppendPersona
            // 
            btnAppendPersona.Location = new Point(332, 72);
            btnAppendPersona.Name = "btnAppendPersona";
            btnAppendPersona.Size = new Size(228, 23);
            btnAppendPersona.TabIndex = 10;
            btnAppendPersona.Text = "Añadir Persona";
            btnAppendPersona.UseVisualStyleBackColor = true;
            btnAppendPersona.Click += btnAppendPersona_Click;
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(89, 100);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(100, 23);
            txtProfesion.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Profesión";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(89, 69);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // btnLeerLista
            // 
            btnLeerLista.Location = new Point(12, 86);
            btnLeerLista.Name = "btnLeerLista";
            btnLeerLista.Size = new Size(228, 23);
            btnLeerLista.TabIndex = 6;
            btnLeerLista.Text = "Leer lista personas.json";
            btnLeerLista.UseVisualStyleBackColor = true;
            btnLeerLista.Click += btnLeerLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoFichero);
            Controls.Add(btnLeerLista);
            Controls.Add(btnSerializarAFichero);
            Controls.Add(btnLeerJsonLocal);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerJsonLocal;
        private Label lblResultadoFichero;
        private Button btnSerializarAFichero;
        private Button btnSerializarFromForm;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtProfesion;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Button btnAppendPersona;
        private Button btnLeerLista;
    }
}
