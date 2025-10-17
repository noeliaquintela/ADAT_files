namespace _05_csv
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
            btnLeerCSVpuntocoma = new Button();
            label1 = new Label();
            btnLeerCSVHelper = new Button();
            btnLeerCSVhelperpuntocoma = new Button();
            btnLeerCSVHelperSinEnc = new Button();
            btnGuardarCSVHelper = new Button();
            SuspendLayout();
            // 
            // btnLeerCSVpuntocoma
            // 
            btnLeerCSVpuntocoma.Location = new Point(12, 24);
            btnLeerCSVpuntocoma.Name = "btnLeerCSVpuntocoma";
            btnLeerCSVpuntocoma.Size = new Size(180, 52);
            btnLeerCSVpuntocoma.TabIndex = 0;
            btnLeerCSVpuntocoma.Text = "Leer CSV PUNTOYCOMA";
            btnLeerCSVpuntocoma.UseVisualStyleBackColor = true;
            btnLeerCSVpuntocoma.Click += btnLeerCSV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 43);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 1;
            label1.Text = "::";
            // 
            // btnLeerCSVHelper
            // 
            btnLeerCSVHelper.Location = new Point(12, 95);
            btnLeerCSVHelper.Name = "btnLeerCSVHelper";
            btnLeerCSVHelper.Size = new Size(180, 52);
            btnLeerCSVHelper.TabIndex = 2;
            btnLeerCSVHelper.Text = "Leer CSV Helper";
            btnLeerCSVHelper.UseVisualStyleBackColor = true;
            btnLeerCSVHelper.Click += btnLeerCSVHelper_Click;
            // 
            // btnLeerCSVhelperpuntocoma
            // 
            btnLeerCSVhelperpuntocoma.Location = new Point(12, 168);
            btnLeerCSVhelperpuntocoma.Name = "btnLeerCSVhelperpuntocoma";
            btnLeerCSVhelperpuntocoma.Size = new Size(180, 52);
            btnLeerCSVhelperpuntocoma.TabIndex = 3;
            btnLeerCSVhelperpuntocoma.Text = "Leer CSV Helper (punotcoma)";
            btnLeerCSVhelperpuntocoma.UseVisualStyleBackColor = true;
            btnLeerCSVhelperpuntocoma.Click += button1_Click;
            // 
            // btnLeerCSVHelperSinEnc
            // 
            btnLeerCSVHelperSinEnc.Location = new Point(23, 247);
            btnLeerCSVHelperSinEnc.Name = "btnLeerCSVHelperSinEnc";
            btnLeerCSVHelperSinEnc.Size = new Size(180, 52);
            btnLeerCSVHelperSinEnc.TabIndex = 4;
            btnLeerCSVHelperSinEnc.Text = "Leer CSV Helper sin encabezado";
            btnLeerCSVHelperSinEnc.UseVisualStyleBackColor = true;
            btnLeerCSVHelperSinEnc.Click += button2_Click;
            // 
            // btnGuardarCSVHelper
            // 
            btnGuardarCSVHelper.Location = new Point(23, 329);
            btnGuardarCSVHelper.Name = "btnGuardarCSVHelper";
            btnGuardarCSVHelper.Size = new Size(180, 52);
            btnGuardarCSVHelper.TabIndex = 5;
            btnGuardarCSVHelper.Text = "Guardar CSV Helper";
            btnGuardarCSVHelper.UseVisualStyleBackColor = true;
            btnGuardarCSVHelper.Click += btnGuardarCSVHelper_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarCSVHelper);
            Controls.Add(btnLeerCSVHelperSinEnc);
            Controls.Add(btnLeerCSVhelperpuntocoma);
            Controls.Add(btnLeerCSVHelper);
            Controls.Add(label1);
            Controls.Add(btnLeerCSVpuntocoma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerCSVpuntocoma;
        private Label label1;
        private Button btnLeerCSVHelper;
        private Button btnLeerCSVhelperpuntocoma;
        private Button btnLeerCSVHelperSinEnc;
        private Button btnGuardarCSVHelper;
    }
}
