
namespace _01_intro_ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaFichero_Click(object sender, EventArgs e)
        {
            //solo vamos a crear el fichero si no existe
            if (!File.Exists(this.txtNombreFichero.Text))
            {
                //crear fichero de forma simple
                //File.CreateText(this.txtNombreFichero.Text);

                //Obrener un Stream para escritura
                StreamWriter sw = File.CreateText(this.txtNombreFichero.Text);
                sw.WriteLine("Mi primera linea");
                //sw.Flush(); //sincroniza RAM con disco (dispositivo externo)
                sw.Close(); //implica un flush() implicito

            }
            else
            {
                MessageBox.Show("El fichero ya existía");
            }
        }

        private void btnBorraFichero_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtNombreFichero.Text))
            {
                File.Delete(txtNombreFichero.Text);
            }
            else
            {
                MessageBox.Show("El fichero que quieres borrar no existe");
            }

        }

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtNombreCarpeta.Text))
            {
                Directory.CreateDirectory(this.txtNombreCarpeta.Text);
            }
        }

        private void btnBorrarCarpeta_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.txtNombreCarpeta.Text))
            {
                Directory.Delete(this.txtNombreCarpeta.Text);
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtNombreFichero.Text) &&
                Directory.Exists(this.txtNombreCarpeta.Text))
            {
                File.Move(this.txtNombreFichero.Text,
                    this.txtNombreCarpeta.Text + "/" + this.txtNombreFichero.Text);
            }
        }

        private void btnLeerFichero_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtFicheroLeer.Text))
            {
                //using abre y cierra recurso en su ámbito
                using (StreamReader sr = File.OpenText(this.txtFicheroLeer.Text))
                {
                    string linea;
                    //forma 1 de escribir: var lineas = this.txtLineasFichero.Lines.ToList();
                    while ((linea = sr.ReadLine()) != null)
                    {
                        //MessageBox.Show(linea);
                        //forma 2 de escribir:
                        this.txtLineasFichero.Text += linea + Environment.NewLine;
                        //forma 1 de escribir: lineas.Add(linea);                        
                    }
                    //forma 1 de escribir: this.txtLineasFichero.Lines = lineas.ToArray();
                }

                //sin using
                //if (File.Exists(this.txtFicheroLeer.Text))
                //{
                //    StreamReader sr = File.OpenText(this.txtFicheroLeer.Text);
                //    string linea;
                //    while ((linea = sr.ReadLine()) != null)
                //    {
                //        this.txtLineasFichero.Text += linea + Environment.NewLine;
                //    }
                //    sr.Close();
                //}
            }
        }

        private void btnGrabarLinea_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(this.txtFicheroGrabar.Text))
            {
                sw.WriteLine(this.txtLineaGrabar.Text);
            }
        }

        private void btnAnadirLinea_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(this.txtFicheroGrabar.Text))
            {
                sw.WriteLine(this.txtLineaGrabar.Text);
            }
        }
    }
}
