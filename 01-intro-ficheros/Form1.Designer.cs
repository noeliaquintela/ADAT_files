namespace _01_intro_ficheros
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
            txtNombreFichero = new TextBox();
            btnCreaFichero = new Button();
            btnBorraFichero = new Button();
            btnCrearCarpeta = new Button();
            txtNombreCarpeta = new TextBox();
            btnBorrarCarpeta = new Button();
            btnMover = new Button();
            btnLeerFichero = new Button();
            txtFicheroLeer = new TextBox();
            txtLineasFichero = new TextBox();
            groupBox1 = new GroupBox();
            btnAnadirLinea = new Button();
            btnGrabarLinea = new Button();
            txtLineaGrabar = new TextBox();
            label2 = new Label();
            txtFicheroGrabar = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreFichero
            // 
            txtNombreFichero.Location = new Point(25, 28);
            txtNombreFichero.Name = "txtNombreFichero";
            txtNombreFichero.Size = new Size(169, 23);
            txtNombreFichero.TabIndex = 0;
            // 
            // btnCreaFichero
            // 
            btnCreaFichero.Location = new Point(200, 28);
            btnCreaFichero.Name = "btnCreaFichero";
            btnCreaFichero.Size = new Size(97, 23);
            btnCreaFichero.TabIndex = 1;
            btnCreaFichero.Text = "Crear Fichero";
            btnCreaFichero.UseVisualStyleBackColor = true;
            btnCreaFichero.Click += btnCreaFichero_Click;
            // 
            // btnBorraFichero
            // 
            btnBorraFichero.Location = new Point(466, 28);
            btnBorraFichero.Name = "btnBorraFichero";
            btnBorraFichero.Size = new Size(97, 23);
            btnBorraFichero.TabIndex = 2;
            btnBorraFichero.Text = "Borrar Fichero";
            btnBorraFichero.UseVisualStyleBackColor = true;
            btnBorraFichero.Click += btnBorraFichero_Click;
            // 
            // btnCrearCarpeta
            // 
            btnCrearCarpeta.Location = new Point(200, 72);
            btnCrearCarpeta.Name = "btnCrearCarpeta";
            btnCrearCarpeta.Size = new Size(97, 23);
            btnCrearCarpeta.TabIndex = 4;
            btnCrearCarpeta.Text = "CrearCarpeta";
            btnCrearCarpeta.UseVisualStyleBackColor = true;
            btnCrearCarpeta.Click += btnCrearCarpeta_Click;
            // 
            // txtNombreCarpeta
            // 
            txtNombreCarpeta.Location = new Point(25, 72);
            txtNombreCarpeta.Name = "txtNombreCarpeta";
            txtNombreCarpeta.Size = new Size(169, 23);
            txtNombreCarpeta.TabIndex = 3;
            // 
            // btnBorrarCarpeta
            // 
            btnBorrarCarpeta.Location = new Point(466, 72);
            btnBorrarCarpeta.Name = "btnBorrarCarpeta";
            btnBorrarCarpeta.Size = new Size(97, 23);
            btnBorrarCarpeta.TabIndex = 5;
            btnBorrarCarpeta.Text = "Borrar Carpeta";
            btnBorrarCarpeta.UseVisualStyleBackColor = true;
            btnBorrarCarpeta.Click += btnBorrarCarpeta_Click;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(317, 50);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(143, 23);
            btnMover.TabIndex = 6;
            btnMover.Text = "Mover Fich a carpeta";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // btnLeerFichero
            // 
            btnLeerFichero.Location = new Point(200, 129);
            btnLeerFichero.Name = "btnLeerFichero";
            btnLeerFichero.Size = new Size(97, 23);
            btnLeerFichero.TabIndex = 8;
            btnLeerFichero.Text = "Leer Fichero";
            btnLeerFichero.UseVisualStyleBackColor = true;
            btnLeerFichero.Click += btnLeerFichero_Click;
            // 
            // txtFicheroLeer
            // 
            txtFicheroLeer.Location = new Point(25, 129);
            txtFicheroLeer.Name = "txtFicheroLeer";
            txtFicheroLeer.Size = new Size(169, 23);
            txtFicheroLeer.TabIndex = 7;
            // 
            // txtLineasFichero
            // 
            txtLineasFichero.Location = new Point(317, 130);
            txtLineasFichero.Multiline = true;
            txtLineasFichero.Name = "txtLineasFichero";
            txtLineasFichero.ScrollBars = ScrollBars.Both;
            txtLineasFichero.Size = new Size(187, 141);
            txtLineasFichero.TabIndex = 9;
            txtLineasFichero.WordWrap = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAnadirLinea);
            groupBox1.Controls.Add(btnGrabarLinea);
            groupBox1.Controls.Add(txtLineaGrabar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFicheroGrabar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 140);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grabar Fichero";
            // 
            // btnAnadirLinea
            // 
            btnAnadirLinea.Location = new Point(271, 61);
            btnAnadirLinea.Name = "btnAnadirLinea";
            btnAnadirLinea.Size = new Size(133, 23);
            btnAnadirLinea.TabIndex = 5;
            btnAnadirLinea.Text = "Añadir línea";
            btnAnadirLinea.UseVisualStyleBackColor = true;
            btnAnadirLinea.Click += btnAnadirLinea_Click;
            // 
            // btnGrabarLinea
            // 
            btnGrabarLinea.Location = new Point(271, 22);
            btnGrabarLinea.Name = "btnGrabarLinea";
            btnGrabarLinea.Size = new Size(133, 23);
            btnGrabarLinea.TabIndex = 4;
            btnGrabarLinea.Text = "Insertar Línea";
            btnGrabarLinea.UseVisualStyleBackColor = true;
            btnGrabarLinea.Click += btnGrabarLinea_Click;
            // 
            // txtLineaGrabar
            // 
            txtLineaGrabar.Location = new Point(504, 61);
            txtLineaGrabar.Name = "txtLineaGrabar";
            txtLineaGrabar.Size = new Size(169, 23);
            txtLineaGrabar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 43);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Línea a grabar:";
            // 
            // txtFicheroGrabar
            // 
            txtFicheroGrabar.Location = new Point(6, 61);
            txtFicheroGrabar.Name = "txtFicheroGrabar";
            txtFicheroGrabar.Size = new Size(169, 23);
            txtFicheroGrabar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre fichero:";
            // 
            // Form1
            // 
            AcceptButton = btnCreaFichero;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtLineasFichero);
            Controls.Add(btnLeerFichero);
            Controls.Add(txtFicheroLeer);
            Controls.Add(btnMover);
            Controls.Add(btnBorrarCarpeta);
            Controls.Add(btnCrearCarpeta);
            Controls.Add(txtNombreCarpeta);
            Controls.Add(btnBorraFichero);
            Controls.Add(btnCreaFichero);
            Controls.Add(txtNombreFichero);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreFichero;
        private Button btnCreaFichero;
        private Button btnBorraFichero;
        private Button btnCrearCarpeta;
        private TextBox txtNombreCarpeta;
        private Button btnBorrarCarpeta;
        private Button btnMover;
        private Button btnLeerFichero;
        private TextBox txtFicheroLeer;
        private TextBox txtLineasFichero;
        private GroupBox groupBox1;
        private TextBox txtLineaGrabar;
        private Label label2;
        private TextBox txtFicheroGrabar;
        private Label label1;
        private Button btnGrabarLinea;
        private Button btnAnadirLinea;
    }
}
