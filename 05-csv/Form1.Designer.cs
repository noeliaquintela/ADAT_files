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
            btnLeerCSV = new Button();
            label1 = new Label();
            btnLeerCSVHelper = new Button();
            SuspendLayout();
            // 
            // btnLeerCSV
            // 
            btnLeerCSV.Location = new Point(12, 24);
            btnLeerCSV.Name = "btnLeerCSV";
            btnLeerCSV.Size = new Size(180, 52);
            btnLeerCSV.TabIndex = 0;
            btnLeerCSV.Text = "Leer CSV";
            btnLeerCSV.UseVisualStyleBackColor = true;
            btnLeerCSV.Click += btnLeerCSV_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeerCSVHelper);
            Controls.Add(label1);
            Controls.Add(btnLeerCSV);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerCSV;
        private Label label1;
        private Button btnLeerCSVHelper;
    }
}
