namespace _04_FichreoRegistrosCampos
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
            label1 = new Label();
            txtNombre = new TextBox();
            btnInsertarNota = new Button();
            numNota = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            btnGuardaModifica = new Button();
            panel2 = new Panel();
            lstNotas = new ListBox();
            btnListar = new Button();
            btnMejorNota = new Button();
            lblMejorNota = new Label();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 11);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnInsertarNota
            // 
            btnInsertarNota.Location = new Point(214, 11);
            btnInsertarNota.Name = "btnInsertarNota";
            btnInsertarNota.Size = new Size(75, 23);
            btnInsertarNota.TabIndex = 3;
            btnInsertarNota.Text = "Guardar";
            btnInsertarNota.UseMnemonic = false;
            btnInsertarNota.UseVisualStyleBackColor = true;
            btnInsertarNota.Click += btnInsertarNota_Click;
            // 
            // numNota
            // 
            numNota.Location = new Point(91, 57);
            numNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numNota.Name = "numNota";
            numNota.Size = new Size(54, 23);
            numNota.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 59);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Nota:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardaModifica);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnInsertarNota);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(numNota);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 103);
            panel1.TabIndex = 5;
            // 
            // btnGuardaModifica
            // 
            btnGuardaModifica.FlatStyle = FlatStyle.Popup;
            btnGuardaModifica.Location = new Point(183, 51);
            btnGuardaModifica.Name = "btnGuardaModifica";
            btnGuardaModifica.Size = new Size(106, 23);
            btnGuardaModifica.TabIndex = 5;
            btnGuardaModifica.Text = "Guardar/Modifiar";
            btnGuardaModifica.UseMnemonic = false;
            btnGuardaModifica.UseVisualStyleBackColor = true;
            btnGuardaModifica.Click += btnGuardaModifica_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lstNotas);
            panel2.Controls.Add(btnListar);
            panel2.Location = new Point(12, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 268);
            panel2.TabIndex = 6;
            // 
            // lstNotas
            // 
            lstNotas.FormattingEnabled = true;
            lstNotas.Location = new Point(19, 41);
            lstNotas.Name = "lstNotas";
            lstNotas.Size = new Size(244, 214);
            lstNotas.TabIndex = 6;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(116, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listado";
            btnListar.UseMnemonic = false;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnMejorNota
            // 
            btnMejorNota.Location = new Point(12, 395);
            btnMejorNota.Name = "btnMejorNota";
            btnMejorNota.Size = new Size(89, 23);
            btnMejorNota.TabIndex = 7;
            btnMejorNota.Text = "MejorNota";
            btnMejorNota.UseMnemonic = false;
            btnMejorNota.UseVisualStyleBackColor = true;
            btnMejorNota.Click += btnMejorNota_Click;
            // 
            // lblMejorNota
            // 
            lblMejorNota.AutoSize = true;
            lblMejorNota.Location = new Point(107, 399);
            lblMejorNota.Name = "lblMejorNota";
            lblMejorNota.Size = new Size(0, 15);
            lblMejorNota.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMejorNota);
            Controls.Add(btnMejorNota);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnInsertarNota;
        private NumericUpDown numNota;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private ListBox lstNotas;
        private Button btnListar;
        private Button btnMejorNota;
        private Label lblMejorNota;
        private Button btnGuardaModifica;
    }
}
